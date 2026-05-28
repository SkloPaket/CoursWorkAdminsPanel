using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWorkAdminsPanel
{
    public class AddProductRequest
    {
        public string Action { get; set; }
        public string NameProduct { get; set; }

        public int Calories { get; set; }

        public int IsHealth { get; set; }

        public int IsLiquid { get; set; }
    }
}
