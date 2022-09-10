using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCotrol.model.login
{
    internal interface OnResultCallbak
    {
        void loginSuccess();
        void loginFailed(string mess);
    }
}
