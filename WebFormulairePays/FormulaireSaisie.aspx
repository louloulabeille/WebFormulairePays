<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="FormulaireSaisie.aspx.cs" Inherits="WebFormulairePays.FormulaireSaisie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Formulaire d'inscription</h2>
    <div>
        <label>Nom : </label>
        <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorNom" runat="server" ErrorMessage="Le nom est obligatoire." ControlToValidate="txtNom" BackColor="Red" ForeColor="White" SetFocusOnError="true" ></asp:RequiredFieldValidator>
        <asp:CustomValidator ID="CustomValidatorNom" ControlToValidate="txtNom" ClientValidationFunction="ValidText" runat="server" OnServerValidate="Txt_ServerValidate" ErrorMessage="La chaine saisie doit comporter entre 4 et 255 caractères." BackColor="Red" ForeColor="White"></asp:CustomValidator>
    </div>
    <div>
        <label>Prénom : </label>
        <asp:TextBox ID="txtPrenom" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPrenom" runat="server" ErrorMessage="Le Prénom est obligatoire." ControlToValidate="txtPrenom" BackColor="Red" ForeColor="White" SetFocusOnError="true"></asp:RequiredFieldValidator>
        <asp:CustomValidator ID="CustomValidatorPrenom" ControlToValidate="txtPrenom" ClientValidationFunction="ValidText" runat="server" OnServerValidate="Txt_ServerValidate" ErrorMessage="La chaine saisie doit comporter entre 4 et 255 caractères." BackColor="Red" ForeColor="White"></asp:CustomValidator>
    </div>
    <div>
        <label>Pays : </label>
        <asp:ListBox ID="listPays" runat="server"></asp:ListBox>
    </div>
    <div>
        <asp:FileUpload ID="FileUploadPhoto" runat="server"/>
    </div>
    <div>
        <asp:Button ID="btn_Envoyer" runat="server" Text="Button" OnClick="btn_Envoyer_Click" />
    </div>
    <div>
        <asp:Image ID="ImagePhoto" runat="server"/>
    </div>

<script src="/Scripts/Formulaire/formulaireSaisie.js"></script>
</asp:Content>
