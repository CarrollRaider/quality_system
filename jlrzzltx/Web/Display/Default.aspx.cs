using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gzpi.Web.Display
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            if (this.FileUpload1.HasFile)
            {

                if (PDFViewASP.ImageUtil.IsPDF(this.FileUpload1.FileName))
                {

                    this.ErrorLabel.Visible = false;

                    string savePath = Request.MapPath("PDF") + @"\" + this.FileUpload1.FileName;

                    this.FileUpload1.SaveAs(savePath);
                    
                    PDFViewer1.FileName = "C:\\Users\\ycl\\Desktop\\PDFViewASP\\PDF\\J2.pdf";

                }

                else
                {

                    this.ErrorLabel.Text = "Only PDF files (*.pdf) are allowed to be uploaded.";

                    this.ErrorLabel.Visible = true;

                }

            }



        }
    }
}