using RestoredModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoredModel.ViewModel
{
    public class SupplementView
    {
        public int SID { get; set; }

        public string SName { get; set; }

        public string Category { get; set; }

        public string Uses { get; set; }

        public string Ingredient { get; set; }

        public string Directions { get; set; }

        public string Warnings { get; set; }

        public string OtherInfo { get; set; }

        public string Inactive { get; set; }

        public string ManuName { get; set; }    

        public static SupplementView createView (Supplement supplement)
        {
            SupplementView view = new SupplementView();
            view.SID = supplement.SID;
            view.Warnings= supplement.Warnings; 
            view.SName= supplement.SName;
            view.Uses = supplement.Uses;
            //view.Category= supplement.Category;
            view.Ingredient= supplement.Ingredient;
            view.ManuName = supplement.Manufacturer.ManuName;
            view.Inactive = supplement.InactiveIngredient;    
            view.OtherInfo= supplement.OtherInfo;
            view.Directions= supplement.Directions; 
            return view;
        }
    }
}
