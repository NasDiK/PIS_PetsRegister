using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApplication.Models.Classes
{
    internal class Filter
    {
        internal List<string> SettlementsName;
        internal List<(string, string)> LostDates;
        internal long PetCategoryId;

        internal bool isSettlementsFilterActive;
        internal bool isLostDatesFilterActive;
        internal bool isPetCategoryFilterActive;

        internal Filter()
        {
            this.SettlementsName = new List<string>();
            this.LostDates = new List<(string, string)>();
            this.PetCategoryId = 0;

            isSettlementsFilterActive = false;
            isLostDatesFilterActive = false;
            isPetCategoryFilterActive = false;
        }

        void ResetFilter()
        {
            this.SettlementsName = new List<string>();
            this.LostDates = new List<(string, string)>();
            this.PetCategoryId = 0;

            isSettlementsFilterActive = false;
            isLostDatesFilterActive = false;
            isPetCategoryFilterActive = false;
        }

        internal void resetDates() => this.LostDates = new List<(string, string)>();
        internal void resetSettlementsList() => this.SettlementsName = new List<string>(); //nahua
        internal void resetPetCategory() => this.PetCategoryId = 0;
    }
}
