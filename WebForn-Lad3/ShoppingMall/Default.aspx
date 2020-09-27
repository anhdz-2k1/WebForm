<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShoppingMall.Default" %>
<%@ Register Src="~/UserControl/LeftMassage.ascx" TagPrefix="uc1" TagName="LeftMassage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:LeftMassage runat="server" ID="LeftMassage" />
        </div>
        <h3>Welcome!! Go for Shopping</h3>
    </form>
</body>
</html>
