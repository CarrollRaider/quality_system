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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace gzpi.Web.tb_供应商信息_附件
{
    public partial class Modify : Page
    {       

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
		this.txt文件名.Text=model.文件名;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txt文件名.Text.Trim().Length==0)
			{
				strErr+="文件名不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			Guid ID= new Guid(this.lblID.Text);
			Guid SID= new Guid(this.lblSID.Text);
			string 文件名=this.txt文件名.Text;


			gzpi.Model.tb_供应商信息_附件 model=new gzpi.Model.tb_供应商信息_附件();
			model.ID=ID;
			model.SID=SID;
			model.文件名=文件名;

			gzpi.BLL.tb_供应商信息_附件 bll=new gzpi.BLL.tb_供应商信息_附件();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
