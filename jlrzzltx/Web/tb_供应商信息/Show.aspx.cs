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
namespace gzpi.Web.tb_供应商信息
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
					string ID= strid;
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(string ID)
	{
		gzpi.BLL.tb_供应商信息 bll=new gzpi.BLL.tb_供应商信息();
		gzpi.Model.tb_供应商信息 model=bll.GetModel(ID);
		this.lblID.Text=model.ID;
		this.lbl供应商名称.Text=model.供应商名称;
		this.lbl地址.Text=model.地址;
		this.lbl邮政编码.Text=model.邮政编码;
		this.lbl联系电话.Text=model.联系电话;
		this.lbl传真.Text=model.传真;
		this.lbl开户银行.Text=model.开户银行;
		this.lbl账户.Text=model.账户;
		this.lbl联系人.Text=model.联系人;
		this.lbl主要产品或服务.Text=model.主要产品或服务;
		this.lbl评估日期.Text=model.评估日期.ToString();
		this.lbl评估结论.Text=model.评估结论;

	}


    }
}
