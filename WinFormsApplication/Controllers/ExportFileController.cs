using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApplication.Enums;

namespace WinFormsApplication.Controllers
{
    internal static class ExportFileController
    {
        internal static void ExportFile(string text, FileType fileType)
        {
            switch (fileType)
            {
                case FileType.EXCEL:
                    ExportToExcel(text);
                    break;
                case FileType.WORD:
                    ExportToWord(text);
                    break;
            }
        }
        static void ExportToExcel(string text)
        {
            
        }

        static void ExportToWord(string text)
        {

        }
    }
}
