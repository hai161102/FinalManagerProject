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
    internal class SignUpPresenter : OnSignUpCallbak
    {
        private SignUpView signUpView;
        private SignUpRepone signUpRepone;

        public SignUpPresenter(SignUpView signUpView)
        {
            this.signUpView = signUpView;
            this.signUpRepone = new SignUpRepone(this);
        }

        public void onSignUpFailure(string mes)
        {
            this.signUpView.onFailed(mes);
        }

        public void onSignUpSuccess(AccountLogin account)
        {
            this.signUpView.onSucces(account);
        }

        [Obsolete]
        public void signUp(string user, string pass, string permission)
        {
            this.signUpRepone.SignUp(user, pass, permission);
        }
    }
}
