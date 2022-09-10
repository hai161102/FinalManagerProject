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

        public LoginRespone(OnResultCallbak onResultCallbak)
        {
            this.onResultCallbak = onResultCallbak;
        }

        public void login(string username, string password)
        {
            if (username == "" || password == "")
            {
                onResultCallbak.loginFailed("Info not empty!");
                return;
            }
            if (username != Infomation.USER_NAME || password != Infomation.PASSWORD)
            {
                onResultCallbak.loginFailed("Info not true");
                return ;
            }
            onResultCallbak.loginSuccess();
        }
    }
}
