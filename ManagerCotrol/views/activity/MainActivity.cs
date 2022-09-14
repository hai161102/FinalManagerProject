using ManagerCotrol.views.child_views;
using ManagerCotrol.views.panels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCotrol.views.activity
{
    internal class MainActivity : PanelView
    {
        private TabViewInfomation tabViewInfomation;
        private string STRING_FILE = "File";

        public MainActivity(DockStyle dockStyle, int x, int y, int width, int height) : base(dockStyle, x, y, width, height)
        {
        }

        protected override void addEvent()
        {
            
        }

        protected override void initView()
        {
            int tabWidth = this.Width * 2 / 3;
            int tabHeight = this.Height * 2 / 3;
            tabViewInfomation = new TabViewInfomation(System.Windows.Forms.DockStyle.None,
                this.Width - tabWidth - 100,
                this.Height - tabHeight - 100,
                tabWidth,
                tabHeight);
            tabViewInfomation.BackColor = Color.Aqua;
            this.Controls.Add(tabViewInfomation);
        }

        private void setMenuView()
        {
            MenuStrip menuStrip = new MenuStrip();
            //this.Controls.Add(menu);
        }
    }
}
