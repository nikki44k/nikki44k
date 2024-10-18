<?php
include("auth_session.php");
require('db.php');
?>
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>View Inserted New Users</title>
<link rel="stylesheet" href="style.css" />
</head>
<body>
<div class="form">
<p><a href="dashboard.php">Dashboard</a> 
| <a href="insert.php">Insert New Users</a> 
| <a href="logout.php">Logout</a></p>
<h2>View Inserted New Users</h2>
<table width="100%" border="1" style="border-collapse:collapse;">
<thead>
<tr>
<th><strong>S.No</strong></th>
<th><strong>First Name</strong></th>
<th><strong>Last Name</strong></th>
<th><strong>Password</strong></th>
<th><strong>Email</strong></th>
<th><strong>Delete</strong></th>
</tr>
</thead>
<tbody>
<?php
$count=1;
$sel_query="Select * from new_users ORDER BY id desc;";
$result = mysqli_query($con,$sel_query);
while($row = mysqli_fetch_assoc($result)) { ?>
<tr><td align="center"><?php echo $count; ?></td>
<td align="center"><?php echo $row["name"]; ?></td>
<td align="center"><?php echo $row["lastname"]; ?></td>
<td align="center"><?php echo $row["password"]; ?></td>
<td align="center"><?php echo $row["email"]; ?></td>


<td align="center">
<a href="delete.php?id=<?php echo $row["id"]; ?>">Delete</a>
</td>
</tr>
<?php $count++; } ?>
</tbody>
</table>
</div>
</body>
</html>