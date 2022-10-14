using ManagerCotrol.presenter;
using ManagerCotrol.utils;
using ManagerCotrol.views;
using ManagerCotrol.views.activity;
using ManagerCotrol.views.activity.SignUp;
using ManagerCotrol.views.buttons;
using ManagerCotrol.views.labels;
using ManagerCotrol.views.panels;
using ManagerCotrol.views.textbox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ManagerCotrol
{
    partial class SignInForm : OnClickListener, LoginView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private LoginActivity loginActivity;
        private int windowWidth, windowHeight;
        private LoginPresenter loginPresenter;
        private MainActivity mainActivity;
        
        private Stack<Panel> stackPanel = new Stack<Panel>();
        private Thread thread;
        private bool isStartSignUp = false;

        private void InitializeComponent()
        {


            this.loginPresenter = new LoginPresenter(this);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Location = new System.Drawing.Point(SignUpForm.windowWidth / 2 - 400, windowHeight / 2 - 200);
            this.Name = "Manager";
            this.Text = "Manager";
            this.WindowState = FormWindowState.Normal;
            this.ResumeLayout(false);

            this.windowWidth = this.Width;
            this.windowHeight = this.Height;

            this.loginActivity = new LoginActivity(System.Windows.Forms.DockStyle.Fill, 0, 0, windowWidth, windowHeight);
            this.loginActivity.Name = Form1Helpers.SIGN_IN;
            this.loginActivity.setClickListener(this);

            this.mainActivity = new MainActivity(System.Windows.Forms.DockStyle.Fill, 0, 0, windowWidth, windowHeight);
            mainActivity.Name = Form1Helpers.MAIN_ACTIVITY;

            this.SuspendLayout();
            this.ResizeRedraw = false;
            this.Controls.Add(this.loginActivity);

        }

        [Obsolete]
        public void OnClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (button.Name == Form1Helpers.SIGN_IN_ACC)
                {

                    loginPresenter.login(loginActivity.getUser().Text, loginActivity.getPass().Text);
                }

                if (button.Name == Form1Helpers.SIGN_UP_ACC)
                {
                    isStartSignUp = true;
                    Close();
                }

            }
            
        }

        public void onLoginSuccess(AccountLogin account)
        {
            
            this.Controls.Clear();
            this.Controls.Add(mainActivity);
            this.mainActivity.Show();
            
        }
        private void startSignUp()
        {
            Program.startSignUp();
        }

        public void onLoginFailure(string mess)
        {
            loginActivity.getLabelFailed().Text = mess;
            loginActivity.getLabelFailed().ForeColor = Color.Red;
        }

        private void startToMain(AccountLogin account)
        {
            Thread.Sleep(2000);
            loginPresenter.login(account.getUserName(), account.getPassword());

        }

        protected override void OnClosed(EventArgs e)
        {
            if (isStartSignUp)
            {
                //startSignUp();
                SignUpForm signUpForm = new SignUpForm();
                signUpForm.Show();
            }
            base.OnClosed(e);
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (isStartSignUp)
            {
                //startSignUp();
                SignUpForm signUpForm = new SignUpForm();
                signUpForm.Show();
            }
            base.OnClosing(e);
        }


        #endregion
    }
}

