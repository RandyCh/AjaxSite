<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/jumbotron.css" rel="stylesheet" />
</head>
<body> 
   
        <div class="jumbotron">
            <div class="container"> 
                <form id="form1" runat="server" class="form-horizontal" action="Update.aspx" method="post">
                    <div>
                        <asp:Literal ID="Literal1" runat="server"></asp:Literal>

                    </div>  
                    <button type="submit" class="btn btn-primary"><span class="glyphicon glyphicon-saved"></span>修改</button>
                </form>
                </div>
            </div>

     <footer class="container">
        <p>&copy; Company 2017-2018</p>
    </footer>

  
    
<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="js/bootstrap.min.js"></script>
</body>
</html>
