<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="gzpi.Web.tb_资产信息.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		固定资产编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbl固定资产编号" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		固定资产名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbl固定资产名称" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		规格型号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbl规格型号" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		使用部门
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbl使用部门" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		存放地点
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbl存放地点" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		使用状况
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbl使用状况" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		开始使用日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbl开始使用日期" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		原值
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbl原值" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		发票号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbl发票号" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		出厂号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbl出厂号" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		制造商
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbl制造商" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		销货单位
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbl销货单位" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		折旧及报废情况
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbl折旧及报废情况" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




