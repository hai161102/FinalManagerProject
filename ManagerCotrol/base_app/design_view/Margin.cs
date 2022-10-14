using ManagerProjectDotNet.base_app.linear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCotrol.base_app.design_view
{
    public class Margin
    {
        public int margin;
        public int marginLeft;
        public int marginRight;
        public int marginTop;
        public int marginBottom;

        public Margin(int marginLeft, int marginRight, int marginTop, int marginBottom, LinearLayout parent)
        {
            this.marginLeft = marginLeft;
            this.marginRight = marginRight;
            this.marginTop = marginTop;
            this.marginBottom = marginBottom;
            parent.x += marginLeft;
            parent.y += marginRight;
        }

        public Margin(int margin, LinearLayout parent)
        {
            this.margin = margin;
            parent.x += margin;
            parent.y += margin;
        }
    }
}
