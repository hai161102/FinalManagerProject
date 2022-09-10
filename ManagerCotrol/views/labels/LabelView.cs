using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCotrol.views.labels
{
    internal class LabelView : Label
    {
        int labelX;
        int labelY;
        int labelWidth;
        int labelHeight;
        string labelText;

        public int LabelX { get => labelX; set => labelX = value; }
        public int LabelY { get => labelY; set => labelY = value; }
        public int LabelWidth { get => labelWidth; set => labelWidth = value; }
        public int LabelHeight { get => labelHeight; set => labelHeight = value; }
        public string LabelText { get => labelText; set => labelText = value; }

        public LabelView(int labelX, int labelY, int labelWidth, int labelHeight, string labelText)
        {
            this.labelX = labelX;
            this.labelY = labelY;
            this.labelWidth = labelWidth;
            this.labelHeight = labelHeight;
            this.labelText = labelText;
            this.SetBounds(labelX, labelY, labelWidth, labelHeight);
            this.Text = labelText;
        }

        public void setText(string text)
        {
            this.labelText = text;
            this.Text = labelText;
        }
        public void updateText(string text)
        {
            this.labelText = text;
            this.Text = this.labelText;
        }
    }
}
