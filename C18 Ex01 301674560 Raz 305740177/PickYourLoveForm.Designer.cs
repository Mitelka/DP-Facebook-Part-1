namespace C18_Ex01_301674560_Raz_305740177
{
    public partial class PickYourLoveForm
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
            this.matchesLabel = new System.Windows.Forms.Label();
            this.matchesListbox = new System.Windows.Forms.ListBox();
            this.profilePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // matchesLabel
            // 
            this.matchesLabel.AutoSize = true;
            this.matchesLabel.Location = new System.Drawing.Point(47, 36);
            this.matchesLabel.Name = "matchesLabel";
            this.matchesLabel.Size = new System.Drawing.Size(75, 13);
            this.matchesLabel.TabIndex = 1;
            this.matchesLabel.Text = "Your matches:";
            // 
            // matchesListbox
            // 
            this.matchesListbox.FormattingEnabled = true;
            this.matchesListbox.Location = new System.Drawing.Point(128, 36);
            this.matchesListbox.Name = "matchesListbox";
            this.matchesListbox.Size = new System.Drawing.Size(126, 199);
            this.matchesListbox.TabIndex = 2;
            // 
            // profilePic
            // 
            this.profilePic.Location = new System.Drawing.Point(260, 36);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(89, 84);
            this.profilePic.TabIndex = 3;
            this.profilePic.TabStop = false;
            // 
            // PickYourLoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 269);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.matchesListbox);
            this.Controls.Add(this.matchesLabel);
            this.Name = "PickYourLoveForm";
            this.Text = "PickYourLoveForm";
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label matchesLabel;
        private System.Windows.Forms.ListBox matchesListbox;
        private System.Windows.Forms.PictureBox profilePic;
    }
}