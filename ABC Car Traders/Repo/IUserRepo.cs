using ABC_Car_Traders.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABC_Car_Traders.Repo
{
    interface IUserRepo
    {
        bool AddAdminUser(AdminUsers adminUser);

        List<AdminUsers> GetAllAdminUsers();

        List<AdminUsers> FilterAdminUserList(string filterString);

        int AdminLogin(string email, string password);
    }
}
