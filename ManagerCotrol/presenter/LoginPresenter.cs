using ManagerCotrol.model.login;
using ManagerCotrol.utils;
using ManagerCotrol.views.panels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCotrol.presenter
{
    internal class LoginPresenter : OnResultCallbak
    {
        private LoginRespone loginRespone;
        private LoginView loginView;

        public LoginPresenter(LoginView loginView)
        {
            this.loginView = loginView;
            this.loginRespone = new LoginRespone(this);
        }

        public void loginFailed(string mess)
        {
            loginView.onLoginFailure(mess);
        }

        public void loginSuccess(AccountLogin account)
        {
            loginView.onLoginSuccess(account);
        }

        public void login(string user, string pass)
        {
            loginRespone.login(user, pass);
        }
    }
}
