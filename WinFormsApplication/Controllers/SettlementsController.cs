using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApplication.Models.Entities;
using WinFormsApplication.Services.Database;

namespace WinFormsApplication.Controllers
{
    internal class SettlementsController
    {
        internal List<Settlement>? GetSettlementsList() => 
            DatabaseService.getAllSettlements()?.ToList();

        internal Settlement? getSettlementById(long Id) => 
            DatabaseService.getSettlementById(Id);
    }
}
