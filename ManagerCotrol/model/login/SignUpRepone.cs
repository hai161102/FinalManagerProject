using ManagerCotrol.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCotrol.model.login
{
    internal class SignUpRepone
    {
        private OnSignUpCallbak callbak;

        public SignUpRepone(OnSignUpCallbak callbak)
        {
            this.callbak = callbak;
        }

        public void signUp(string user, string pass, string permission)
        {
            if (user != Infomation.USER_NAME)
            {
                Infomation.USER_NAME = user;
                Infomation.PASSWORD = pass;
                callbak.onSignUpSuccess();
            }
            else
            {
                callbak.onSignUpFailure("Account is exist!");
            }
            
        }
    }
}
