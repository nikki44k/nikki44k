<?php
include("auth_session.php"); 
require('db.php');
$status = "";
if(isset($_POST['new']) && $_POST['new']==1)
{
$trn_date = date("Y-m-d H:i:s");
$name =$_REQUEST['name'];
$lname = $_REQUEST['lastname'];
$password = $_REQUEST['password'];
$email = $_REQUEST['email'];
$submittedby = $_SESSION["username"];
$ins_query="insert into new_users (create_datetime,name,lastname,password,email,submittedby) values ('$create_datetime','$name','$lname','$password','$email','$submittedby')";
mysqli_query($con,$ins_query) or die(mysqli_error($con));
$status = "New User Inserted Successfully.</br></br><a href='preview.php'>View Inserted Users</a>";
}
?>
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>Insert New User</title>
<link rel="stylesheet" href="style.css" />
</head>
<body>
<div class="form">
<p><a href="dashboard.php">Dashboard</a> | <a href="preview.php">View Users</a> | <a href="logout.php">Logout</a></p>

<div>
<h1>Insert New User</h1>
<form name="form" method="post" action=""> 
<input type="hidden" name="new" value="1" />
<p><input type="text" name="name" placeholder="Enter First Name" required /></p>
<p><input type="text" name="lastname" placeholder="Enter Last Name" required /></p>
<p><input type="text" name="password" placeholder="Enter Password" required /></p>
<p><input type="text" name="email" placeholder="Enter Email" required /></p>
<p><input name="submit" type="submit" value="Submit" /></p>
</form>
<p style="color:#FF0000;"><?php echo $status; ?></p>

<br /><br /><br /><br />
</div>
</div>
</body>
</html>