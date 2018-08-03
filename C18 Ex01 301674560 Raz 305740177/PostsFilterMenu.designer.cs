using System;

namespace PostsFilter
{
    partial class PostsFilterMenu
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
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.showPostButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.Year2TextBox = new System.Windows.Forms.TextBox();
            this.submitDate = new System.Windows.Forms.Button();
            this.submitYear = new System.Windows.Forms.Button();
            this.mostPopPic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.popPic = new System.Windows.Forms.PictureBox();
            this.date = new System.Windows.Forms.CheckBox();
            this.withFriendsButton = new System.Windows.Forms.CheckBox();
            this.year = new System.Windows.Forms.CheckBox();
            this.onlyWithPictures = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popPic)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePic
            // 
            this.profilePic.Location = new System.Drawing.Point(151, 28);
            this.profilePic.Margin = new System.Windows.Forms.Padding(2);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(93, 88);
            this.profilePic.TabIndex = 0;
            this.profilePic.TabStop = false;
            // 
            // showPostButton
            // 
            this.showPostButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.showPostButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPostButton.ForeColor = System.Drawing.Color.DimGray;
            this.showPostButton.Location = new System.Drawing.Point(105, 143);
            this.showPostButton.Margin = new System.Windows.Forms.Padding(2);
            this.showPostButton.Name = "showPostButton";
            this.showPostButton.Size = new System.Drawing.Size(183, 29);
            this.showPostButton.TabIndex = 3;
            this.showPostButton.Text = "Show Posts";
            this.showPostButton.UseVisualStyleBackColor = false;
            this.showPostButton.Click += new System.EventHandler(this.onShowPosts_Clicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pick My Posts By:";
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(248, 203);
            this.dayTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(26, 20);
            this.dayTextBox.TabIndex = 11;
            this.dayTextBox.Visible = false;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(277, 202);
            this.monthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(27, 20);
            this.monthTextBox.TabIndex = 13;
            this.monthTextBox.Visible = false;
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.Location = new System.Drawing.Point(246, 191);
            this.dayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(19, 9);
            this.dayLabel.TabIndex = 14;
            this.dayLabel.Text = "Day";
            this.dayLabel.Visible = false;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(275, 190);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(26, 9);
            this.monthLabel.TabIndex = 15;
            this.monthLabel.Text = "Month";
            this.monthLabel.Visible = false;
            // 
            // Year2TextBox
            // 
            this.Year2TextBox.Location = new System.Drawing.Point(248, 240);
            this.Year2TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Year2TextBox.Name = "Year2TextBox";
            this.Year2TextBox.Size = new System.Drawing.Size(56, 20);
            this.Year2TextBox.TabIndex = 17;
            this.Year2TextBox.Visible = false;
            // 
            // submitDate
            // 
            this.submitDate.Location = new System.Drawing.Point(327, 201);
            this.submitDate.Margin = new System.Windows.Forms.Padding(2);
            this.submitDate.Name = "submitDate";
            this.submitDate.Size = new System.Drawing.Size(45, 18);
            this.submitDate.TabIndex = 18;
            this.submitDate.Text = "OK";
            this.submitDate.UseVisualStyleBackColor = true;
            this.submitDate.Visible = false;
            this.submitDate.Click += new System.EventHandler(this.submitDate_Click);
            // 
            // submitYear
            // 
            this.submitYear.Location = new System.Drawing.Point(327, 242);
            this.submitYear.Margin = new System.Windows.Forms.Padding(2);
            this.submitYear.Name = "submitYear";
            this.submitYear.Size = new System.Drawing.Size(45, 18);
            this.submitYear.TabIndex = 19;
            this.submitYear.Text = "OK";
            this.submitYear.UseVisualStyleBackColor = true;
            this.submitYear.Visible = false;
            this.submitYear.Click += new System.EventHandler(this.submitYear_Click);
            // 
            // mostPopPic
            // 
            this.mostPopPic.Enabled = false;
            this.mostPopPic.Location = new System.Drawing.Point(8, 331);
            this.mostPopPic.Margin = new System.Windows.Forms.Padding(2);
            this.mostPopPic.Name = "mostPopPic";
            this.mostPopPic.Size = new System.Drawing.Size(143, 23);
            this.mostPopPic.TabIndex = 20;
            this.mostPopPic.Text = "Most Popular Pic";
            this.mostPopPic.UseVisualStyleBackColor = true;
            this.mostPopPic.Click += new System.EventHandler(this.mostPopPic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 331);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "of:";
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.Location = new System.Drawing.Point(273, 331);
            this.usersListBox.Margin = new System.Windows.Forms.Padding(2);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(100, 30);
            this.usersListBox.TabIndex = 22;
            this.usersListBox.SelectedIndexChanged += new System.EventHandler(this.usersListBox_SelectedIndexChanged);
            // 
            // popPic
            // 
            this.popPic.Location = new System.Drawing.Point(8, 378);
            this.popPic.Margin = new System.Windows.Forms.Padding(2);
            this.popPic.Name = "popPic";
            this.popPic.Size = new System.Drawing.Size(364, 196);
            this.popPic.TabIndex = 23;
            this.popPic.TabStop = false;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(106, 204);
            this.date.Margin = new System.Windows.Forms.Padding(2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(49, 17);
            this.date.TabIndex = 24;
            this.date.Text = "Date";
            this.date.UseVisualStyleBackColor = true;
            this.date.CheckedChanged += new System.EventHandler(this.date_CheckedChanged);
            // 
            // withFriendsButton
            // 
            this.withFriendsButton.AutoSize = true;
            this.withFriendsButton.Location = new System.Drawing.Point(105, 224);
            this.withFriendsButton.Margin = new System.Windows.Forms.Padding(2);
            this.withFriendsButton.Name = "withFriendsButton";
            this.withFriendsButton.Size = new System.Drawing.Size(80, 17);
            this.withFriendsButton.TabIndex = 25;
            this.withFriendsButton.Text = "With Friend";
            this.withFriendsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.withFriendsButton.UseVisualStyleBackColor = true;
            this.withFriendsButton.CheckedChanged += new System.EventHandler(this.withFriendsButton_CheckedChanged);
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(105, 244);
            this.year.Margin = new System.Windows.Forms.Padding(2);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(48, 17);
            this.year.TabIndex = 26;
            this.year.Text = "Year";
            this.year.UseVisualStyleBackColor = true;
            this.year.CheckedChanged += new System.EventHandler(this.year_CheckedChanged);
            // 
            // onlyWithPictures
            // 
            this.onlyWithPictures.AutoSize = true;
            this.onlyWithPictures.Location = new System.Drawing.Point(105, 264);
            this.onlyWithPictures.Margin = new System.Windows.Forms.Padding(2);
            this.onlyWithPictures.Name = "onlyWithPictures";
            this.onlyWithPictures.Size = new System.Drawing.Size(113, 17);
            this.onlyWithPictures.TabIndex = 27;
            this.onlyWithPictures.Text = "Only With Pictures";
            this.onlyWithPictures.UseVisualStyleBackColor = true;
            this.onlyWithPictures.CheckedChanged += new System.EventHandler(this.onlyWithPictures_CheckedChanged);
            // 
            // PostsFilterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(414, 682);
            this.Controls.Add(this.onlyWithPictures);
            this.Controls.Add(this.year);
            this.Controls.Add(this.withFriendsButton);
            this.Controls.Add(this.date);
            this.Controls.Add(this.popPic);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mostPopPic);
            this.Controls.Add(this.submitYear);
            this.Controls.Add(this.submitDate);
            this.Controls.Add(this.Year2TextBox);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showPostButton);
            this.Controls.Add(this.profilePic);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PostsFilterMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter Posts";
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Button showPostButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.TextBox Year2TextBox;
        private System.Windows.Forms.Button submitDate;
        private System.Windows.Forms.Button submitYear;
        private System.Windows.Forms.Button mostPopPic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.PictureBox popPic;
        private System.Windows.Forms.CheckBox date;
        private System.Windows.Forms.CheckBox withFriendsButton;
        private System.Windows.Forms.CheckBox year;
        private System.Windows.Forms.CheckBox onlyWithPictures;
    }
}

