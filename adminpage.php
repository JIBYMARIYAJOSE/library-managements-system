<!DOCTYPE html>
<html lang="en">

<head>
	<meta charset="UTF-8">
	
	
	
	
	<title>BOOK ASSIGNMENT PAGE</title>
</head>

<body>
<!DOCTYPE html>
<html>

<body>

<!DOCTYPE html>
<html>

<html>
<head>
<script type="text/javascript" src="table_script.js"></script>
<link rel="stylesheet" href="admin.css">
</head>
<body class= "background-image"> 
<br>
<br>
<h1 class="h1">WELCOME TO LIBRARY MANAGEMENT SYSTEM</h1>

<br>
<br>
<br>
<br>
  
<form action="tableentry.php" method="post">
<div id="wrapper">
<table align='center' cellspacing=2 class="table" cellpadding=5 id="data_table" border=1>
<tr class="row">
<th class="header">STUDENTNAME</th>
<th class="header">BOOKNAME/AUTHOR</th>
<th class="header">BOOKID</th>
<th class="header">ISSUE DATE</th>
<th class="header">RETURN DATE</th>
</tr>

<tr id="row1" class="row">
<td id="name_row1" class="name">Ankit</td>
<td id="bname_row1" class="name">Book1/abc</td>
<td id="bid_row1" class="name">201</td>
<td id="idate_row1" class="name"><input type="date" id="start" name="trip-start"
       value="2021-08-01"
       min="2021-08-1" max="2030-12-31"></td>
<td id="rdate_row1" class="name"><input type="date" id="start" name="trip-start"
       value="2021-08-15"
       min="2021-01-01" max="2030-12-31"></td>
<td>
<input type="button" id="edit_button1" value="Edit" class="edit" onclick="edit_row('1')">
<input type="button" id="save_button1" value="Save" class="save" onclick="save_row('1')">
<input type="button" value="Delete" class="delete" onclick="delete_row('1')">
</td>
</tr>

<tr id="row2" class="row">
<td id="name_row2"class="name">Shawn</td>
<td id="bname_row2" class="name">Book2/cde</td>
<td id="bid_row2" class="name">263</td>
<td id="idate_row2" class="name"><input type="date" id="start" name="trip-start"
       value="2021-08-02"
       min="2021-01-01" max="2030-12-31"></td>
<td id="rdate_row2" class="name"><input type="date" id="start" name="trip-start"
       value="2021-08-16"
       min="2021-01-01" max="2030-12-31"></td>
<td>
<input type="button" id="edit_button2" value="Edit" class="edit" onclick="edit_row('2')">
<input type="button" id="save_button2" value="Save" class="save" onclick="save_row('2')">
<input type="button" value="Delete" class="delete" onclick="delete_row('2')">
</td>
</tr>

<tr id="row3" class="row">
<td id="name_row3" class="name">Rahul</td>
<td id="bname_row3" class="name">Book3/ghi</td>
<td id="bid_row3" class="name">194</td>
<td id="idate_row3" class="name"><input type="date" id="start" name="trip-start"
       value="2021-08-03"
       min="2021-01-01" max="2030-12-31"></td>
<td id="rdate_row3" class="name"><input type="date" id="start" name="trip-start"
       value="2021-08-17"
       min="2021-01-01" max="2040-12-31"></td>


<td>
<input type="button" id="edit_button3" value="Edit" class="edit" onclick="edit_row('3')">
<input type="button" id="save_button3" value="Save" class="save" onclick="save_row('3')">
<input type="button" value="Delete" class="delete" onclick="delete_row('3')">
</td>
</tr>

<tr class="row">
<td><input type="text" id="new_name" name="new_name" value=""  ></td>
<td><input type="text" id="new_bname" name="new_bname" value="" ></td>
<td><input type="number" id="new_bid" name="new_bid" value="" ></td>
<td><input type="date" id="new_idate" name="new_idate" value="0000-00-00"
       min="2021-01-01" max="2030-12-31"></td>
<td><input type="date" id="new_rdate"  name="new_rdate" value="0000-00-00"
       min="2021-01-01" max="2030-12-31"></td>
<td><input type="submit" class="add"  onclick="add_row();" value="Add Row"></td>
</tr>

</table>
</div>
</form>
</body>
</html>
</html>
</form>
