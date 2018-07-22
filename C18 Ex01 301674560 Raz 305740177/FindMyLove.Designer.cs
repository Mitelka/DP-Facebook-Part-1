namespace C18_Ex01_301674560_Raz_305740177
{
    public partial class FindMyLove
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
            this.iWannaMeetLabel = new System.Windows.Forms.Label();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.ageRangeLabel = new System.Windows.Forms.Label();
            this.fromTrack = new System.Windows.Forms.TrackBar();
            this.ToTrackBar = new System.Windows.Forms.TrackBar();
            this.maxAgeLabel = new System.Windows.Forms.Label();
            this.minAgeLabe = new System.Windows.Forms.Label();
            this.fromRangeChosen = new System.Windows.Forms.Label();
            this.maxRangeChosen = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePic
            // 
            this.profilePic.Location = new System.Drawing.Point(346, 33);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(201, 205);
            this.profilePic.TabIndex = 0;
            this.profilePic.TabStop = false;
            // 
            // iWannaMeetLabel
            // 
            this.iWannaMeetLabel.AutoSize = true;
            this.iWannaMeetLabel.Location = new System.Drawing.Point(12, 33);
            this.iWannaMeetLabel.Name = "iWannaMeetLabel";
            this.iWannaMeetLabel.Size = new System.Drawing.Size(77, 13);
            this.iWannaMeetLabel.TabIndex = 1;
            this.iWannaMeetLabel.Text = "I Wanna meet:";
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FemaleRadioButton.Location = new System.Drawing.Point(40, 68);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleRadioButton.TabIndex = 2;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            this.FemaleRadioButton.CheckedChanged += new System.EventHandler(this.FemaleRadioButton_CheckedChanged);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.ForeColor = System.Drawing.Color.Blue;
            this.maleRadioButton.Location = new System.Drawing.Point(40, 109);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 3;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.CheckedChanged += new System.EventHandler(this.maleRadioButton_CheckedChanged);
            // 
            // ageRangeLabel
            // 
            this.ageRangeLabel.AutoSize = true;
            this.ageRangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ageRangeLabel.Location = new System.Drawing.Point(134, 142);
            this.ageRangeLabel.Name = "ageRangeLabel";
            this.ageRangeLabel.Size = new System.Drawing.Size(78, 17);
            this.ageRangeLabel.TabIndex = 4;
            this.ageRangeLabel.Text = "Age range:";
            // 
            // fromTrack
            // 
            this.fromTrack.Location = new System.Drawing.Point(12, 193);
            this.fromTrack.Name = "fromTrack";
            this.fromTrack.Size = new System.Drawing.Size(142, 45);
            this.fromTrack.TabIndex = 5;
            this.fromTrack.Scroll += new System.EventHandler(this.fromTrack_Scroll);
            // 
            // ToTrackBar
            // 
            this.ToTrackBar.Location = new System.Drawing.Point(195, 193);
            this.ToTrackBar.Name = "ToTrackBar";
            this.ToTrackBar.Size = new System.Drawing.Size(120, 45);
            this.ToTrackBar.TabIndex = 6;
            this.ToTrackBar.Scroll += new System.EventHandler(this.ToTrackBar_Scroll);
            // 
            // maxAgeLabel
            // 
            this.maxAgeLabel.AutoSize = true;
            this.maxAgeLabel.Location = new System.Drawing.Point(238, 177);
            this.maxAgeLabel.Name = "maxAgeLabel";
            this.maxAgeLabel.Size = new System.Drawing.Size(49, 13);
            this.maxAgeLabel.TabIndex = 7;
            this.maxAgeLabel.Text = "Max Age";
            // 
            // minAgeLabe
            // 
            this.minAgeLabe.AutoSize = true;
            this.minAgeLabe.Location = new System.Drawing.Point(67, 177);
            this.minAgeLabe.Name = "minAgeLabe";
            this.minAgeLabe.Size = new System.Drawing.Size(46, 13);
            this.minAgeLabe.TabIndex = 8;
            this.minAgeLabe.Text = "Min Age";
            // 
            // fromRangeChosen
            // 
            this.fromRangeChosen.AutoSize = true;
            this.fromRangeChosen.Location = new System.Drawing.Point(64, 241);
            this.fromRangeChosen.Name = "fromRangeChosen";
            this.fromRangeChosen.Size = new System.Drawing.Size(19, 13);
            this.fromRangeChosen.TabIndex = 9;
            this.fromRangeChosen.Text = "18";
            // 
            // maxRangeChosen
            // 
            this.maxRangeChosen.AutoSize = true;
            this.maxRangeChosen.Location = new System.Drawing.Point(238, 241);
            this.maxRangeChosen.Name = "maxRangeChosen";
            this.maxRangeChosen.Size = new System.Drawing.Size(19, 13);
            this.maxRangeChosen.TabIndex = 10;
            this.maxRangeChosen.Text = "18";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(241, 33);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(99, 23);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search!";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // FindMyLove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 268);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.maxRangeChosen);
            this.Controls.Add(this.fromRangeChosen);
            this.Controls.Add(this.minAgeLabe);
            this.Controls.Add(this.maxAgeLabel);
            this.Controls.Add(this.ToTrackBar);
            this.Controls.Add(this.fromTrack);
            this.Controls.Add(this.ageRangeLabel);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.FemaleRadioButton);
            this.Controls.Add(this.iWannaMeetLabel);
            this.Controls.Add(this.profilePic);
            this.Name = "FindMyLove";
            this.Text = "FindMyLove";
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Label iWannaMeetLabel;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Label ageRangeLabel;
        private System.Windows.Forms.TrackBar fromTrack;
        private System.Windows.Forms.TrackBar ToTrackBar;
        private System.Windows.Forms.Label maxAgeLabel;
        private System.Windows.Forms.Label minAgeLabe;
        private System.Windows.Forms.Label fromRangeChosen;
        private System.Windows.Forms.Label maxRangeChosen;
        private System.Windows.Forms.Button searchButton;
    }
}