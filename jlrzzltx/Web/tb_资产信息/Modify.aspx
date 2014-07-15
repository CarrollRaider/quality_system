<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="gzpi.Web.tb_资产信息.Modify" Title="修改页" %>
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
		<asp:label id="lblID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		固定资产编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt固定资产编号" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		固定资产名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt固定资产名称" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		规格型号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt规格型号" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		使用部门
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt使用部门" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		存放地点
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt存放地点" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		使用状况
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt使用状况" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		开始使用日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt开始使用日期" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		原值
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt原值" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		发票号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt发票号" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		出厂号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt出厂号" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		制造商
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt制造商" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		销货单位
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt销货单位" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		折旧及报废情况
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt折旧及报废情况" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

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

