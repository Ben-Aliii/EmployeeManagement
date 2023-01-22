<?php

include_once '../config/database.php';

function CreateConnection()
{
    global $host;
    global $db_name;
    global $username;
    global $password;
    $connection = null;
    try
    {
        $connection = new PDO("mysql:host=".$host.";dbname=".$db_name, $username, $password);
    }
    catch (PDOException $ex)
    {
        echo json_encode
        (
            array
            (
                "success" => false,
                "message" => "Failed to connect to database.\n" . $ex->getMessage()
            )
        );
    }
    return $connection;
}

?>