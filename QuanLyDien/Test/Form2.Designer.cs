namespace QuanLyDien.Test
{
    partial class Form2
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.pnlTitle.Controls.Add(this.btnMax);
            this.pnlTitle.Controls.Add(this.btnMin);
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1271, 29);
            this.pnlTitle.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1239, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(1207, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(32, 29);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "–";
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // btnMax
            // 
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(1175, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(32, 29);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "▢";
            this.btnMax.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlTop);
            this.panel1.Controls.Add(this.pnlTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 170);
            this.panel1.TabIndex = 5;
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::QuanLyDien.Properties.Resources._572c661b_9135_404b_8784_1c36f75b5506_removebg_preview;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(4, 32);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 69);
            this.button8.TabIndex = 0;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(58)))));
            this.pnlTop.Controls.Add(this.button8);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ForeColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(0, 29);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1271, 113);
            this.pnlTop.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 701);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.pnlTitle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button button8;
    }
}