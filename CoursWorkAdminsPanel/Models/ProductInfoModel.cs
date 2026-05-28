using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWorkAdminsPanel.Models
{
    public class ProductInfoModel
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public int Calories_100g { get; set; }

        public bool IsHealth { get; set; }

        public bool IsLiquid { get; set; }
    }
}
