<?php

include_once '../utility/connection.php';
include_once '../utility/token.php';

$data = json_decode($_POST["data"]);
$table = "employees";

$query = "UPDATE " . $table .
        " SET first_name=?, last_name=?, job_title=?, email=?, password=?, role=?
         WHERE id=?";

$token = Decode($data->token);
if ($token != null)
{
    $token_data = json_decode($token);
    // Check if the user has the privilege.
    if ($token_data->role == 1)
    {
        // Create a connection to the database.
        $connection = CreateConnection();

        if ($connection != null)
        {
            // Prepare the query.
            $stmt = $connection->prepare($query);

            // Bind given values.
            $stmt->bindParam(1, $data->firstname);
            $stmt->bindParam(2, $data->lastname);
            $stmt->bindParam(3, $data->jobtitle);
            $stmt->bindParam(4, $data->email);
            $stmt->bindParam(5, $data->password);
            $stmt->bindParam(6, $data->role);
            $stmt->bindParam(7, $data->id);

            try
            {
                // Execute the query.
                $stmt->execute();

                echo json_encode
                (
                    array
                    (
                        "success" => true,
                        "message" => "Row updated successfully."
                    )
                );
            }
            catch (Exception $ex)
            {
                echo json_encode
                (
                    array
                    (
                        "success" => false,
                        "message" => "Failed to update row in database.\n" . $ex->getMessage()
                    )
                );
            }
        }
    }
    else
    {
        echo json_encode
        (
            array
            (
                "success" => false,
                "message" => "Access denied."
            )
        );
    }
}

?>