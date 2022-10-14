using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCotrol.base_app.design_view
{
    public class Padding
    {
        public int padding;
        public int paddingLeft;
        public int paddingRight;
        public int paddingTop;
        public int paddingBottom;

        public Padding(int padding)
        {
            this.padding = padding;
        }

        public Padding(int paddingLeft, int paddingRight, int paddingTop, int paddingBottom)
        {
            this.paddingLeft = paddingLeft;
            this.paddingRight = paddingRight;
            this.paddingTop = paddingTop;
            this.paddingBottom = paddingBottom;
        }
    }
}
