using System;
using System.Collections.Generic;
using System.Text;

namespace ABC_Car_Traders.model
{
    class AdminUsers
    {
        public AdminUsers(int user_id, string email, string user_name, string user_role, string password)
        {
            this.user_id = user_id;
            this.email = email;
            this.user_name = user_name;
            this.user_role = user_role;
            this.password = password;
        }

        public int user_id { get; set; }
        public string email { get; set; }
        public string user_name { get; set; }
        public string user_role { get; set; }
        public string password { get; set; }

    }
}
