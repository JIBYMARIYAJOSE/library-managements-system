<!DOCTYPE html>
<html lang="en">

<head>
    <title id="lib">LIBRARY MANAGEMENT SYSTEM</title>
	<meta charset="UTF-8">
	
	<link rel="stylesheet" type= "text/css" href="login.css">
	<title>Login Page</title>
	
</head>

<body class="body">

    <h1 class="sys" id="libmanage"><b>LIBRARY MANAGEMENT SYSTEM</b></h1>
	<script>
		var str ="WELCOME TO OUR LIBRARY MANAGEMENT SYSTEM!!!";
		var result = str.fontcolor("blue");
		document.getElementById("libmanage").innerHTML = result;
	</script>
	<form action="validate.php" method="post" class="form">
		<div class="login-box">
			<h1 class="log">Login</h1>

			<div>
               <i class="fa fa-user" aria-hidden="true"></i>
				<input type="text" placeholder="Adminname"
						name="adminname" value="">
			</div>

			<div>
                <i class="fa fa-lock" aria-hidden="true"></i>
				<input type="password" placeholder="Password"
						name="password" value="">
			</div><br>
            <input type="checkbox" name="agree">
            <label for="agree" class="agg">REMEMBER ME</label>
            
            <br>
            <br>
			<input class="button" type="submit"
					name="login" value="Sign In">
            

		</div>
	</form>
</body>

</html>
