namespace CollapsingPoints
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMaxX = new System.Windows.Forms.Label();
            this.lblMinX = new System.Windows.Forms.Label();
            this.lblMinY = new System.Windows.Forms.Label();
            this.lblMaxY = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMaxX);
            this.panel1.Controls.Add(this.lblMinX);
            this.panel1.Controls.Add(this.lblMinY);
            this.panel1.Controls.Add(this.lblMaxY);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 561);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblMaxX
            // 
            this.lblMaxX.AutoSize = true;
            this.lblMaxX.Location = new System.Drawing.Point(537, 544);
            this.lblMaxX.Name = "lblMaxX";
            this.lblMaxX.Size = new System.Drawing.Size(35, 13);
            this.lblMaxX.TabIndex = 3;
            this.lblMaxX.Text = "label4";
            // 
            // lblMinX
            // 
            this.lblMinX.AutoSize = true;
            this.lblMinX.Location = new System.Drawing.Point(29, 544);
            this.lblMinX.Name = "lblMinX";
            this.lblMinX.Size = new System.Drawing.Size(35, 13);
            this.lblMinX.TabIndex = 2;
            this.lblMinX.Text = "label3";
            // 
            // lblMinY
            // 
            this.lblMinY.AutoSize = true;
            this.lblMinY.Location = new System.Drawing.Point(3, 531);
            this.lblMinY.Name = "lblMinY";
            this.lblMinY.Size = new System.Drawing.Size(35, 13);
            this.lblMinY.TabIndex = 1;
            this.lblMinY.Text = "label2";
            // 
            // lblMaxY
            // 
            this.lblMaxY.AutoSize = true;
            this.lblMaxY.Location = new System.Drawing.Point(4, 4);
            this.lblMaxY.Name = "lblMaxY";
            this.lblMaxY.Size = new System.Drawing.Size(35, 13);
            this.lblMaxY.TabIndex = 0;
            this.lblMaxY.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMaxX;
        private System.Windows.Forms.Label lblMinX;
        private System.Windows.Forms.Label lblMinY;
        private System.Windows.Forms.Label lblMaxY;
    }
}

