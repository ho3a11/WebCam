namespace WebCam
{
    partial class frmCamera
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
            this.picFrame = new System.Windows.Forms.PictureBox();
            this.btnSnapshot = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picFrame
            // 
            this.picFrame.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picFrame.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.picFrame.Location = new System.Drawing.Point(6, 19);
            this.picFrame.Name = "picFrame";
            this.picFrame.Size = new System.Drawing.Size(516, 394);
            this.picFrame.TabIndex = 1;
            this.picFrame.TabStop = false;
            this.picFrame.Click += new System.EventHandler(this.picFrame_Click);
            // 
            // btnSnapshot
            // 
            this.btnSnapshot.BackColor = System.Drawing.Color.Cyan;
            this.btnSnapshot.Location = new System.Drawing.Point(199, 443);
            this.btnSnapshot.Name = "btnSnapshot";
            this.btnSnapshot.Size = new System.Drawing.Size(121, 42);
            this.btnSnapshot.TabIndex = 4;
            this.btnSnapshot.Text = "Snapshot";
            this.btnSnapshot.UseVisualStyleBackColor = false;
            this.btnSnapshot.Click += new System.EventHandler(this.btnSnapshot_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picFrame);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 423);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera Show";
            // 
            // frmCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(546, 495);
            this.Controls.Add(this.btnSnapshot);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MY Snapshot";
            this.Load += new System.EventHandler(this.frmCamera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picFrame;
        private System.Windows.Forms.Button btnSnapshot;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

