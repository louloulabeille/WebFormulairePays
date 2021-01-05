<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="FormulaireSaisie.aspx.cs" Inherits="WebFormulairePays.FormulaireSaisie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Formulaire d'inscription</h2>
    <div>
        <label>Nom : </label>
        <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
    </div>
    <div>
        <label>Prénom : </label>
        <asp:TextBox ID="txtPrenom" runat="server"></asp:TextBox>
    </div>
    <div>
        <label>Pays : </label>
        <asp:ListBox ID="listPays" runat="server"></asp:ListBox>
    </div>
    <div>
        <asp:Button ID="btn_Envoyer" runat="server" Text="Button" />
    </div>
</asp:Content>
