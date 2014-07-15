using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gzpi.Web.tb_attachment
{
    /// <summary>
    /// DtoAdd 的摘要说明
    /// </summary>
    public class DtoAdd : IHttpHandler
    {
        
            
        public void ProcessRequest(HttpContext context)
        {
            string name = context.Request.Form["name"];
            string size = context.Request.Form["size"];
            string type = context.Request.Form["type"];
            DateTime time = DateTime.Now;
            string strFloderName = time.ToString("yyyy/MM");
            string path = "~/uploads/" + strFloderName+"/"+name;

        //这里进行数据处理 或 对数据库的操作
            setNewFile(
                name, time, size, "admin", type, path
                );
    
        }

        public void setNewFile(string f_FileName,DateTime f_CreateTime,
                                string f_FlieSize, string f_Creator,
                                string f_FileType, string f_FilePath)
        {

            gzpi.Model.tb_attachment model = new gzpi.Model.tb_attachment();
            model.f_FileName = f_FileName;
            model.f_CreateTime = f_CreateTime;
            model.f_FlieSize = f_FlieSize;
            model.f_Creator = f_Creator;
            model.f_FileType = f_FileType;
            model.f_FilePath = f_FilePath;

            gzpi.BLL.tb_attachment bll = new gzpi.BLL.tb_attachment();
            bll.Add(model);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}