<?php

include_once '../utility/connection.php';
include_once '../utility/token.php';

$data = json_decode($_POST["data"]);
$table = "employees";

$page_first_result = ($data->page - 1) * $data->results_per_page;
$query = "SELECT * FROM " . $table . " LIMIT " . $page_first_result . ", " . $data->results_per_page;

// Decode the token and check for validity.
$token = Decode($data->token);
if ($token != null)
{
    // Create a connection to the database.
    $connection = CreateConnection();

    if ($connection != null)
    {
        // Get how many rows are in the table.
        $num = $connection->query("SELECT count(*) FROM " . $table)->fetchColumn();

        // Calculate the total number to pages.
        $total_pages = ceil($num / $data->results_per_page);

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
                "total_pages" => $total_pages,
                "employees" => $employees
            )
        );
    }
}

?>