using ManagerCotrol.model.login;
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
        private SignUpView SignUpView;
        private SignUpRepone SignUpRepone;

        public SignUpPresenter(SignUpView signUpView)
        {
            this.SignUpView = signUpView;
            this.SignUpRepone = new SignUpRepone(this);
        }

        public void onSignUpFailure(string mes)
        {
            this.SignUpView.onFailed(mes);
        }

        public void onSignUpSuccess()
        {
            this.SignUpView.onSucces();
        }

        public void signUp(string user, string pass, string permission)
        {
            this.SignUpRepone.signUp(user, pass, permission);
        }
    }
}
