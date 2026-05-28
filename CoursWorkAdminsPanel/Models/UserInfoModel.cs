using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWorkAdminsPanel.Models
{
    public class UserInfoModel
    {
        public int UserID { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsBanned { get; set; }
    }
}
