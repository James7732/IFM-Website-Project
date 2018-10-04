<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="AlchemyGamesv2._0.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register to Alchemy Games</title>
	<meta charset="UTF-8"/>
	<meta name="viewport" content="width=device-width, initial-scale=1"/>
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css"/>
    <link rel="stylesheet" type="text/css" href="css/util.css"/>
	<link rel="stylesheet" type="text/css" href="css/main.css"/>
<!--===============================================================================================-->
</head>
<body>
  <div class="limiter">
		<div class="container-login100" style="background-image: url('images/bg-01.jpg');">
			<div class="wrap-login100 p-l-55 p-r-55 p-t-65 p-b-54">
				<form class="login100-form validate-form" runat="server">
					<span id="Usermsg" runat="server" class="login100-form-title p-b-49">
						Register to Alchemy Games
					</span>

					<div class="wrap-input100 validate-input" data-validate = "Email is required">
						<span class="label-input100">Email</span>
						<input id="userEmail" runat="server" class="input100" type="email" name="email" placeholder="Type your email"/>
						<span class="focus-input100"></span>
                        <!--data-symbol="&#128100;"-->
					</div>

                    <div class="wrap-input100 validate-input" data-validate="Username is required">
						<span class="label-input100">Username</span>
						<input id="username" runat="server" class="input100" type="text" name="username" placeholder="Type a username"/>
						<span class="focus-input100"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate="Name is required">
						<span class="label-input100">First Name</span>
						<input id="firstname" runat="server" class="input100" type="text" name="name" placeholder="Type your first name"/>
						<span class="focus-input100"></span>
					</div>
					
					<div class="wrap-input100 validate-input" data-validate="Surname is required">
						<span class="label-input100">Surname</span>
						<input id="surname" runat="server" class="input100" type="text" name="surname" placeholder="Type your surname"/>
						<span class="focus-input100"></span>
					</div>

                    <div class="wrap-input100">
						<span class="label-input100">Phone Number</span>
						<input id="phonenumber" runat="server" class="input100" type="number" name="phone" placeholder="Type your phone number (optional)"/>
						<span class="focus-input100"></span>
					</div>

                    <div class="wrap-input100 validate-input" data-validate="Password is required">
						<span class="label-input100">Password</span>
						<input id="password" runat="server" class="input100" type="password" name="pass" placeholder="Type your password"/>
						<span class="focus-input100"></span>
					</div>

                    <div class="wrap-input100 validate-input" data-validate="Confirmed password is required">
						<span class="label-input100">Confirm password</span>
						<input id="confpassword" runat="server" class="input100" type="password" name="pass" placeholder="Confirm your password"/>
						<span class="focus-input100"></span>
					</div>

                    <br/>
                    <br/>

					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
							<button id="btnRegister" runat="server" type="submit" onserverclick="Register_ServerClick" class="login100-form-btn">
								Register
							</button>
						</div>
					</div>
                    <!--
					<div class="txt1 text-center p-t-54 p-b-20">
						<span>
							Or Sign Up Using
						</span>
					</div>

					<div class="flex-c-m">
						<a href="#" class="login100-social-item bg1">
							<i class="fa fa-facebook"></i>
						</a>

						<a href="#" class="login100-social-item bg2">
							<i class="fa fa-twitter"></i>
						</a>

						<a href="#" class="login100-social-item bg3">
							<i class="fa fa-google"></i>
						</a>
					</div>
                    -->
				</form>
			</div>
		</div>
	</div>
	

	<div id="dropDownSelect1"></div>
</body>
</html>
