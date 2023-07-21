<?php
// Database credentials
$servername = "sql307.infinityfree.com";
$username = "if0_34426381";
$password = "YvdIimYuk5prw";
$dbname = "if0_34426381_RepMe";

// Retrieve the name and review rate from the request
$nameToSearch = $_GET['Name'];  

// Create a connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}


// SQL query to fetch data for the specific name
$sql = "SELECT reviewrate FROM RepMe_Users WHERE name = '$nameToSearch'";

// Execute the query
$result = $conn->query($sql);

// Check if any rows are returned
if ($result->num_rows > 0) {
    // Output the reviewrate for the name
    $row = $result->fetch_assoc();
    $reviewrate = $row["reviewrate"];
    
    echo "Review Rate for " . $nameToSearch . ": " . $reviewrate;
} else {
    echo "No records found for " . $nameToSearch;
}

// Close the connection
$conn->close();
?>
