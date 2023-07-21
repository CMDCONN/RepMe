<?php
// Database connection details
$servername = "sql307.infinityfree.com";
$username = "if0_34426381";
$password = "YvdIimYuk5prw";
$dbname = "if0_34426381_RepMe";

// Retrieve the name and review rate from the request
$searchName = $_GET['name'];  // Replace with the appropriate method to retrieve the name from your form
$reviewRate = $_GET['comments'];  // Replace with the appropriate method to retrieve the review rate from your form

// Create a new PDO instance (assuming MySQL database)
try {
    $conn = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

    // Search for the name in the database
    $stmt = $conn->prepare("SELECT * FROM RepMe_Users WHERE name = :name");
    $stmt->bindParam(':name', $searchName);
    $stmt->execute();

    if ($stmt->rowCount() > 0) {
        // If the name exists, update the review rate
        $stmt = $conn->prepare("UPDATE RepMe_Users SET `comments` = :reviewRate WHERE name = :name");
        $stmt->bindParam(':name', $searchName);
        $stmt->bindParam(':reviewRate', $reviewRate);
        $stmt->execute();

        echo "Comments updated successfully.";
    } else {
        echo "Name not found in the database.";
    }
} catch (PDOException $e) {
    echo "Connection failed: " . $e->getMessage();
}
?>
