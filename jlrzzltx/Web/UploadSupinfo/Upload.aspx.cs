
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
using System.IO;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
namespace WebApplication2
{
    public partial class Upload : System.Web.UI.Page
    {
        gzpi.Web.tb_attachment.DtoAdd tb = new gzpi.Web.tb_attachment.DtoAdd();


        protected void Page_Load(object sender, EventArgs e)
        {

            string strFloderName = DateTime.Now.ToString("yyyy/MM");
            HttpPostedFile file = Request.Files["FileData"];
            string uploadpath = Server.MapPath("~/uploads/" + strFloderName+"\\");

            if (file != null)
            {
                if (!Directory.Exists(uploadpath))
                {
                    Directory.CreateDirectory(uploadpath);
                }
                file.SaveAs(uploadpath + file.FileName);
                exchange(uploadpath);
                Response.Write("1");
            }
            else
            {
                Response.Write("0");
            }
        }

        private void exchange(string filePath)
        {
            HttpPostedFile file = Request.Files["FileData"];

            //文件名称，带后缀
            string fileName = file.FileName;
            //文件后缀
            string fileExtention = file.FileName.Substring(fileName.LastIndexOf(".") + 1);
           
            if (fileExtention == "doc" || fileExtention == "docx")
            {
                ConvertWordPDF1(filePath);
            }
            else if (fileExtention == "xlsx" || fileExtention == "xls")
            {
                ConvertExcelPDF(filePath);
            }
            else if (fileExtention == "pptx" || fileExtention == "ppt")
            {
                PPTToPdf(filePath);
            }
        }

        /// <summary>
        /// 转换word为pdf
        /// </summary>
        /// <param name="filename">doc文件路径</param>
        /// <param name="savefilename">pdf保存路径</param>
        private void ConvertWordPDF1(object filename)
        {
            // 添加COM引用 Microsoft Word 11.0 Object Library
            string tmp_FilePath = filename.ToString();
            // 先建立 Word 實體 
            Microsoft.Office.Interop.Word.ApplicationClass wordApplication = new Microsoft.Office.Interop.Word.ApplicationClass();
            Document wordDocument = null;
            // 宣告相對應等變數 
            object paramSourceDocPath = tmp_FilePath;
            object paramMissing = Type.Missing;
            // 把路徑檔名做處理... 


            Int32 intLastDot = tmp_FilePath.LastIndexOf(".");

            //*********Temp Programming****************************************

            tmp_FilePath = tmp_FilePath.Substring(0, intLastDot);

            string paramExportFilePath = null;
            WdExportFormat paramExportFormat = WdExportFormat.wdExportFormatPDF;
            // 判別 user 欲轉換的格式 ( PDF 或 XPS)
            //if (comboBox1.SelectedIndex == 0)
            //{
            paramExportFilePath = tmp_FilePath + ".pdf";
            paramExportFormat = WdExportFormat.wdExportFormatPDF;
            //}
            //else if (comboBox1.SelectedIndex == 1)
            //{
            //    paramExportFilePath = tmp_FilePath + ".xps";
            //    paramExportFormat = WdExportFormat.wdExportFormatXPS;
            //}
            // 宣告其他必要的使用變數
            bool paramOpenAfterExport = false;
            WdExportOptimizeFor paramExportOptimizeFor = WdExportOptimizeFor.wdExportOptimizeForPrint;
            WdExportRange paramExportRange = WdExportRange.wdExportAllDocument;
            int paramStartPage = 0;
            int paramEndPage = 0;
            WdExportItem paramExportItem = WdExportItem.wdExportDocumentContent;
            bool paramIncludeDocProps = true;
            bool paramKeepIRM = true;
            WdExportCreateBookmarks paramCreateBookmarks = WdExportCreateBookmarks.wdExportCreateWordBookmarks;
            bool paramDocStructureTags = true;
            bool paramBitmapMissingFonts = true;
            bool paramUseISO19005_1 = false;
            try
            {
                // 開啟來源檔案
                wordDocument = wordApplication.Documents.Open(ref paramSourceDocPath, ref paramMissing, ref paramMissing, ref paramMissing, ref paramMissing, ref paramMissing, ref paramMissing, ref paramMissing, ref paramMissing, ref paramMissing, ref paramMissing, ref paramMissing, ref paramMissing, ref paramMissing, ref paramMissing, ref paramMissing);
                // 匯出選定格式檔案 
                if (wordDocument != null)
                    wordDocument.ExportAsFixedFormat(paramExportFilePath, paramExportFormat, paramOpenAfterExport, paramExportOptimizeFor, paramExportRange, paramStartPage, paramEndPage, paramExportItem, paramIncludeDocProps, paramKeepIRM, paramCreateBookmarks, paramDocStructureTags, paramBitmapMissingFonts, paramUseISO19005_1, ref paramMissing);
                //richTextBox1.Text += "檔案轉換成功!!!\r\b ";  
                // 詢問是否要開啟轉換成功之檔案！ 
                //if (MessageBox.Show("請問是否要開啟已轉換成功之檔案？", "詢問", MessageBoxButtons.OKCancel) == DialogResult.OK)
                //{
                //    System.Diagnostics.Process.Start(paramExportFilePath);
                //}
            }
            catch (Exception ex)
            {
                //    MessageBox.Show(ex.Message); 
                //    richTextBox1.Text += ("喔喔~ 有錯誤發生了喔！ \r\b" + ex.Message + "\r\b"); 
            }
            finally
            {
                // 釋放所有物件變數資源等
                if (wordDocument != null)
                {
                    wordDocument.Close(ref paramMissing, ref paramMissing, ref paramMissing);
                    wordDocument = null;
                }
            }
        }

        /// <summary>
        /// 转换excel为pdf
        /// </summary>
        /// <param name="filename">doc文件路径</param>
        /// <param name="savefilename">pdf保存路径</param>
        public void ConvertExcelPDF(object filename)
        {
            //先引入：Microsoft.Office.Interop 
            //再 using Microsoft.Office.Interop.Excel; 


            Microsoft.Office.Interop.Excel.ApplicationClass cExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
            cExcel.Visible = true;
            object missing = Type.Missing;
            //excel 文件名：
            string excelFileName = filename.ToString();

            Int32 intLastDot = excelFileName.LastIndexOf(".");

            string tmp_FilePath = excelFileName.Substring(0, intLastDot);

            //pdf 文件名:
            string PDFFileName = tmp_FilePath + @".pdf";
            Microsoft.Office.Interop.Excel.Workbook book = null;

            try
            {
                book = cExcel.Workbooks.Open(excelFileName, missing, missing, missing, missing
                     , missing, missing, missing, missing, missing, missing
                     , missing, missing, missing, missing);

                Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)book.Worksheets[1];
                //参数1
                var formatType = Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF;
                //参数3
                var quarlity = Microsoft.Office.Interop.Excel.XlFixedFormatQuality.xlQualityStandard;

                //倒数第二个参数控制是否用pdf软件打开，false会在后台处理，不打开文件
                sheet.ExportAsFixedFormat(formatType, PDFFileName, quarlity, true, false, missing, missing, false, missing);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (book != null)
                {
                    book.Close(missing, missing, missing);
                    book = null;
                }
                cExcel.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(cExcel);
                cExcel = null;
                GC.Collect();
            }



        }


        /// <summary>
        /// PPT转换成PDF,有时候会出现错误，大致是因为ppt中的文字格式pdf没有
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="targetPath"></param>
        /// <param name="targetFileType"></param>
        /// <returns></returns>
        public static void PPTToPdf(string filename)
        {
            Microsoft.Office.Interop.PowerPoint.PpSaveAsFileType targetFileType = Microsoft.Office.Interop.PowerPoint.PpSaveAsFileType.ppSaveAsPDF;

            //excel 文件名：
            string excelFileName = filename.ToString();

            Int32 intLastDot = excelFileName.LastIndexOf(".");

            string tmp_FilePath = excelFileName.Substring(0, intLastDot);

            //pdf 文件名:
            string targetPath = tmp_FilePath + @".pdf";

            object missing = Type.Missing;
            Microsoft.Office.Interop.PowerPoint.ApplicationClass application = null;
            Microsoft.Office.Interop.PowerPoint.Presentation persentation = null;
            try
            {
                application = new Microsoft.Office.Interop.PowerPoint.ApplicationClass();
                persentation = application.Presentations.Open(filename, MsoTriState.msoTrue, MsoTriState.msoFalse, MsoTriState.msoFalse);
                persentation.SaveAs(targetPath, targetFileType, Microsoft.Office.Core.MsoTriState.msoTrue);

            }
            catch (Exception ex)
            {

            }
        }

    }
}

