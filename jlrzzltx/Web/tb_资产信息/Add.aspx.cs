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
namespace gzpi.Web.tb_资产信息
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txt固定资产编号.Text.Trim().Length==0)
			{
				strErr+="固定资产编号不能为空！\\n";	
			}
			if(this.txt固定资产名称.Text.Trim().Length==0)
			{
				strErr+="固定资产名称不能为空！\\n";	
			}
			if(this.txt规格型号.Text.Trim().Length==0)
			{
				strErr+="规格型号不能为空！\\n";	
			}
			if(this.txt使用部门.Text.Trim().Length==0)
			{
				strErr+="使用部门不能为空！\\n";	
			}
			if(this.txt存放地点.Text.Trim().Length==0)
			{
				strErr+="存放地点不能为空！\\n";	
			}
			if(this.txt使用状况.Text.Trim().Length==0)
			{
				strErr+="使用状况不能为空！\\n";	
			}
			if(this.txt开始使用日期.Text.Trim().Length==0)
			{
				strErr+="开始使用日期不能为空！\\n";	
			}
			if(this.txt原值.Text.Trim().Length==0)
			{
				strErr+="原值不能为空！\\n";	
			}
			if(this.txt发票号.Text.Trim().Length==0)
			{
				strErr+="发票号不能为空！\\n";	
			}
			if(this.txt出厂号.Text.Trim().Length==0)
			{
				strErr+="出厂号不能为空！\\n";	
			}
			if(this.txt制造商.Text.Trim().Length==0)
			{
				strErr+="制造商不能为空！\\n";	
			}
			if(this.txt销货单位.Text.Trim().Length==0)
			{
				strErr+="销货单位不能为空！\\n";	
			}
			if(this.txt折旧及报废情况.Text.Trim().Length==0)
			{
				strErr+="折旧及报废情况不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string 固定资产编号=this.txt固定资产编号.Text;
			string 固定资产名称=this.txt固定资产名称.Text;
			string 规格型号=this.txt规格型号.Text;
			string 使用部门=this.txt使用部门.Text;
			string 存放地点=this.txt存放地点.Text;
			string 使用状况=this.txt使用状况.Text;
			string 开始使用日期=this.txt开始使用日期.Text;
			string 原值=this.txt原值.Text;
			string 发票号=this.txt发票号.Text;
			string 出厂号=this.txt出厂号.Text;
			string 制造商=this.txt制造商.Text;
			string 销货单位=this.txt销货单位.Text;
			string 折旧及报废情况=this.txt折旧及报废情况.Text;

			gzpi.Model.tb_资产信息 model=new gzpi.Model.tb_资产信息();
			model.固定资产编号=固定资产编号;
			model.固定资产名称=固定资产名称;
			model.规格型号=规格型号;
			model.使用部门=使用部门;
			model.存放地点=存放地点;
			model.使用状况=使用状况;
			model.开始使用日期=开始使用日期;
			model.原值=原值;
			model.发票号=发票号;
			model.出厂号=出厂号;
			model.制造商=制造商;
			model.销货单位=销货单位;
			model.折旧及报废情况=折旧及报废情况;

			gzpi.BLL.tb_资产信息 bll=new gzpi.BLL.tb_资产信息();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
