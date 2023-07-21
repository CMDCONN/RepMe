<?php
$servername = "sql307.infinityfree.com";
$username = "if0_34426381";
$password = "YvdIimYuk5prw";
$database = "if0_34426381_RepMe";

// Create a new mysqli instance
$connection = new mysqli($servername, $username, $password, $database);

// Check if the connection was successful
if ($connection->connect_error) {
    die("Connection failed: " . $connection->connect_error);
}

echo "Connected successfully!";

// Close the connection
$connection->close();
?>
