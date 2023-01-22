<?php

include_once '../utility/connection.php';
include_once '../utility/token.php';

$data = json_decode($_POST["data"]);
$table = "employees";

// Query to get employee by email and password.
$query = "SELECT *
        FROM " . $table . "
        WHERE email = ? and password = ?";

// Create a connection to the database.
$connection = CreateConnection();

if ($connection != null)
{
    // Prepare the query.
    $stmt = $connection->prepare($query);

    // Bind given values.
    $stmt->bindParam(1, $data->email);
    $stmt->bindParam(2, $data->password);

    // Execute the query.
    $stmt->execute();
    
    // Get number of rows.
    $num = $stmt->rowCount();
 
    // If email and password exist.
    if($num > 0)
    {
        // Get row details / values.
        $row = $stmt->fetch(PDO::FETCH_ASSOC);
        echo json_encode
        (
            array
            (
                "success" => true,
                "message" => null,
                "token" => Encode(array("id" => $row["id"], "email" => $data->email, "password" => $data->password, "role" => $row["role"])),
                "employee" => array
                (
                    "id" => $row["id"],
                    "first_name" => $row["first_name"],
                    "last_name" => $row["last_name"],
                    "job_title" => $row["job_title"],
                    "role" => $row["role"]
                )
            )
        );
    }
    else
    {
        // Return JSON that indicates failure.
        echo json_encode
        (
            array
            (
                "success" => false,
                "message" => "Failed to login. Incorrect email or password."
            )
        );
    }
}

?>