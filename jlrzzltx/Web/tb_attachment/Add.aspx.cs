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
namespace gzpi.Web.tb_attachment
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtf_FileName.Text.Trim().Length==0)
			{
				strErr+="f_FileName不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtf_CreateTime.Text))
			{
				strErr+="f_CreateTime格式错误！\\n";	
			}
			if(this.txtf_FlieSize.Text.Trim().Length==0)
			{
				strErr+="f_FlieSize不能为空！\\n";	
			}
			if(this.txtf_Creator.Text.Trim().Length==0)
			{
				strErr+="f_Creator不能为空！\\n";	
			}
			if(this.txtf_FileType.Text.Trim().Length==0)
			{
				strErr+="f_FileType不能为空！\\n";	
			}
			if(this.txtf_FilePath.Text.Trim().Length==0)
			{
				strErr+="f_FilePath不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string f_FileName=this.txtf_FileName.Text;
			DateTime f_CreateTime=DateTime.Parse(this.txtf_CreateTime.Text);
			string f_FlieSize=this.txtf_FlieSize.Text;
			string f_Creator=this.txtf_Creator.Text;
			string f_FileType=this.txtf_FileType.Text;
			string f_FilePath=this.txtf_FilePath.Text;

			gzpi.Model.tb_attachment model=new gzpi.Model.tb_attachment();
			model.f_FileName=f_FileName;
			model.f_CreateTime=f_CreateTime;
			model.f_FlieSize=f_FlieSize;
			model.f_Creator=f_Creator;
			model.f_FileType=f_FileType;
			model.f_FilePath=f_FilePath;

			gzpi.BLL.tb_attachment bll=new gzpi.BLL.tb_attachment();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
