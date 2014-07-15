<%@ Page Title="tb_供应商信息" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="gzpi.Web.tb_供应商信息.List" %>
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
                    BorderWidth="1px" DataKeyNames="ID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="供应商名称" HeaderText="供应商名称" SortExpression="供应商名称" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="地址" HeaderText="地址" SortExpression="地址" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="邮政编码" HeaderText="邮政编码" SortExpression="邮政编码" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="联系电话" HeaderText="联系电话" SortExpression="联系电话" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="传真" HeaderText="传真" SortExpression="传真" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="开户银行" HeaderText="开户银行" SortExpression="开户银行" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="账户" HeaderText="账户" SortExpression="账户" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="联系人" HeaderText="联系人" SortExpression="联系人" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="主要产品或服务" HeaderText="主要产品或服务" SortExpression="主要产品或服务" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="评估日期" HeaderText="评估日期" SortExpression="评估日期" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="评估结论" HeaderText="评估结论" SortExpression="评估结论" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
