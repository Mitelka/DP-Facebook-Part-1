using System;

namespace C18_Ex01_301674560_Raz_305740177
{
    public partial class MainMenu
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
        private void InitializeComponent()
        {
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttonFindMyLove = new System.Windows.Forms.Button();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.postsFilterbtn = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(70, 31);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(109, 26);
            this.buttonlogin.TabIndex = 0;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click_1);
            // 
            // buttonFindMyLove
            // 
            this.buttonFindMyLove.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonFindMyLove.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindMyLove.ForeColor = System.Drawing.Color.Red;
            this.buttonFindMyLove.Location = new System.Drawing.Point(33, 215);
            this.buttonFindMyLove.Name = "buttonFindMyLove";
            this.buttonFindMyLove.Size = new System.Drawing.Size(207, 47);
            this.buttonFindMyLove.TabIndex = 14;
            this.buttonFindMyLove.Text = "FindMyLove!";
            this.buttonFindMyLove.UseVisualStyleBackColor = false;
            this.buttonFindMyLove.Click += new System.EventHandler(this.buttonFindMyLove_Click);
            // 
            // userPictureBox
            // 
            this.userPictureBox.Location = new System.Drawing.Point(70, 85);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(124, 94);
            this.userPictureBox.TabIndex = 3;
            this.userPictureBox.TabStop = false;
            // 
            // postsFilterbtn
            // 
            this.postsFilterbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.postsFilterbtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postsFilterbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.postsFilterbtn.Location = new System.Drawing.Point(33, 294);
            this.postsFilterbtn.Name = "postsFilterbtn";
            this.postsFilterbtn.Size = new System.Drawing.Size(207, 47);
            this.postsFilterbtn.TabIndex = 15;
            this.postsFilterbtn.Text = "Posts Filter";
            this.postsFilterbtn.UseVisualStyleBackColor = false;
            this.postsFilterbtn.Click += new System.EventHandler(this.postsFilterbtn_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.SystemColors.Control;
            this.userName.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.Maroon;
            this.userName.Location = new System.Drawing.Point(66, 9);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(54, 19);
            this.userName.TabIndex = 16;
            this.userName.Text = "label1";
            this.userName.Visible = false;
            this.userName.Click += new System.EventHandler(this.userName_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 427);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.postsFilterbtn);
            this.Controls.Add(this.buttonFindMyLove);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.buttonlogin);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.FackebookApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttonFindMyLove;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Button postsFilterbtn;
        private System.Windows.Forms.Label userName;
    }
}
