using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace EmployeeManagement
{
    // The class the handles CRUD operations of the employee
    public static class EmployeeManager
    {
        public static Employee AuthenticatedUser
        {
            get
            {
                return s_AuthenticatedtUser;
            }
        }

        private static Employee s_AuthenticatedtUser;
        private static string s_Token;
        
        // This methods handles the login using an email and a password.
        public static async Task<bool> Login(string email, string password)
        {
            // Create JSON object to hold login details.
            JObject _json = new JObject();
            _json["email"] = email;
            _json["password"] = password;

            // Create a form containig JSON.
            FormUrlEncodedContent _form = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("data", _json.ToString())
            });

            // Make a POST request and get the response as a string.
            string _response = "";
            try
            {
                _response = await WebUtility.Post(Globals.EmployeeLoginUrl, _form);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Someting went wrong.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Parse the response string to JSON object.
            _json = JObject.Parse(_response);

            // Read 'success' property as a boolean.
            bool _success = (bool)_json["success"];
            if (_success)
            {
                // Store the login token for later use.
                s_Token = _json["token"].ToString();

                // Get logged in employee detaiuls.
                int _id = (int)_json["employee"]["id"];
                string _firstname = _json["employee"]["first_name"].ToString();
                string _lastname = _json["employee"]["last_name"].ToString();
                string _jobtitle = _json["employee"]["job_title"].ToString();
                int _role = (int)_json["employee"]["role"];
                s_AuthenticatedtUser = new Employee(_id, _firstname, _lastname, _jobtitle, email, _role);
            }
            else
            {
                // If the operation failed show an error message box containing the returned
                // message from the API.
                MessageBox.Show(_json["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Return the result.
            return _success;
        }

        // This methods creates a new employee with given details.
        public static async Task<bool> Create(string firstname, string lastname, string jobtitle, string email, string password, int role)
        {
            // Create JSON object to hold login details.
            JObject _json = new JObject();
            _json["firstname"] = firstname;
            _json["lastname"] = lastname;
            _json["jobtitle"] = jobtitle;
            _json["email"] = email;
            _json["password"] = password;
            _json["role"] = role;

            // Include the login token in JSON.
            _json["token"] = s_Token;

            // Create a form containig JSON.
            FormUrlEncodedContent _form = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("data", _json.ToString())
            });

            // Make a POST request and get the response as a string.
            string _response = "";
            try
            {
                _response = await WebUtility.Post(Globals.EmployeeCreateUrl, _form);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Someting went wrong.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Parse the response string to JSON object.
            _json = JObject.Parse(_response);

            // Read 'success' property as a boolean.
            bool _success = (bool)_json["success"];
            if (!_success)
            {
                // If the operation failed show an error message box containing the returned
                // message from the API.
                MessageBox.Show(_json["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Return the result.
            return _success;
        }

        // This method fetches all employees and returns them as a list.
        public static async Task<DataResult> Read(int page, int results_per_page)
        {
            // Create JSON object to hold login details.
            JObject _json = new JObject();
            _json["page"] = page;
            _json["results_per_page"] = results_per_page;

            // Include the login token in JSON.
            _json["token"] = s_Token;

            // Create a form containig JSON.
            FormUrlEncodedContent _form = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("data", _json.ToString())
            });

            // Make a POST request and get the response as a string.
            string _response = "";
            try
            {
                _response = await WebUtility.Post(Globals.EmployeeReadUrl, _form);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Someting went wrong.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            // Parse the response string to JSON object and create a list of
            // employee object and populate it with data from JSON object.
            _json = JObject.Parse(_response);
            JArray _array = (JArray)_json["employees"];
            List<Employee> _employees = new List<Employee>();
            for (int i = 0; i < _array.Count; i++)
            {
                int _id = (int)_array[i]["id"];
                string _firstname = _array[i]["first_name"].ToString();
                string _lastname = _array[i]["last_name"].ToString();
                string _jobtitle = _array[i]["job_title"].ToString();
                string _email = _array[i]["email"].ToString();
                int _role = (int)_array[i]["role"];
                _employees.Add(new Employee(_id, _firstname, _lastname, _jobtitle, _email, _role));
            }

            // Return the result.
            return new DataResult() { Employees = _employees, TotalePageCount = (int)_json["total_pages"] };
        }

        // This methods updates an existing employee details.
        public static async Task<bool> Update(int id, string firstname, string lastname, string jobtitle, string email, string password, int role)
        {
            // Create JSON object to hold login details.
            JObject _json = new JObject();
            _json["id"] = id;
            _json["firstname"] = firstname;
            _json["lastname"] = lastname;
            _json["jobtitle"] = jobtitle;
            _json["email"] = email;
            _json["password"] = password;
            _json["role"] = role;

            // Include the login token in JSON.
            _json["token"] = s_Token;

            // Create a form containig JSON.
            FormUrlEncodedContent _form = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("data", _json.ToString())
            });

            // Make a POST request and get the response as a string.
            string _response = "";
            try
            {
                _response = await WebUtility.Post(Globals.EmployeeUpdateUrl, _form);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Someting went wrong.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Parse the response string to JSON object.
            _json = JObject.Parse(_response);

            // Read 'success' property as a boolean.
            bool _success = (bool)_json["success"];
            if (!_success)
            {
                // If the operation failed show an error message box containing the returned
                // message from the API.
                MessageBox.Show(_json["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Return the result.
            return _success;
        }

        // This methods deletes an existing employee.
        public static async Task<bool> Delete(int id)
        {
            // Create JSON object to hold login details.
            JObject _json = new JObject();
            _json["id"] = id;

            // Include the login token in JSON.
            _json["token"] = s_Token;

            // Create a form containig JSON.
            FormUrlEncodedContent _form = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("data", _json.ToString())
            });

            // Make a POST request and get the response as a string.
            string _response = "";
            try
            {
                _response = await WebUtility.Post(Globals.EmployeeDeleteUrl, _form);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Someting went wrong.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Parse the response string to JSON object.
            _json = JObject.Parse(_response);

            // Read 'success' property as a boolean.
            bool _success = (bool)_json["success"];
            if (!_success)
            {
                // If the operation failed show an error message box containing the returned
                // message from the API.
                MessageBox.Show(_json["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Return the result.
            return _success;
        }

        // This method handles the search
        public static async Task<DataResult> Search(string keyword, int searchmethod)
        {
            // Create JSON object to hold login details.
            JObject _json = new JObject();
            _json["keyword"] = keyword;
            _json["searchmethod"] = searchmethod;

            // Include the login token in JSON.
            _json["token"] = s_Token;

            // Create a form containig JSON.
            FormUrlEncodedContent _form = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("data", _json.ToString())
            });

            // Make a POST request and get the response as a string.
            string _response = "";
            try
            {
                _response = await WebUtility.Post(Globals.EmployeeSearchUrl, _form);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Someting went wrong.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            // Parse the response string to JSON object and create a list of
            // employee object and populate it with data from JSON object.
            _json = JObject.Parse(_response);
            JArray _array = (JArray)_json["employees"];
            List<Employee> _employees = new List<Employee>();
            for (int i = 0; i < _array.Count; i++)
            {
                int _id = (int)_array[i]["id"];
                string _firstname = _array[i]["first_name"].ToString();
                string _lastname = _array[i]["last_name"].ToString();
                string _jobtitle = _array[i]["job_title"].ToString();
                string _email = _array[i]["email"].ToString();
                int _role = (int)_array[i]["role"];
                _employees.Add(new Employee(_id, _firstname, _lastname, _jobtitle, _email, _role));
            }

            // Return the result.
            return new DataResult() { Employees = _employees, TotalePageCount = 1 };
        }
    }
}