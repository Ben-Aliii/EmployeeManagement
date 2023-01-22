using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class MainForm : Form
    {
        public bool LoggingOut
        {
            get
            {
                return m_LoggingOut;
            }
        }

        private bool m_LoggingOut = false;
        private List<Employee> m_Employees;
        private int m_Page = 1;
        private int m_ResultsPerPage = 10;
        private int m_TotalPageCount;

        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        #region overridden methods

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Create a task that will get all employee details from the API and store
            // them in a private field and then update the UI.
            Task.Run(async () =>
            {
                ReadResult _result = await EmployeeManager.Read(m_Page, m_ResultsPerPage);
                m_TotalPageCount = _result.TotalePageCount;
                m_Employees = _result.Employees;
                UpdatePageLabel();
                UpdateListView();
            });
        }
        
        #endregion

        #region ui event methods

        private void BTN_logout_Click(object sender, EventArgs e)
        {
            m_LoggingOut = true;
            Close();
        }

        private async void BTN_add_Click(object sender, EventArgs e)
        {
            AddEmployeeForm _form = new AddEmployeeForm();
            _form.ShowDialog(this);
            if (_form.DialogResult == DialogResult.OK)
            {
                bool _success = await EmployeeManager.Create
                (
                    _form.FirstName,
                    _form.LastName,
                    _form.JobTitle,
                    _form.Email,
                    _form.Password,
                    _form.IsAdmin ? 1 : 0
                );
                if (_success)
                {
                    ReadResult _result = await EmployeeManager.Read(m_Page, m_ResultsPerPage);
                    m_TotalPageCount = _result.TotalePageCount;
                    m_Employees = _result.Employees;
                    UpdatePageLabel();
                    UpdateListView();
                }
            }
            _form.Dispose();
        }

        private async void BTN_update_Click(object sender, EventArgs e)
        {
            if (LV_employees.SelectedItems.Count <= 0)
                return;
            Employee _emp = (Employee)LV_employees.SelectedItems[0].Tag;
            AddEmployeeForm _form = new AddEmployeeForm(_emp);
            _form.ShowDialog(this);
            if (_form.DialogResult == DialogResult.OK)
            {
                bool _success = await EmployeeManager.Update
                (
                    _form.Id,
                    _form.FirstName,
                    _form.LastName,
                    _form.JobTitle,
                    _form.Email,
                    _form.Password,
                    _form.IsAdmin ? 1 : 0
                );
                if (_success)
                {
                    ReadResult _result = await EmployeeManager.Read(m_Page, m_ResultsPerPage);
                    m_TotalPageCount = _result.TotalePageCount;
                    m_Employees = _result.Employees;
                    UpdatePageLabel();
                    UpdateListView();
                }
            }
            _form.Dispose();
        }

        private async void BTN_delete_Click(object sender, EventArgs e)
        {
            if (LV_employees.SelectedItems.Count <= 0)
                return;
            Employee _emp = (Employee)LV_employees.SelectedItems[0].Tag;
            bool _success = await EmployeeManager.Delete(_emp.Id);
            if (_success)
            {
                ReadResult _result = await EmployeeManager.Read(m_Page, m_ResultsPerPage);
                m_TotalPageCount = _result.TotalePageCount;
                m_Employees = _result.Employees;
                UpdatePageLabel();
                UpdateListView();
            }
        }

        private void TXTB_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
        }

        private void TXTB_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
                e.Handled = true;
        }

        private void CB_searchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void BTN_nextpage_Click(object sender, EventArgs e)
        {
            if (m_Page < m_TotalPageCount)
            {
                m_Page++;
                Task.Run(async () =>
                {
                    ReadResult _result = await EmployeeManager.Read(m_Page, m_ResultsPerPage);
                    m_TotalPageCount = _result.TotalePageCount;
                    m_Employees = _result.Employees;
                    UpdatePageLabel();
                    UpdateListView();
                });
            }
        }

        private void BTN_previouspage_Click(object sender, EventArgs e)
        {
            if (m_Page > 1)
            {
                m_Page--;
                Task.Run(async () =>
                {
                    ReadResult _result = await EmployeeManager.Read(m_Page, m_ResultsPerPage);
                    m_TotalPageCount = _result.TotalePageCount;
                    m_Employees = _result.Employees;
                    UpdatePageLabel();
                    UpdateListView();
                });
            }
        }

        #endregion

        #region private methods

        private void Initialize()
        {
            CB_searchby.SelectedIndex = 0;
        }

        // Updates the listview with employee data from the private field.
        // It is thread-safe.
        private void UpdateListView()
        {
            LV_employees.Invoke((Action)(() => { LV_employees.Items.Clear(); }));
            if (m_Employees == null)
                return;
            List<ListViewItem> _items = new List<ListViewItem>();
            for (int i = 0; i < m_Employees.Count; i++)
            {
                ListViewItem _item = new ListViewItem();
                _item.Tag = m_Employees[i];
                _item.Text = m_Employees[i].FirstName;
                _item.SubItems.Add(m_Employees[i].LastName);
                _item.SubItems.Add(m_Employees[i].JobTitle);
                _item.SubItems.Add(m_Employees[i].Email);
                _item.SubItems.Add(m_Employees[i].IsAdmin ? "Yes" : "No");
                _items.Add(_item);
            }
            LV_employees.Invoke((Action)(() => { LV_employees.Items.AddRange(_items.ToArray()); }));
        }

        private void UpdatePageLabel()
        {
            LBL_page.Invoke((Action)(() => LBL_page.Text = m_Page + " / " + m_TotalPageCount));
        }

        // Performs search based on the text value of search textbox and the value of the dropdown.
        private void Search()
        {
            if (m_Employees == null)
                return;
            if (string.IsNullOrEmpty(TXTB_search.Text))
            {
                LV_employees.Items.Clear();
                List<ListViewItem> _items = new List<ListViewItem>();
                for (int i = 0; i < m_Employees.Count; i++)
                {
                    ListViewItem _item = new ListViewItem();
                    _item.Tag = m_Employees[i];
                    _item.Text = m_Employees[i].FirstName;
                    _item.SubItems.Add(m_Employees[i].LastName);
                    _item.SubItems.Add(m_Employees[i].JobTitle);
                    _item.SubItems.Add(m_Employees[i].Email);
                    _item.SubItems.Add(m_Employees[i].IsAdmin ? "Yes" : "No");
                    _items.Add(_item);
                }
                LV_employees.Items.AddRange(_items.ToArray());
                return;
            }
            if (CB_searchby.SelectedIndex == 0)
            {
                LV_employees.Items.Clear();
                List<ListViewItem> _items = new List<ListViewItem>();
                for (int i = 0; i < m_Employees.Count; i++)
                {
                    if (m_Employees[i].FirstName.ToLower().Contains(TXTB_search.Text.ToLower()))
                    {
                        ListViewItem _item = new ListViewItem();
                        _item.Tag = m_Employees[i];
                        _item.Text = m_Employees[i].FirstName;
                        _item.SubItems.Add(m_Employees[i].LastName);
                        _item.SubItems.Add(m_Employees[i].JobTitle);
                        _item.SubItems.Add(m_Employees[i].Email);
                        _item.SubItems.Add(m_Employees[i].IsAdmin ? "Yes" : "No");
                        _items.Add(_item);
                    }
                }
                LV_employees.Items.AddRange(_items.ToArray());
            }
            else if (CB_searchby.SelectedIndex == 1)
            {
                LV_employees.Items.Clear();
                List<ListViewItem> _items = new List<ListViewItem>();
                for (int i = 0; i < m_Employees.Count; i++)
                {
                    if (m_Employees[i].LastName.ToLower().Contains(TXTB_search.Text.ToLower()))
                    {
                        ListViewItem _item = new ListViewItem();
                        _item.Tag = m_Employees[i];
                        _item.Text = m_Employees[i].FirstName;
                        _item.SubItems.Add(m_Employees[i].LastName);
                        _item.SubItems.Add(m_Employees[i].JobTitle);
                        _item.SubItems.Add(m_Employees[i].Email);
                        _item.SubItems.Add(m_Employees[i].IsAdmin ? "Yes" : "No");
                        _items.Add(_item);
                    }
                }
                LV_employees.Items.AddRange(_items.ToArray());
            }
            else if (CB_searchby.SelectedIndex == 2)
            {
                LV_employees.Items.Clear();
                List<ListViewItem> _items = new List<ListViewItem>();
                for (int i = 0; i < m_Employees.Count; i++)
                {
                    if (m_Employees[i].JobTitle.ToLower().Contains(TXTB_search.Text.ToLower()))
                    {
                        ListViewItem _item = new ListViewItem();
                        _item.Tag = m_Employees[i];
                        _item.Text = m_Employees[i].FirstName;
                        _item.SubItems.Add(m_Employees[i].LastName);
                        _item.SubItems.Add(m_Employees[i].JobTitle);
                        _item.SubItems.Add(m_Employees[i].Email);
                        _item.SubItems.Add(m_Employees[i].IsAdmin ? "Yes" : "No");
                        _items.Add(_item);
                    }
                }
                LV_employees.Items.AddRange(_items.ToArray());
            }
            else if (CB_searchby.SelectedIndex == 3)
            {
                LV_employees.Items.Clear();
                List<ListViewItem> _items = new List<ListViewItem>();
                for (int i = 0; i < m_Employees.Count; i++)
                {
                    if (m_Employees[i].Email.ToLower().Contains(TXTB_search.Text.ToLower()))
                    {
                        ListViewItem _item = new ListViewItem();
                        _item.Tag = m_Employees[i];
                        _item.Text = m_Employees[i].FirstName;
                        _item.SubItems.Add(m_Employees[i].LastName);
                        _item.SubItems.Add(m_Employees[i].JobTitle);
                        _item.SubItems.Add(m_Employees[i].Email);
                        _item.SubItems.Add(m_Employees[i].IsAdmin ? "Yes" : "No");
                        _items.Add(_item);
                    }
                }
                LV_employees.Items.AddRange(_items.ToArray());
            }
        }

        #endregion
    }
}