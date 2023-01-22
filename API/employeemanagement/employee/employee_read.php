<?php

include_once '../utility/connection.php';
include_once '../utility/token.php';

$data = json_decode($_POST["data"]);
$table = "employees";

$query = "SELECT * FROM " . $table;

// Decode the token and check for validity.
$token = Decode($data->token);
if ($token != null)
{
    // Create a connection to the database.
    $connection = CreateConnection();

    if ($connection != null)
    {
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
                "employees" => $employees
            )
        );
    }
}

?>