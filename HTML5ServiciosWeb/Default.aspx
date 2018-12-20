<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HTML5ServiciosWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <br />
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h2><b>Nombre: </b><%=Nombre %></h2>
                <h2><b>Número: </b><%=Numero.ToString() %></h2>
                <h2><b>Fecha: </b><%=Fecha.ToString() %></h2>
            </div>
        </div>
    </div>
</body>
</html>
