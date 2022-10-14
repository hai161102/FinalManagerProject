using ManagerCotrol.views.panels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCotrol.views.child_views
{
    internal class TabViewInfomation : PanelView
    {
        private ListView listView;
        private List<String> columname;
        private List<String> columAtribute = new List<string>();
        private List<ColumnHeader> columnHeaders;

        public TabViewInfomation(DockStyle dockStyle, int x, int y, int width, int height, List<String> columName) : base(dockStyle, x, y, width, height)
        {
            this.listView = new ListView();
            this.columname = new List<string>();
            this.columnHeaders = new List<ColumnHeader>();
            columName.ForEach(c =>
            {
                columname.Add(c);
            });

            this.columname.ForEach(c =>
            {
                ColumnHeader columnHeader = new ColumnHeader();
                columnHeader.Text = c;
                columnHeader.TextAlign = HorizontalAlignment.Center;
                columnHeader.Width = width / this.columname.Count;
                this.columnHeaders.Add(columnHeader);

            });

            this.SuspendLayout();

            this.columnHeaders.ForEach(c =>
            {
                this.listView.Columns.Add(c);
            });
            
            this.listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.listView.SetBounds(0, 0, width, height);
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.GridLines = true;
            this.Controls.Add(listView);
        }

        protected override void addEvent()
        {
            
        }

        protected override void initView()
        {
            

        }
        public void addNew(List<string> info)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Font = new Font(Form1Helpers.FONT_FAMILY, 10, FontStyle.Regular);
            listViewItem.UseItemStyleForSubItems = true;
            info.ForEach(c =>
           {
               listViewItem.SubItems.Add(c);
               
           });
            listView.Items.Add(listViewItem);
        }
    }
}
