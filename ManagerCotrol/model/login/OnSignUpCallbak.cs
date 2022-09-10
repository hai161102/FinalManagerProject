using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCotrol.model.login
{
    internal interface OnSignUpCallbak
    {
        void onSignUpSuccess();
        void onSignUpFailure(String mes);
    }
}
