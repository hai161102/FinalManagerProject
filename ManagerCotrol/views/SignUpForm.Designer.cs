using ManagerCotrol.presenter;
using ManagerCotrol.utils;
using ManagerCotrol.views.activity;
using ManagerCotrol.views.panels;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ManagerCotrol.views
{
    partial class SignUpForm : SignUpView, OnClickListener
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

        public static int windowWidth = Screen.PrimaryScreen.Bounds.Width;
        public static int windowHeight = Screen.PrimaryScreen.Bounds.Height;
        private SignUpActivity signUpActivity;
        private SignUpPresenter signUpPresenter;
        private void InitializeComponent()
        {
            signUpPresenter = new SignUpPresenter(this);
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Location = new System.Drawing.Point(windowWidth / 2 - 400, windowHeight / 2 - 200);
            this.Text = "SignUpForm";

            this.signUpActivity = new SignUpActivity(System.Windows.Forms.DockStyle.Fill, 0, 0, windowWidth, windowHeight);
            this.signUpActivity.Name = Form1Helpers.SIGN_UP_NEW_ACC;
            this.signUpActivity.setOnClickListener(this);

            this.Controls.Add(signUpActivity);
            this.SuspendLayout();
            this.ResizeRedraw = false;

        }

        public void onSucces(AccountLogin account)
        {
            this.signUpActivity.getFailLabel().ForeColor = Color.Green;
            this.signUpActivity.getFailLabel().Text = "Please waits, this action can take a while";
            this.startLogin();
        }

        public void onFailed(string mes)
        {
            throw new System.NotImplementedException();
        }

        [Obsolete]
        public void OnClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                
                if (button.Name == Form1Helpers.EXIT_SIGNUP)
                {
                    startLogin();
                    Thread.Sleep(100);
                }
                if (button.Name == Form1Helpers.SIGN_UP_NEW_ACC)
                {
                    signUpPresenter.signUp(signUpActivity.getUser().Text, signUpActivity.getPass().Text, signUpActivity.getPermission().Text);
                }

            }
        }

        private void startLogin()
        {
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            this.Close();
        }

        #endregion
    }
}