using ManagerCotrol.views.activity.form;
using ManagerProjectDotNet.base_app.linear;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCotrol.views.child_views
{
    internal class MenuView : LinearLayout
    {
        private List<String> buttonNames = new List<String>();
        public MenuView(string width, string height, Control parent) : base(width, height, parent)
        {
            this.orientation = Orientation.Vertical;
            this.x = 0;
            this.y = 0;
            this.buttonNames.Add("Add");
            this.buttonNames.Add("Reduce");
            this.buttonNames.Add("Delete");
            this.buttonNames.Add("Update");
            this.buttonNames.Add("Clear");
            this.addListView(setViewButton());
            notifiDataChanged();
        }

        private List<Control> setViewButton()
        {
            List<Control> list = new List<Control>();
            for(int i = 0; i < buttonNames.Count; i++)
            {
                Button button = new Button();
                button.Name = buttonNames[i];
                button.Text = buttonNames[i];
                button.BackColor = Color.White;
                button.Width = 200;
                button.Height = 50;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Click += onButtonClick;
                list.Add(button);
            }

            return list;
        }

        private void onButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == buttonNames[0])
            {
                AddMemberForm add = new AddMemberForm();
                add.Show();
            }
        }
    }
}
