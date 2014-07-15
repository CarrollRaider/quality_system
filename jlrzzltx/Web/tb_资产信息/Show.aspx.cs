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
namespace gzpi.Web.tb_资产信息
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
		gzpi.BLL.tb_资产信息 bll=new gzpi.BLL.tb_资产信息();
		gzpi.Model.tb_资产信息 model=bll.GetModel();
		this.lblID.Text=model.ID.ToString();
		this.lbl固定资产编号.Text=model.固定资产编号;
		this.lbl固定资产名称.Text=model.固定资产名称;
		this.lbl规格型号.Text=model.规格型号;
		this.lbl使用部门.Text=model.使用部门;
		this.lbl存放地点.Text=model.存放地点;
		this.lbl使用状况.Text=model.使用状况;
		this.lbl开始使用日期.Text=model.开始使用日期;
		this.lbl原值.Text=model.原值;
		this.lbl发票号.Text=model.发票号;
		this.lbl出厂号.Text=model.出厂号;
		this.lbl制造商.Text=model.制造商;
		this.lbl销货单位.Text=model.销货单位;
		this.lbl折旧及报废情况.Text=model.折旧及报废情况;

	}


    }
}
