using ManagerCotrol.views.child_views;
using ManagerCotrol.views.panels;
using ManagerProjectDotNet.base_app.linear;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCotrol.views.activity
{
    internal class MainActivity : LinearLayout
    {
        private TabViewInfomation tabViewInfomation;
        private string STRING_FILE = "File";
        private List<string> columNames = new List<string>();
        private String windowTitle = "Company Personal Management";
        private Label windowTitleLabel = new Label();

        public MainActivity(string width, string height, Control parent) : base(width, height, parent)
        {
            this.orientation = Orientation.Vertical;
            windowTitleLabel.Text = windowTitle;
            windowTitleLabel.Location = new Point(0, 0);
            windowTitleLabel.ForeColor = Color.White;
            windowTitleLabel.Width = this.Width;
            windowTitleLabel.Height = 100;
            windowTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            windowTitleLabel.Font = new Font(Form1Helpers.FONT_FAMILY, 16, FontStyle.Bold);


            columNames = new List<string>();
            columNames.Add("id");
            columNames.Add("id");
            columNames.Add("id");
            columNames.Add("id");
            int tabWidth = this.Width * 2 / 3;
            int tabHeight = this.Height * 2 / 3;
            tabViewInfomation = new TabViewInfomation(System.Windows.Forms.DockStyle.None,
                this.Width - tabWidth - 100,
                this.Height - tabHeight - 100,
                tabWidth,
                tabHeight,
                columNames);
            tabViewInfomation.addNew(new List<string> { "a", "b", "c", "d" });
            tabViewInfomation.Show();
            this.addView(windowTitleLabel);
            setMenuView();
            this.addView(tabViewInfomation);
            notifiDataChanged();
        }

        private void setMenuView()
        {
            MenuView menuView = new MenuView(LinearLayout.WRAP_CONTENT, LinearLayout.WRAP_CONTENT, this);
            this.addView(menuView);
        }
    }
    
}
