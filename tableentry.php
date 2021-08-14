<?php

include_once('connection.php');

function test_input($data) {
	
	//$data = trim($data);
	//$data = stripslashes($data);
	//$data = htmlspecialchars($data);
	return $data;
}

if ($_SERVER["REQUEST_METHOD"]== "POST") {
	$name = test_input($_POST['new_name']);
    $bname = test_input($_POST['new_bname']);
    $bid = test_input($_POST['new_bid']);
    $idate = test_input($_POST['new_idate']);
    $rdate = test_input($_POST['new_rdate']);
    $sql = 'INSERT INTO bookissue VALUES ( ?,?,?,?,?)';
    $stmt = $conn->prepare($sql);
    $stmt->execute([$name,$bname,$bid,$idate,$rdate]);
    echo 'added successfully!!!!!!!!!';
    
}

?>
