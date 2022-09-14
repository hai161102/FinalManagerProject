using ManagerCotrol.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCotrol.views.panels
{
    internal interface SignUpView
    {
        void onSucces(AccountLogin account);
        void onFailed(String mes);
    }
}
