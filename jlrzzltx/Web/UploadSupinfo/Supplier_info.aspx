<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Supplier_info.aspx.cs" Inherits="gzpi.Web.tb_供应商信息.Add1" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <title>jquery.uploadify 上传插件的使用</title>
    <link rel="Stylesheet" href="js/uploadify.css" />
    
        <link rel="stylesheet" href="css/datepicker.css" />
    <script type="text/javascript" src="js/jquery.min.js"></script>

    <script type="text/javascript" src="js/swfobject.js"></script>

    <script type="text/javascript" src="js/jquery.uploadify.min.js"></script>
    
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <script type="text/javascript" src="js/bootstrap-datepicker.js"></script>
    
           
    

    <script type="text/javascript">

        $(document).ready(function () {
            $("#uploadify").uploadify({
                "uploader":"js/uploadify.swf",
                "script": "Upload.aspx",
                "cancelImg": "js/cancel.png",
                "folder": "upload",
                "queueID": "fileQueue",
                "auto": false,
                "multi": true,
                "wmode" : "transparent" ,
                //TODO 检测报错，等待后期处理
                //"checkScript": "upload",
                'fileDesc': "请选择rar doc pdf文件",
                'fileExt': '*.doc;*.docx;*.ppt;*.pptx,*.xls,*.xlsx,*.pdf',    //支持上传的文件类型
                'onSelect': function (e, queueId, fileObj) {
                    alert("唯一标识:" + queueId + "\r\n" +
                          "文件名：" + fileObj.name + "\r\n" +
                          "文件大小：" + fileObj.size + "\r\n" +
                          "文件类型：" + fileObj.type
                    );
                    $.ajax({
                        url: 'DtoAdd.ashx',//ajax提交路径
                        type: 'post',//提交方式
                        data: {
                            name: fileObj.name, size: fileObj.size
                            , type: fileObj.type
                        },//提交参数
                        success: function (result) {//ajax请求完成时执行，result为返回的结果

                        },
                        error: function () {
                            alert("ajax请求处理错误");
                        }
                    });
                }
            }
            );
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">   
    <div id="content-header">
				<h1>供应商信息</h1>
				<div class="btn-group">
					<a title="Manage Files" class="btn btn-large tip-bottom"><i class="icon-file"></i></a>
					<a title="Manage Users" class="btn btn-large tip-bottom"><i class="icon-pencil"></i></a>
					<a title="Manage Comments" class="btn btn-large tip-bottom"><i class="icon-trash"></i><span class="label label-important">5</span></a>
					<a title="Manage Orders" class="btn btn-large tip-bottom"><i class="icon-folder-close"></i></a>
				</div>
    </div>
    <div id="breadcrumb">
				<a title="Go to Home" class="tip-bottom" href="index.html"><i class="icon-home"></i> 主页</a>
				<a href="#">仪器设备信息库</a>
				<a class="current" href="#">供应商信息</a>
			</div>
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellspacing="0" cellpadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		供应商名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt供应商名称" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt地址" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		邮政编码
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt邮政编码" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		联系电话
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt联系电话" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		传真
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt传真" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		开户银行
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt开户银行" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		账户
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt账户" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		联系人
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt联系人" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		主要产品或服务
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt主要产品或服务" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		评估日期
	：</td>
	<td height="25" width="*" align="left">
    
		<asp:TextBox class="datepicker" data-date-format="dd-mm-yyyy" value="12-02-2012" ID="txt评估日期" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
        </td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		评估结论
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt评估结论" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
    <tr>
        
	<td height="25" width="30%" align="right">
		</td>
	<td height="25" width="*" align="left">
		 <input type="file" name="uploadify" id="uploadify" />
        <div id="fileQueue"></div>
	</td></tr>
</table>
                
       
        
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="提交" type="submit" value="Validate"
                    OnClick="btnSave_Click" class="btn btn-primary" href="javascript:$('#uploadify').uploadifyUpload()"> </asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消" type="submit" value="Validate"
                    OnClick="btnCancle_Click" class="btn btn-primary" href="javascript:$('#uploadify').uploadifyClearQueue()"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
