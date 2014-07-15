
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;

namespace WebApplication2
{
    public partial class Upload : System.Web.UI.Page
    {
        gzpi.Web.tb_attachment.DtoAdd tb = new gzpi.Web.tb_attachment.DtoAdd();


        protected void Page_Load(object sender, EventArgs e)
        {

            string strFloderName = DateTime.Now.ToString("yyyy/MM");
            HttpPostedFile file = Request.Files["FileData"];
            string uploadpath = Server.MapPath("~/uploads/" + strFloderName+"\\");

            if (file != null)
            {
                if (!Directory.Exists(uploadpath))
                {
                    Directory.CreateDirectory(uploadpath);
                }
                file.SaveAs(uploadpath + file.FileName);

                Response.Write("1");
            }
            else
            {
                Response.Write("0");
            }
        }
    }
}