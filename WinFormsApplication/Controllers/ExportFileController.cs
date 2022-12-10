using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApplication.Enums;
using Xceed.Words.NET;

namespace WinFormsApplication.Controllers
{
    internal static class ExportFileController
    {
        internal static void ExportFile(string filePath, FileType fileType, params object [] args)
        {
            switch (fileType)
            {
                case FileType.EXCEL:
                    ExportToExcel(filePath, args);
                    break;
                case FileType.WORD:
                    ExportToWord(filePath, args);
                    break;
            }
        }
        static void ExportToExcel(string filePath, params object [] args)
        {
            var dt = (DataTable)args[0];

            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(dt, "WorksheetName");
            wb.SaveAs(filePath);
        }

        static void ExportToWord(string filePath, params object[] args)
        {
            var doc = (DocX?)args[0];
            doc.Save();
        }
    }
}
