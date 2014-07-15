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
namespace gzpi.Web.tb_供应商信息
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string ID= Request.Params["id"];
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(string ID)
	{
		gzpi.BLL.tb_供应商信息 bll=new gzpi.BLL.tb_供应商信息();
		gzpi.Model.tb_供应商信息 model=bll.GetModel(ID);
		this.lblID.Text=model.ID;
		this.txt供应商名称.Text=model.供应商名称;
		this.txt地址.Text=model.地址;
		this.txt邮政编码.Text=model.邮政编码;
		this.txt联系电话.Text=model.联系电话;
		this.txt传真.Text=model.传真;
		this.txt开户银行.Text=model.开户银行;
		this.txt账户.Text=model.账户;
		this.txt联系人.Text=model.联系人;
		this.txt主要产品或服务.Text=model.主要产品或服务;
		this.txt评估日期.Text=model.评估日期.ToString();
		this.txt评估结论.Text=model.评估结论;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txt供应商名称.Text.Trim().Length==0)
			{
				strErr+="供应商名称不能为空！\\n";	
			}
			if(this.txt地址.Text.Trim().Length==0)
			{
				strErr+="地址不能为空！\\n";	
			}
			if(this.txt邮政编码.Text.Trim().Length==0)
			{
				strErr+="邮政编码不能为空！\\n";	
			}
			if(this.txt联系电话.Text.Trim().Length==0)
			{
				strErr+="联系电话不能为空！\\n";	
			}
			if(this.txt传真.Text.Trim().Length==0)
			{
				strErr+="传真不能为空！\\n";	
			}
			if(this.txt开户银行.Text.Trim().Length==0)
			{
				strErr+="开户银行不能为空！\\n";	
			}
			if(this.txt账户.Text.Trim().Length==0)
			{
				strErr+="账户不能为空！\\n";	
			}
			if(this.txt联系人.Text.Trim().Length==0)
			{
				strErr+="联系人不能为空！\\n";	
			}
			if(this.txt主要产品或服务.Text.Trim().Length==0)
			{
				strErr+="主要产品或服务不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txt评估日期.Text))
			{
				strErr+="评估日期格式错误！\\n";	
			}
			if(this.txt评估结论.Text.Trim().Length==0)
			{
				strErr+="评估结论不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ID=this.lblID.Text;
			string 供应商名称=this.txt供应商名称.Text;
			string 地址=this.txt地址.Text;
			string 邮政编码=this.txt邮政编码.Text;
			string 联系电话=this.txt联系电话.Text;
			string 传真=this.txt传真.Text;
			string 开户银行=this.txt开户银行.Text;
			string 账户=this.txt账户.Text;
			string 联系人=this.txt联系人.Text;
			string 主要产品或服务=this.txt主要产品或服务.Text;
			DateTime 评估日期=DateTime.Parse(this.txt评估日期.Text);
			string 评估结论=this.txt评估结论.Text;


			gzpi.Model.tb_供应商信息 model=new gzpi.Model.tb_供应商信息();
			model.ID=ID;
			model.供应商名称=供应商名称;
			model.地址=地址;
			model.邮政编码=邮政编码;
			model.联系电话=联系电话;
			model.传真=传真;
			model.开户银行=开户银行;
			model.账户=账户;
			model.联系人=联系人;
			model.主要产品或服务=主要产品或服务;
			model.评估日期=评估日期;
			model.评估结论=评估结论;

			gzpi.BLL.tb_供应商信息 bll=new gzpi.BLL.tb_供应商信息();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
