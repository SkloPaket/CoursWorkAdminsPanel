using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWorkAdminsPanel.Models
{
    public class RequestModel
    {
        public string Action { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int ProductID { get; set; }
        public int DishID { get; set; }
    }
}
