using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCotrol.presenter
{
    internal interface OnChangeViewListener
    {
        void OnChangeView(Panel currentPanel, Panel newPanel);
        void OnChangeViewAndClear(Panel currentPanel, Panel newPanel);
        void OnBack();
    }
}
