<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="resultado.aspx.cs" Inherits="HTML5ServiciosWeb.resultado" %>

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
                <h1>Resultado</h1>
                <hr />
                <h2><b>Número 1:</b> <%=Numero1%></h2>
                <h2><b>Número 2:</b> <%=Numero2%></h2>
                <h2><b>Resultado:</b> <%=Resultado.ToString("N2")%></h2>
                <br />
                <br />
                <a href="Formulario.aspx" type="button" class="btn btn-success">Volver</a>
            </div>
        </div>
    </div>
</body>
</html>
