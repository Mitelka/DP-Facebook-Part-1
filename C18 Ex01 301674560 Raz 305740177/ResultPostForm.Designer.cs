namespace PostsFilter
{
    partial class ResultPostForm
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
            this.postPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.postListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.postPic)).BeginInit();
            this.SuspendLayout();
            // 
            // postPic
            // 
            this.postPic.Location = new System.Drawing.Point(525, 37);
            this.postPic.Name = "postPic";
            this.postPic.Size = new System.Drawing.Size(146, 130);
            this.postPic.TabIndex = 2;
            this.postPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "click on post to see its image (if it has one)";

            // 
            // postListBox
            // 
            this.postListBox.FormattingEnabled = true;
            this.postListBox.ItemHeight = 20;
            this.postListBox.Location = new System.Drawing.Point(63, 34);
            this.postListBox.Name = "postListBox";
            this.postListBox.Size = new System.Drawing.Size(448, 384);
            this.postListBox.TabIndex = 4;
            this.postListBox.SelectedIndexChanged += new System.EventHandler(this.postListBox_SelectedIndexChanged);
            // 
            // ResaultPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.postListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.postPic);
            this.Name = "ResaultPostForm";
            this.Text = "My Selected Posts";
            ((System.ComponentModel.ISupportInitialize)(this.postPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox postPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox postListBox;
    }
}