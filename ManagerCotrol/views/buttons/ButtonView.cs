using ManagerCotrol.presenter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCotrol.views.buttons
{
    internal class ButtonView : Button
    {
        private int btX;
        private int btY;
        private int btWidth;
        private int btHeight;
        private string btText;
        private Icon btIcon;
        private OnClickListener onClickListener;

        public int BtX { get => btX; set => btX = value; }
        public int BtY { get => btY; set => btY = value; }
        public int BtWidth { get => btWidth; set => btWidth = value; }
        public int BtHeight { get => btHeight; set => btHeight = value; }
        public string BtText { get => btText; set => btText = value; }
        public Icon BtIcon { get => btIcon; set => btIcon = value; }

        public void setOnClickListener(OnClickListener listener)
        {
            this.onClickListener = listener;
        }
        public ButtonView(int btX, int btY, int btWidth, int btHeight, string btText,Icon btIcon)
        {
            this.btX = btX;
            this.btY = btY;
            this.btWidth = btWidth;
            this.btHeight = btHeight;
            this.btText = btText;
            this.btIcon = btIcon;
            this.Text = this.btText;
            this.SetBounds(btX, btY, btWidth, btHeight);
        }

        public ButtonView(int btX, int btY, int btWidth, int btHeight, string btText)
        {
            this.btX = btX;
            this.btY = btY;
            this.btWidth = btWidth;
            this.btHeight = btHeight;
            this.btText = btText;
            this.Text = this.btText;
            this.SetBounds(btX, btY, btWidth, btHeight);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.onClickListener.OnClick(this, e);
        }
    }
}
