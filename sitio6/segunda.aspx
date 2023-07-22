<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="segunda.aspx.cs" Inherits="sitio6.segunda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tabla genera dinámicamente</title>
    <link href="css/estilo1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Literal ID="ltTabla" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
