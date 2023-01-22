<?php

// Required to use JWT.
include_once '../config/jwt.php';
include_once '../libs/php-jwt-main/src/BeforeValidException.php';
include_once '../libs/php-jwt-main/src/ExpiredException.php';
include_once '../libs/php-jwt-main/src/JWK.php';
include_once '../libs/php-jwt-main/src/JWT.php';
include_once '../libs/php-jwt-main/src/Key.php';
include_once '../libs/php-jwt-main/src/SignatureInvalidException.php';
use \Firebase\JWT\JWT;
use \Firebase\JWT\Key;

function Encode($data)
{
    global $key;
    global $iss;
    global $aud;
    global $iat;
    global $nbf;
    $token = array
    (
        "iss" => $iss,
        "aud" => $aud,
        "iat" => $iat,
        "nbf" => $nbf,
        "data" => $data
    );
    return JWT::encode($token, $key, 'HS256');
}

function Decode($jwt)
{
    global $key;
    if($jwt)
    {
        try
        {
            $decoded = JWT::decode($jwt, new Key($key, 'HS256'));
            return json_encode
            (
                $decoded->data
            );
        }
        catch (Exception $e)
        {
            echo json_encode
            (
                array
                (
                    "success" => false,
                    "message" => "Access denied.\n" . $e->getMessage()
                )
            );
            return null;
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
        return null;
    }
}

?>