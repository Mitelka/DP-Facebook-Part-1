namespace C18_Ex01_301674560_Raz_305740177
{
    partial class FackebookApp
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
            this.Buttonlogin = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.Buttonpost = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.linkFriends = new System.Windows.Forms.LinkLabel();
            this.linkPosts = new System.Windows.Forms.LinkLabel();
            this.labelEvents = new System.Windows.Forms.LinkLabel();
            this.linkPages = new System.Windows.Forms.LinkLabel();
            this.linkCheckins = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Buttonlogin
            // 
            this.Buttonlogin.Location = new System.Drawing.Point(25, 22);
            this.Buttonlogin.Name = "Buttonlogin";
            this.Buttonlogin.Size = new System.Drawing.Size(109, 20);
            this.Buttonlogin.TabIndex = 0;
            this.Buttonlogin.Text = "Login";
            this.Buttonlogin.UseVisualStyleBackColor = true;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(446, 59);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(352, 82);
            this.listBoxPosts.TabIndex = 1;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Buttonpost
            // 
            this.Buttonpost.AutoSize = true;
            this.Buttonpost.Location = new System.Drawing.Point(348, 22);
            this.Buttonpost.Name = "Buttonpost";
            this.Buttonpost.Size = new System.Drawing.Size(28, 13);
            this.Buttonpost.TabIndex = 2;
            this.Buttonpost.Text = "Post";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(162, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 30);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Location = new System.Drawing.Point(632, 18);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(98, 24);
            this.buttonSetStatus.TabIndex = 4;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(388, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 5;
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.Location = new System.Drawing.Point(446, 228);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(188, 82);
            this.listBoxPages.TabIndex = 6;
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.Location = new System.Drawing.Point(25, 180);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(170, 82);
            this.listBoxCheckins.TabIndex = 7;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(25, 72);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(139, 69);
            this.listBoxFriends.TabIndex = 8;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(446, 154);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(246, 56);
            this.listBoxEvents.TabIndex = 9;
            // 
            // linkFriends
            // 
            this.linkFriends.AutoSize = true;
            this.linkFriends.Location = new System.Drawing.Point(170, 72);
            this.linkFriends.Name = "linkFriends";
            this.linkFriends.Size = new System.Drawing.Size(246, 13);
            this.linkFriends.TabIndex = 10;
            this.linkFriends.TabStop = true;
            this.linkFriends.Text = "Fetch Friends (Only friends who also use this app..)";
            // 
            // linkPosts
            // 
            this.linkPosts.AutoSize = true;
            this.linkPosts.Location = new System.Drawing.Point(805, 59);
            this.linkPosts.Name = "linkPosts";
            this.linkPosts.Size = new System.Drawing.Size(63, 13);
            this.linkPosts.TabIndex = 11;
            this.linkPosts.TabStop = true;
            this.linkPosts.Text = "Fetch Posts";
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Location = new System.Drawing.Point(699, 154);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(73, 13);
            this.labelEvents.TabIndex = 12;
            this.labelEvents.TabStop = true;
            this.labelEvents.Text = "Fetch Events ";
            // 
            // linkPages
            // 
            this.linkPages.AutoSize = true;
            this.linkPages.Location = new System.Drawing.Point(632, 228);
            this.linkPages.Name = "linkPages";
            this.linkPages.Size = new System.Drawing.Size(99, 13);
            this.linkPages.TabIndex = 13;
            this.linkPages.TabStop = true;
            this.linkPages.Text = "Fetch Liked Pages ";
            // 
            // linkCheckins
            // 
            this.linkCheckins.AutoSize = true;
            this.linkCheckins.Location = new System.Drawing.Point(202, 180);
            this.linkCheckins.Name = "linkCheckins";
            this.linkCheckins.Size = new System.Drawing.Size(84, 13);
            this.linkCheckins.TabIndex = 14;
            this.linkCheckins.TabStop = true;
            this.linkCheckins.Text = "Fetch Checkins ";
            // 
            // FackebookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 450);
            this.Controls.Add(this.linkCheckins);
            this.Controls.Add(this.linkPages);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.linkPosts);
            this.Controls.Add(this.linkFriends);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.listBoxCheckins);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Buttonpost);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.Buttonlogin);
            this.Name = "FackebookApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FackebookApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buttonlogin;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label Buttonpost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.ListBox listBoxCheckins;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.LinkLabel linkFriends;
        private System.Windows.Forms.LinkLabel linkPosts;
        private System.Windows.Forms.LinkLabel labelEvents;
        private System.Windows.Forms.LinkLabel linkPages;
        private System.Windows.Forms.LinkLabel linkCheckins;
    }
}

