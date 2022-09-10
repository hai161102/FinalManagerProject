using ManagerCotrol.presenter;
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
    internal class SignUpActivity : PanelView
    {
        List<string> listLabelText = new List<string>();
        private Label labelInfoFail;
        private Button buttonSignup;
        private Button buttonCancel;
        private OnClickListener onClickListener;

        public SignUpActivity(DockStyle dockStyle, int x, int y, int width, int height) : base(dockStyle, x, y, width, height)
        {
        }
        public void setOnClickListener(OnClickListener listener)
        {
            this.onClickListener = listener;
        }
        protected override void addEvent()
        {
            buttonCancel.Click += new System.EventHandler(onClick);
        }

        private void onClick(object sender, EventArgs e)
        {
            this.onClickListener.OnClick(sender, e);
        }

        protected override void initView()
        {
            listLabelText.Add("Username");
            listLabelText.Add("Password");
            listLabelText.Add("Permission");
            this.BackColor = Color.Transparent;
            this.setView(this, this.Width / 2 - 400, this.Height / 2 - 200, 800, 400);
        }
        private void setView(Panel panel, int x, int y, int width, int height)
        {
            Panel panelView = new Panel();
            panelView.SetBounds(x, y, width, height);
            panelView.BackColor = Color.Transparent;
            panelView.Name = Form1Helpers.VIEW_SIGNUP;
            Image img = Properties.Resources.bg_login_1;

            panelView.BackgroundImage = img;
            panelView.BackgroundImageLayout = ImageLayout.Zoom;

            Label labelView = new Label();
            labelView.SetBounds(panelView.Width / 2 - 100, 20, 200, 100);
            labelView.Text = "Sign Up";
            labelView.TextAlign = ContentAlignment.MiddleCenter;
            labelView.Name = Form1Helpers.SIGN_UP_ACC;
            labelView.BackColor = Color.Transparent;
            labelView.Font = new Font(Form1Helpers.FONT_FAMILY, 24, FontStyle.Bold);
            labelView.ForeColor = Color.White;
            panelView.Controls.Add(labelView);

            for (int i = 0; i < listLabelText.Count; i++)
            {
                Label viewInfo = new Label();
                viewInfo.SetBounds(50, labelView.Location.Y + i * 50 + labelView.Height, 150, 50);
                viewInfo.Text = listLabelText[i];
                viewInfo.Name = listLabelText[i];
                viewInfo.BackColor = Color.Transparent;
                viewInfo.Font = new Font(Form1Helpers.FONT_FAMILY, 10, FontStyle.Regular);
                viewInfo.ForeColor = Color.White;
                panelView.Controls.Add(viewInfo);

                TextBox textBoxInfo = new TextBox();
                textBoxInfo.SetBounds(50 + viewInfo.Width, labelView.Location.Y + labelView.Height + i * 50, panelView.Width - 50 - (50 + viewInfo.Width), viewInfo.Height);
                textBoxInfo.Name = listLabelText[i];
                textBoxInfo.TextChanged += onTextChange;
                //textBoxInfo.BorderStyle = BorderStyle.Fixed3D;
                textBoxInfo.Font = new Font(Form1Helpers.FONT_FAMILY, 10, FontStyle.Regular);
                textBoxInfo.ForeColor = Color.Black;
                textBoxInfo.BorderStyle = BorderStyle.Fixed3D;
                panelView.Controls.Add(textBoxInfo);

            }

            //Button buttonView = new Button();
            //buttonView.Name = Form1Helpers.SIGN_IN_ACC;
            //buttonView.SetBounds(width / 2 - 50, height - 100, 100, 40);
            //buttonView.Text = "Sign In";
            buttonSignup = new Button();
            buttonSignup.Name = Form1Helpers.SIGN_UP_NEW_ACC;
            buttonSignup.SetBounds(width / 2 - 50, height - 100, 100, 40);
            buttonSignup.Text = "Sign Up";
            buttonSignup.BackColor = Color.Transparent;
            buttonSignup.Font = new Font(Form1Helpers.FONT_FAMILY, 10, FontStyle.Regular);
            buttonSignup.ForeColor = Color.White;
            buttonSignup.FlatStyle = FlatStyle.Flat;
            buttonSignup.FlatAppearance.BorderSize = 0;
            buttonSignup.BackgroundImage = Properties.Resources.bg_btn_signup;
            buttonSignup.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSignup.FlatAppearance.MouseDownBackColor = Color.Transparent;

            labelInfoFail = new Label();
            labelInfoFail.SetBounds(width / 2 - 100, height - 150, 200, 40);
            labelInfoFail.Name = Form1Helpers.NOTIFY_TEXT;
            labelInfoFail.Font = new Font(Form1Helpers.FONT_FAMILY, 10, FontStyle.Regular);
            labelInfoFail.TextAlign = ContentAlignment.MiddleCenter;

            buttonCancel = new Button();
            buttonCancel.SetBounds(panelView.Width - 90, 10, 80, 40);
            buttonCancel.Text = "Cancel";
            buttonCancel.Name = Form1Helpers.EXIT_SIGNUP;
            buttonCancel.Font = new Font(Form1Helpers.FONT_FAMILY, 10, FontStyle.Regular);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonCancel.FlatAppearance.MouseDownBackColor = Color.Transparent;

            



            panelView.Controls.Add(buttonSignup);
            //panelView.Controls.Add(buttonView1);
            panelView.Controls.Add(labelInfoFail);
            panelView.Controls.Add(buttonCancel);
            panel.Controls.Add(panelView);

        }

        private void onTextChange(object sender, EventArgs e)
        {

        }
    }
}
