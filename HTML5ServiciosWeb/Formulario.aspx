<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="HTML5ServiciosWeb.Formulario" %>

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
                <h1>Calculadora</h1>
                <form method="post" action="">
                    <div class="form-group">
                        <label>Número 1</label>
                        <input type="text" class="form-control" value="" id="n1" name="n1"/>
                    </div>
                    <div class="form-group">
                        <label>Número 2</label>
                        <input type="text" class="form-control" value="" id="n2" name="n2"/>
                    </div>
                    <h1><b>Resultado:</b> <%=Resultado.ToString("N2")%></h1>
                    <br />
                    <br />
                    <button id="b1" type="submit" class="btn btn-success">Enviar</button>
                    <button id="b2" type="reset" class="btn btn-warning">Limpiar</button>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
