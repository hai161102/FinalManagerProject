using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCotrol.presenter
{
    internal interface onTextChangeListener
    {
        void onTextChange(Object sender, string newText);
    }
}
