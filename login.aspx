<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="IbraVote.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
     <!-- Google Font: Source Sans Pro -->
 <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback" />
 <!-- Font Awesome -->
 <link rel="stylesheet" href="plugins/fontawesome-free/css/all.min.css" />
 <!-- Ionicons -->
 <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css" />
 <!-- Tempusdominus Bootstrap 4 -->
 <link rel="stylesheet" href="plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css" />
 <!-- iCheck -->
 <link rel="stylesheet" href="plugins/icheck-bootstrap/icheck-bootstrap.min.css" />
 <!-- JQVMap -->
 <link rel="stylesheet" href="plugins/jqvmap/jqvmap.min.css" />
 <!-- Theme style -->
 <link rel="stylesheet" href="dist/css/adminlte.min.css" />
 <!-- overlayScrollbars -->
 <link rel="stylesheet" href="plugins/overlayScrollbars/css/OverlayScrollbars.min.css" />
 <!-- Daterange picker -->
 <link rel="stylesheet" href="plugins/daterangepicker/daterangepicker.css" />
 <!-- summernote -->
 <link rel="stylesheet" href="plugins/summernote/summernote-bs4.min.css" />
</head>
<body  class="hold-transition login-page">
       <div class="login-box">
  <div class="login-logo">
    <a href="../../index2.html"><b>Vote</b>App</a>
  </div>
  <!-- /.login-logo -->
  
           <div class="card">
    <div class="card-body login-card-body">
      <p class="login-box-msg">Log In</p>

      <form id="form1" runat="server">

            <div class="input-group mb-3">
            <asp:TextBox ID="TextBox2" class="form-control" required=""  runat="server" placeholder="Name"></asp:TextBox>
             <div class="input-group-append">
           </div>
          </div>
       
          <div class="input-group mb-3">
          <asp:TextBox ID="TextBox1" class="form-control" required=""  runat="server" placeholder="username"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-envelope"></span>
            </div>
          </div>
        </div>
        
          <div class="input-group mb-3">
         <asp:TextBox ID="password" class="form-control" required=""  runat="server" placeholder="password" TextMode="Password"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-lock"></span>
            </div>
          </div>
        </div>

            <div class="input-group mb-3">
        <asp:TextBox type="number" ID="TextBox3" class="form-control" required=""  runat="server" placeholder="Age"></asp:TextBox>
         <div class="input-group-append">
        </div>
       </div>
         
        
          <div class="col-4">
             <asp:Button ID="btnlogin" class="btn btn-primary" runat="server" Text="Login" Height="42px" Width="83px"/>
          </div>
           </form>

    </div>
    <!-- /.login-card-body -->
  </div>
</div>
   
</body>
</html>
