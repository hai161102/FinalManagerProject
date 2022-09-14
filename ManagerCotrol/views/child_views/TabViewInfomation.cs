using ManagerCotrol.views.panels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCotrol.views.child_views
{
    internal class TabViewInfomation : PanelView
    {
        private TableLayoutPanel tableLayoutPanel;

        public TabViewInfomation(DockStyle dockStyle, int x, int y, int width, int height) : base(dockStyle, x, y, width, height)
        {

        }

        protected override void addEvent()
        {
            
        }

        protected override void initView()
        {
            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.ColumnCount = 5;
            this.Controls.Add(tableLayoutPanel);
        }
    }
}
