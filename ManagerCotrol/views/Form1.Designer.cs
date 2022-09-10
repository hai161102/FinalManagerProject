using ManagerCotrol.presenter;
using ManagerCotrol.views.activity;
using ManagerCotrol.views.buttons;
using ManagerCotrol.views.labels;
using ManagerCotrol.views.panels;
using ManagerCotrol.views.textbox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ManagerCotrol
{
    partial class Form1 : OnClickListener, LoginView
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
        private SignUpActivity signUpActivity;
        private int windowWidth, windowHeight;
        private LoginPresenter loginPresenter;
        
        private Stack<Panel> stackPanel = new Stack<Panel>();
        

        private void InitializeComponent()
        {


            this.loginPresenter = new LoginPresenter(this);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.Name = "Manager";
            this.Text = "Manager";
            this.WindowState = FormWindowState.Maximized;
            this.ResumeLayout(false);

            this.windowWidth = this.Width;
            this.windowHeight = this.Height;

            this.loginActivity = new LoginActivity(System.Windows.Forms.DockStyle.Fill, 0, 0, windowWidth, windowHeight);
            this.loginActivity.Name = Form1Helpers.SIGN_IN;
            this.loginActivity.setClickListener(this);

            this.signUpActivity = new SignUpActivity(System.Windows.Forms.DockStyle.Fill, 0, 0, windowWidth, windowHeight);
            this.signUpActivity.Name = Form1Helpers.SIGN_UP_NEW_ACC;
            this.signUpActivity.setOnClickListener(this);

            this.SuspendLayout();
            this.ResizeRedraw = false;
            this.Controls.Add(this.loginActivity);

        }

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
                    loginActivity.Hide();
                    this.Controls.Add(this.signUpActivity);
                    Thread.Sleep(100);
                    signUpActivity.Show();
                }
                if (button.Name == Form1Helpers.EXIT_SIGNUP)
                {
                    signUpActivity.Hide();
                    this.Controls.Remove(signUpActivity);
                    Thread.Sleep(100);
                    loginActivity.Show();
                }
            }
            
        }

        public void onLoginSuccess()
        {
            
        }

        public void onLoginFailure(string mess)
        {
            loginActivity.getLabelFailed().Text = mess;
            loginActivity.getLabelFailed().ForeColor = Color.Red;
        }





        #endregion
    }
}

