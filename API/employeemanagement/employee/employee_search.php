<?php

include_once '../utility/connection.php';
include_once '../utility/token.php';

$data = json_decode($_POST["data"]);
$table = "employees";

// Decode the token and check for validity.
$token = Decode($data->token);
if ($token != null)
{
    // Create a connection to the database.
    $connection = CreateConnection();

    if ($connection != null)
    {
        // Make a query based on the search method.
        $query = null;
        switch ($data->searchmethod)
        {
            case 1:
                $query = "SELECT * FROM " . $table . " WHERE first_name LIKE '%" . $data->keyword . "%'";
                break;
            case 2:
                $query = "SELECT * FROM " . $table . " WHERE last_name LIKE '%" . $data->keyword . "%'";
                break;
            case 3:
                $query = "SELECT * FROM " . $table . " WHERE job_title LIKE '%" . $data->keyword . "%'";
                break;
            case 4:
                $query = "SELECT * FROM " . $table . " WHERE email LIKE '%" . $data->keyword . "%'";
                break;
        }

        // Prepare the query.
        $stmt = $connection->prepare($query);

        // Execute the query.
        $stmt->execute();

        // Fetch the rows from the result and put them in an array.
        $employees = array();
        while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
        {
            $employees[] = $row;
        }

        // Return JSON that contains the selected rows.
        echo json_encode
        (
            array
            (
                "keyword" => $data->keyword,
                "searchmethod" => $data->searchmethod,
                "employees" => $employees
            )
        );
    }
}

?>