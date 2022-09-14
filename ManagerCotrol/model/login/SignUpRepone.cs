using ManagerCotrol.db.dao;
using ManagerCotrol.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCotrol.model.login
{
    internal class SignUpRepone
    {
        private OnSignUpCallbak callbak;
        private Dao dao;

        public SignUpRepone(OnSignUpCallbak callbak)
        {
            dao = new Dao();
            this.callbak = callbak;
        }

        [Obsolete]
        public void SignUp(string user, string pass, string permission)
        {
            AccountLogin account = new AccountLogin(user, pass, permission);
            if (!dao.isOpenDataBase())
            {
                dao.openDataBase();
            }
            if (!isExistAccount(account))
            {
                dao.CreateAccount(account);
                callbak.onSignUpSuccess(account);
            }
            else
            {
                callbak.onSignUpFailure("Account is exist!");
            }
            
        }

        public bool isExistAccount(AccountLogin accountSignUp)
        {
            List<AccountLogin> list = dao.getListAccountFromDB();
            for (int i = 0; i < list.Count; i++)
            {
                if (accountSignUp.getUserName() == list[i].getUserName())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
