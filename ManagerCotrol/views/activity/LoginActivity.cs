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
    internal class LoginActivity : PanelView
    {
        List<string> listLabelText = new List<string>();
        private Label labelInfoFail;
        private Button buttonSignup;
        private Button buttonViewLogin;
        private OnClickListener clickListener;
        private TextBox textBoxUser, textBoxPass;

        public LoginActivity(DockStyle dockStyle, int x, int y, int width, int height) : base(dockStyle, x, y, width, height)
        {
            
        }

        public void setClickListener(OnClickListener clickListener)
        {
            this.clickListener = clickListener;
        }

        public TextBox getUser()
        {
            return textBoxUser;
        }
        public TextBox getPass()
        {
            return textBoxPass;
        }
        public Label getLabelFailed()
        {
            return labelInfoFail;
        }
        protected override void addEvent()
        {
            buttonViewLogin.Click += new System.EventHandler(onClick);
            buttonSignup.Click += new System.EventHandler(onClick);

        }

        private void onClick(object sender, EventArgs e)
        {
            this.clickListener.OnClick(sender, e);
        }

        protected override void initView()
        {
            listLabelText.Add("Username");
            listLabelText.Add("Password");
            this.BackColor = Color.Transparent;
            this.setView(this, this.Width / 2 - 400, this.Height / 2 - 200, 800, 400);
            this.textBoxUser = new TextBox();
            this.textBoxPass = new TextBox();
        }
        private void setView(Panel panel, int x, int y, int width, int height)
        {
            Panel panelView = new Panel();
            panelView.SetBounds(x, y, width, height);
            panelView.BackColor = Color.Transparent;
            panelView.Name = Form1Helpers.VIEW_LOGIN;
            Image img = Properties.Resources.bg_login_1;
            
            panelView.BackgroundImage = img;
            panelView.BackgroundImageLayout = ImageLayout.Zoom;

            Label labelView = new Label();
            labelView.SetBounds(panelView.Width / 2 - 100, 20, 200, 100);
            labelView.Text = "Login";
            labelView.TextAlign = ContentAlignment.MiddleCenter;
            labelView.Name = Form1Helpers.SIGN_IN;
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



            buttonViewLogin = new Button();
            buttonViewLogin.Name = Form1Helpers.SIGN_IN_ACC;
            buttonViewLogin.SetBounds(width / 2 - 50, height - 150, 100, 40);
            buttonViewLogin.Text = "Login";
            buttonViewLogin.BackColor = Color.Transparent;
            buttonViewLogin.Font = new Font(Form1Helpers.FONT_FAMILY, 10, FontStyle.Regular);
            buttonViewLogin.ForeColor = Color.Black;
            buttonViewLogin.BackgroundImage = Properties.Resources.bg_btn_login;
            buttonViewLogin.FlatStyle = FlatStyle.Flat;
            buttonViewLogin.FlatAppearance.BorderSize = 0;
            buttonViewLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonViewLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;

            buttonSignup = new Button();
            buttonSignup.Name = Form1Helpers.SIGN_UP_ACC;
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
            labelInfoFail.SetBounds(width / 2 - 100, height - 200, 200, 40);
            labelInfoFail.Name = Form1Helpers.NOTIFY_TEXT;
            labelInfoFail.Font = new Font(Form1Helpers.FONT_FAMILY, 10, FontStyle.Regular);
            labelInfoFail.TextAlign = ContentAlignment.MiddleCenter;
            labelInfoFail.BackColor = Color.Transparent;
            

            panelView.Controls.Add(buttonViewLogin);
            panelView.Controls.Add(buttonSignup);
            panelView.Controls.Add(labelInfoFail);

            panel.Controls.Add(panelView);

        }

        private void bg_button_change(object sender, EventArgs e)
        {
            
        }

        private void onTextChange(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (textBox.Name == listLabelText[0])
                {
                    textBoxUser = textBox;
                }
                if (textBox.Name == listLabelText[1])
                {
                    textBoxPass = textBox;
                    textBoxPass.PasswordChar = '*';
                }

            }
        }
    }
}
