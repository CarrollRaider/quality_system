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
using System.Text;
namespace gzpi.Web.tb_attachment
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					Guid f_id=new Guid(strid);
					ShowInfo(f_id);
				}
			}
		}
		
	private void ShowInfo(Guid f_id)
	{
		gzpi.BLL.tb_attachment bll=new gzpi.BLL.tb_attachment();
		gzpi.Model.tb_attachment model=bll.GetModel(f_id);
		this.lblf_id.Text=model.f_id.ToString();
		this.lblf_FileName.Text=model.f_FileName;
		this.lblf_CreateTime.Text=model.f_CreateTime.ToString();
		this.lblf_FlieSize.Text=model.f_FlieSize;
		this.lblf_Creator.Text=model.f_Creator;
		this.lblf_FileType.Text=model.f_FileType;
		this.lblf_FilePath.Text=model.f_FilePath;

	}


    }
}
