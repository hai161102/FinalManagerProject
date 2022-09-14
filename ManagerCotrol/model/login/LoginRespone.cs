using ManagerCotrol.db.dao;
using ManagerCotrol.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCotrol.model.login
{
    internal class LoginRespone
    {
        private OnResultCallbak onResultCallbak;
        List<AccountLogin> accounts = new List<AccountLogin>();
        Dao dao;

        public LoginRespone(OnResultCallbak onResultCallbak)
        {
            dao = new Dao();
            this.onResultCallbak = onResultCallbak;
        }

        public void login(string username, string password)
        {
            if (username == "" || password == "")
            {
                onResultCallbak.loginFailed("Info not empty!");
                return;
            }
            accounts = dao.getListAccountFromDB();
            accounts.ForEach(account =>
            {
                if (username == account.getUserName() || password == account.getPassword())
                {
                    onResultCallbak.loginSuccess(account);
                    return;
                }
            });
            onResultCallbak.loginFailed("Account not true, you need check account again or create new account");
        }
    }
}
