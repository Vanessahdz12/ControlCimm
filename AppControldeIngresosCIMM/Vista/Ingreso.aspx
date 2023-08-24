<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingreso.aspx.cs" Inherits="AppControldeIngresosCIMM.Vista.Ingreso" %>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="Css/Ingreso.css" rel="stylesheet" />
  <title>Login</title>
</head>
<body>
  <div class="login-container">
    <div class="login-box">
      <h1>Welcome Back!</h1>
      <form action="login.php" method="POST">
        <div class="input-container">
          <label for="username">Username</label>
          <input type="text" id="username" name="username" required>
        </div>
        <div class="input-container">
          <label for="password">Password</label>
          <input type="password" id="password" name="password" required>
        </div>
        <button type="submit">Login</button>
      </form>
    </div>
  </div>
</body>
</html>
