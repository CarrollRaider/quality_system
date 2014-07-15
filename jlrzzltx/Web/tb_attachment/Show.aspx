<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="gzpi.Web.tb_attachment.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		f_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblf_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		f_FileName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblf_FileName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		f_CreateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblf_CreateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		f_FlieSize
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblf_FlieSize" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		f_Creator
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblf_Creator" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		f_FileType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblf_FileType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		f_FilePath
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblf_FilePath" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




