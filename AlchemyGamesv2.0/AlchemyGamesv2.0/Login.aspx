<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AlchemyGamesv2._0.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login to Alchemy Games</title>
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
					<span id="userMsg" runat="server" class="login100-form-title p-b-49">
						Login to Alchemy Games
					</span>

					<div class="wrap-input100 validate-input m-b-23" data-validate = "Email is required">
						<span class="label-input100">Email</span>
						<input id="email" runat="server" class="input100" type="email" name="email" placeholder="Type your email"/>
						<span class="focus-input100" data-symbol="&#128100;"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate="Password is required">
						<span class="label-input100">Password</span>
						<input id="password" runat="server" class="input100" type="password" name="pass" placeholder="Type your password"/>
						<span class="focus-input100" data-symbol="&#128274;"></span>
					</div>
					
                    
					<div class="text-right p-t-8 p-b-31">
						<a href="#">
							<!-- Forgot password? -->
						</a>
					</div>
					
					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
                            <%--<input class="login100-form-btn" id="Signup_Button" runat="server" type="submit" onserverclick="Login_ServerClick" value="Sign Up" />--%>
                            <%--<asp:Button runat="server" ID="register_button" Text="Sign Up"  OnClick="Login_ServerClick" class="login100-form-btn"/>--%>
							<button id="btnLogin" runat="server" type="submit" onserverclick="Login_ServerClick" class="login100-form-btn">
								Login
							</button>
						</div>
					</div>

                    <br />
                    <br />

                    
					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
                            <button id="Button1" runat="server" type="submit" onserverclick="Register_ServerClick" class="login100-form-btn">
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

					<div class="flex-col-c p-t-155">
						<span class="txt1 p-b-17">
							Or Sign Up Using
						</span>

						<a href="Register.aspx" class="txt2">
							Sign Up
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
