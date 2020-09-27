<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateMember.aspx.cs" Inherits="GoldClub.CreateMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #txtName {
            height: 22px;
        }
        #txtDescription {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
          <div>
           
            <asp:Label ID="IblMessage" runat="server"></asp:Label>
            <br />
            Name:
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            Gender : 
              <asp:DropDownList ID="drpGender" runat="server">
                <asp:ListItem Selected="True" Text="--Select--" Value="--Select--"></asp:ListItem>
                <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                <asp:ListItem Text="Female" Value="Female"></asp:ListItem>              
            </asp:DropDownList>
            <br />
            <br />
           Membership Fee
            <asp:TextBox ID="txtfees" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSumbit" runat="server" Text="Sumbit" OnClick="btnSumbit_Click" />
        </div>
    </form>
</body>
</html>
