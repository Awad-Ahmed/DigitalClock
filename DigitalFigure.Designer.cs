namespace Digital_Clock
{
    partial class DigitalFigure
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopA = new System.Windows.Forms.Panel();
            this.TOPLEFT = new System.Windows.Forms.Panel();
            this.TOPRIGHT = new System.Windows.Forms.Panel();
            this.BOTTOMRIGHT = new System.Windows.Forms.Panel();
            this.BOTTOMLEFT = new System.Windows.Forms.Panel();
            this.BOTTOM = new System.Windows.Forms.Panel();
            this.MID = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TopA
            // 
            this.TopA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TopA.Location = new System.Drawing.Point(23, 3);
            this.TopA.Name = "TopA";
            this.TopA.Size = new System.Drawing.Size(50, 10);
            this.TopA.TabIndex = 0;
            // 
            // TOPLEFT
            // 
            this.TOPLEFT.Location = new System.Drawing.Point(8, 19);
            this.TOPLEFT.Name = "TOPLEFT";
            this.TOPLEFT.Size = new System.Drawing.Size(10, 48);
            this.TOPLEFT.TabIndex = 1;
            // 
            // TOPRIGHT
            // 
            this.TOPRIGHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TOPRIGHT.Location = new System.Drawing.Point(82, 19);
            this.TOPRIGHT.Name = "TOPRIGHT";
            this.TOPRIGHT.Size = new System.Drawing.Size(10, 48);
            this.TOPRIGHT.TabIndex = 2;
            // 
            // BOTTOMRIGHT
            // 
            this.BOTTOMRIGHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BOTTOMRIGHT.Location = new System.Drawing.Point(82, 88);
            this.BOTTOMRIGHT.Name = "BOTTOMRIGHT";
            this.BOTTOMRIGHT.Size = new System.Drawing.Size(10, 48);
            this.BOTTOMRIGHT.TabIndex = 3;
            // 
            // BOTTOMLEFT
            // 
            this.BOTTOMLEFT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BOTTOMLEFT.Location = new System.Drawing.Point(8, 88);
            this.BOTTOMLEFT.Name = "BOTTOMLEFT";
            this.BOTTOMLEFT.Size = new System.Drawing.Size(10, 48);
            this.BOTTOMLEFT.TabIndex = 4;
            // 
            // BOTTOM
            // 
            this.BOTTOM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BOTTOM.Location = new System.Drawing.Point(23, 142);
            this.BOTTOM.Name = "BOTTOM";
            this.BOTTOM.Size = new System.Drawing.Size(50, 10);
            this.BOTTOM.TabIndex = 5;
            // 
            // MID
            // 
            this.MID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MID.Location = new System.Drawing.Point(23, 70);
            this.MID.Name = "MID";
            this.MID.Size = new System.Drawing.Size(53, 11);
            this.MID.TabIndex = 6;
            // 
            // DigitalFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.MID);
            this.Controls.Add(this.BOTTOM);
            this.Controls.Add(this.BOTTOMLEFT);
            this.Controls.Add(this.BOTTOMRIGHT);
            this.Controls.Add(this.TOPRIGHT);
            this.Controls.Add(this.TOPLEFT);
            this.Controls.Add(this.TopA);
            this.MaximumSize = new System.Drawing.Size(100, 155);
            this.MinimumSize = new System.Drawing.Size(100, 155);
            this.Name = "DigitalFigure";
            this.Size = new System.Drawing.Size(100, 155);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopA;
        private System.Windows.Forms.Panel TOPLEFT;
        private System.Windows.Forms.Panel TOPRIGHT;
        private System.Windows.Forms.Panel BOTTOMRIGHT;
        private System.Windows.Forms.Panel BOTTOMLEFT;
        private System.Windows.Forms.Panel BOTTOM;
        private System.Windows.Forms.Panel MID;
    }
}
