<%@ Page Title="tb_资产信息" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="gzpi.Web.tb_资产信息.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="固定资产编号" HeaderText="固定资产编号" SortExpression="固定资产编号" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="固定资产名称" HeaderText="固定资产名称" SortExpression="固定资产名称" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="规格型号" HeaderText="规格型号" SortExpression="规格型号" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="使用部门" HeaderText="使用部门" SortExpression="使用部门" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="存放地点" HeaderText="存放地点" SortExpression="存放地点" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="使用状况" HeaderText="使用状况" SortExpression="使用状况" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="开始使用日期" HeaderText="开始使用日期" SortExpression="开始使用日期" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="原值" HeaderText="原值" SortExpression="原值" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="发票号" HeaderText="发票号" SortExpression="发票号" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="出厂号" HeaderText="出厂号" SortExpression="出厂号" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="制造商" HeaderText="制造商" SortExpression="制造商" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="销货单位" HeaderText="销货单位" SortExpression="销货单位" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="折旧及报废情况" HeaderText="折旧及报废情况" SortExpression="折旧及报废情况" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="" DataNavigateUrlFormatString="Show.aspx?"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="" DataNavigateUrlFormatString="Modify.aspx?"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
