<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>jquery.uploadify 上传插件的使用</title>
    <link rel="Stylesheet" href="js/uploadify.css" />

    <script type="text/javascript" src="js/jquery.min.js"></script>

    <script type="text/javascript" src="js/swfobject.js"></script>

    <script type="text/javascript" src="js/jquery.uploadify.min.js"></script>

    <script type="text/javascript">
        $(document).ready(function () {
            $("#uploadify").uploadify({
                "uploader": "js/uploadify.swf",
                "script": "Upload.aspx",
                "cancelImg": "js/cancel.png",
                "folder": "upload",
                "queueID": "fileQueue",
                "auto": false,
                "multi": true,
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
                            , type: fileObj.type },//提交参数
                        success: function (result) {//ajax请求完成时执行，result为返回的结果
                            
                        },
                        error: function () {
                            alert("ajax请求处理错误");
                        }
                    });
                }
            });
        });
    </script>

</head>
<body>










    <form id="form1" runat="server">
        <input type="file" name="uploadify" id="uploadify" />
        <a href="javascript:$('#uploadify').uploadifyUpload()">上传</a>| <a href="javascript:$('#uploadify').uploadifyClearQueue()"> 取消上传</a>
        <div id="fileQueue"></div>
    </form>
</body>
</html>
