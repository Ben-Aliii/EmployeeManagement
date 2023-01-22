<?php

include_once '../utility/connection.php';
include_once '../utility/token.php';

$data = json_decode($_POST["data"]);
$table = "employees";

$query = "DELETE FROM " . $table .
        " WHERE id=?";

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
            $stmt->bindParam(1, $data->id);

            try
            {
                // Execute the query.
                $stmt->execute();

                echo json_encode
                (
                    array
                    (
                        "success" => true,
                        "message" => "Row deleted successfully."
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
                        "message" => "Failed to delete row from database.\n" . $ex->getMessage()
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