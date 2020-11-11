<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs"
    Inherits="KeyVaultLctTraining._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>KEY VAULT TRAINING </h1>
        <p>&nbsp;</p>
        <p>
            Name:
            <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Secret:<asp:TextBox ID="SecretTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="GetSecretButton" runat="server" Height="33px" Text="Get Secret" OnClick="GetSecretButton_Click" />
        </p>
    </div>

    <div class="row">
    </div>

</asp:Content>
