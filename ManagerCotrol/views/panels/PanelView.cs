using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCotrol.views.panels
{
    abstract class PanelView : Panel
    {
        protected PanelView(System.Windows.Forms.DockStyle dockStyle, int x, int y, int width, int height)
        {
            this.SetBounds(x, y, width, height);
            this.Dock = dockStyle;
            initView();
            addEvent();    
        }

        abstract protected void initView();

        abstract protected void addEvent();

    }
}
