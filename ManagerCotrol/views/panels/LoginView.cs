using ManagerCotrol.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCotrol.views.panels
{
    internal interface LoginView
    {
        void onLoginSuccess(AccountLogin account);
        void onLoginFailure(string mess);
    }
}
