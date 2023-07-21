<?php
$ini = parse_ini_file('config.ini');
$link = mysqli_connect($ini['db_host'],$ini['db_user'],$ini['db_password']);
$database = mysqli_select_db($link,$ini['db_name']);

$user = $_GET['username'];
$pass = $_GET['password'];
$tables = $ini['mybb_usertable'];

$sql = "SELECT * FROM ". $tables ." WHERE Name = '". mysqli_real_escape_string($link,$user) ."'" ;
$result = $link->query($sql);

$sql2 = "SELECT * FROM ". $tables ." WHERE password = '". mysqli_real_escape_string($link,$pass) ."'" ;
$result2 = $link->query($sql2);

if ($result->num_rows > 0){
	while($row = $result->fetch_assoc())
	{
		echo "Success";
		if ($result2->num_rows > 0){
			while($row = $result2->fetch_assoc())
			{
				echo "Success2";
				
			}
		} 
		else
		{
			echo "nou2"; // User doesn't exist
		}
	}
} 
else
{
	echo "nou"; // User doesn't exist
}
?>

<head>
<title>Checking groups</title>
</head>
