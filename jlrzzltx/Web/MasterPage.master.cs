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

namespace gzpi.Web
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        public string _tabtitle = "";
        public string TabTitle
        {
            get
            {
                return _tabtitle;
            }
            set
            {
                _tabtitle = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 机构信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_Onclick_Jgxx(object sender, EventArgs e)
        {
            try
            {
                iframe1.Attributes.Add("src","/Document/机构信息.htm");
                iframe1.Visible = true;

            }
            catch (Exception ex)
            {
                //    MessageBox.Show(ex.Message); 
                //    richTextBox1.Text += ("喔喔~ 有錯誤發生了喔！ \r\b" + ex.Message + "\r\b"); 
            }
        }
        /// <summary>
        /// 体系文件库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_Onclick_Txwjk(object sender, EventArgs e)
        {
            iframe1.Attributes.Add("src", "/Document/体系文件库.htm");
            iframe1.Visible = true;

        }
        /// <summary>
        /// 检测项目信息库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_Onclick_Jcxmxxk(object sender, EventArgs e)
        {
            iframe1.Attributes.Add("src", "/Document/test.htm");
            iframe1.Visible = true;
        }
        /// <summary>
        /// 资产信息管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_Onclick_Zcxxgl(object sender, EventArgs e)
        {

            iframe1.Attributes.Add("src", "/Document/资产信息管理.htm");
            iframe1.Visible = true;
        }
        /// <summary>
        /// 供应商信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_Onclick_Gysxx(object sender, EventArgs e)
        {
            Response.Redirect("/UploadSupinfo/Supplier_info.aspx");
        }
        /// <summary>
        /// 控制管理信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_Onclick_Kzglxx(object sender, EventArgs e)
        {
            iframe1.Attributes.Add("src", "/Document/控制管理信息.htm");
            iframe1.Visible = true;
        }
        /// <summary>
        /// 检定/校准信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_Onclick_Jdjzxx(object sender, EventArgs e)
        {
            iframe1.Attributes.Add("src", "/Document/检定或校准信息.htm");
            iframe1.Visible = true;
        }
        /// <summary>
        /// 期间核查信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_Onclick_Qjhcxx(object sender, EventArgs e)
        {
            iframe1.Attributes.Add("src", "/Document/期间核查信息.htm");
            iframe1.Visible = true;
        }
        /// <summary>
        /// 从业人员信息库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_Onclick_Cyryxxk(object sender, EventArgs e)
        {
            iframe1.Attributes.Add("src", "/Document/从业人员信息库.htm");
            iframe1.Visible = true;
        }
        /// <summary>
        /// 管理过程记录库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_Onclick_Glgcjlk(object sender, EventArgs e)
        {
            iframe1.Attributes.Add("src", "/Document/管理过程记录库.htm");
            iframe1.Visible = true;
        }
        /// <summary>
        /// 体系评价表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_Onclick_Txpjb(object sender, EventArgs e)
        {
            iframe1.Attributes.Add("src", "/Document/体系评价表.htm");
            iframe1.Visible = true;
        }
    }
}
