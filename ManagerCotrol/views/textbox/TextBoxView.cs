using ManagerCotrol.presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCotrol.views.textbox
{
    internal class TextBoxView : TextBox
    {
        private int tbX;
        private int tbY;
        private int tbWidth;
        private int tbHeight;
        private string text;
        private onTextChangeListener onTextChangeListener;

        public int TbX { get => tbX; set => tbX = value; }
        public int TbY { get => tbY; set => tbY = value; }
        public int TbWidth { get => tbWidth; set => tbWidth = value; }
        public int TbHeight { get => tbHeight; set => tbHeight = value; }

        public String getText()
        {
            return this.text;
        }

        public void setTextChangeListener(onTextChangeListener listener)
        {
            this.onTextChangeListener = listener;
        }
        public TextBoxView(int tbX, int tbY, int tbWidth, int tbHeight)
        {
            this.tbX = tbX;
            this.tbY = tbY;
            this.tbWidth = tbWidth;
            this.tbHeight = tbHeight;
            this.SetBounds(tbX, tbY, tbWidth, tbHeight);    
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.text = this.Text;
            onTextChangeListener.onTextChange(this, this.text);
        }

        public bool isEmtyInfo()
        {
            return false;
        }
    }
}
