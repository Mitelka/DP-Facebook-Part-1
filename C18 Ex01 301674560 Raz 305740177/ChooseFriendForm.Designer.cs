namespace PostsFilter
{
    partial class ChooseFriendForm
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
            this.friendBox = new System.Windows.Forms.ListBox();
            this.chooseButton = new System.Windows.Forms.Button();
            this.friendSelected = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.friendSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // friendBox
            // 
            this.friendBox.FormattingEnabled = true;
            this.friendBox.ItemHeight = 20;
            this.friendBox.Location = new System.Drawing.Point(28, 12);
            this.friendBox.Name = "friendBox";
            this.friendBox.Size = new System.Drawing.Size(541, 324);
            this.friendBox.TabIndex = 0;
            this.friendBox.SelectedIndexChanged += new System.EventHandler(this.friendBox_SelectedIndexChanged);
            // 
            // chooseButton
            // 
            this.chooseButton.Enabled = false;
            this.chooseButton.Location = new System.Drawing.Point(86, 379);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(173, 35);
            this.chooseButton.TabIndex = 1;
            this.chooseButton.Text = "Choose";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // friendSelected
            // 
            this.friendSelected.Location = new System.Drawing.Point(363, 351);
            this.friendSelected.Name = "friendSelected";
            this.friendSelected.Size = new System.Drawing.Size(98, 87);
            this.friendSelected.TabIndex = 2;
            this.friendSelected.TabStop = false;
            // 
            // ChooseFriendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.friendSelected);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.friendBox);
            this.Name = "ChooseFriendForm";
            this.Text = "Choose Friends";
            ((System.ComponentModel.ISupportInitialize)(this.friendSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox friendBox;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.PictureBox friendSelected;
    }
}