﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="gzpi.Web.tb_attachment.Modify" Title="修改页" %>
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
		<asp:label id="lblf_id" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		f_FileName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtf_FileName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		f_CreateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtf_CreateTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		f_FlieSize
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtf_FlieSize" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		f_Creator
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtf_Creator" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		f_FileType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtf_FileType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		f_FilePath
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtf_FilePath" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

