<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="gzpi.Web.Display.Default" %>
<%@ Register src="PDFViewer.ascx" tagname="PDFViewer" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <asp:FileUpload ID="FileUpload1" runat="server" Width="224px" />

        <asp:Button ID="Button1" runat="server" Text="View PDF" 

            onclick="Button1_Click" />

        &nbsp;&nbsp;<asp:Label ID="ErrorLabel" runat="server" Text="" ForeColor="#CC0000" Visible="False"></asp:Label>

    

    </div>

    <uc1:PDFViewer ID="PDFViewer1" runat="server" />
</asp:Content>
