using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApplication.Models.Entities
{
    internal class Photography
    {
        public int Id { get; set; }
        public Advertisment? Advertisment { get; set; }
        public string? FilePath { get; set; }
        public bool isGeneral { get; set; }
    }
}
