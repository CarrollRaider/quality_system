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
namespace gzpi.Web.tb_供应商信息_附件
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
		
	private void ShowInfo()
	{
		gzpi.BLL.tb_供应商信息_附件 bll=new gzpi.BLL.tb_供应商信息_附件();
		gzpi.Model.tb_供应商信息_附件 model=bll.GetModel();
		this.lblID.Text=model.ID.ToString();
		this.lblSID.Text=model.SID.ToString();
		this.lbl文件名.Text=model.文件名;

	}


    }
}
