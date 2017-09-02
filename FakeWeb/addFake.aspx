<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addFake.aspx.cs" Inherits="FakeWeb.addFake" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h2>Add fake</h2>
    <form id="form1" runat="server">
        <input type="text" placeholder="Title"/><br/>
        <asp:FileUpload ID="FileUpload1" runat="server" /><br/>
        <input id="Submit1" type="submit" value="Add" />
    </form>
</body>
</html>
