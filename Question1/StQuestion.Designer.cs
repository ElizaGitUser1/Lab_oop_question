namespace Question1
{
    partial class StQuestion
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
            this.btYes = new System.Windows.Forms.Button();
            this.btNo = new System.Windows.Forms.Button();
            this.lbQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btYes
            // 
            this.btYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btYes.Location = new System.Drawing.Point(210, 168);
            this.btYes.Name = "btYes";
            this.btYes.Size = new System.Drawing.Size(75, 23);
            this.btYes.TabIndex = 0;
            this.btYes.Text = "Так";
            this.btYes.UseVisualStyleBackColor = false;
            this.btYes.Click += new System.EventHandler(this.btYes_Click);
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btNo.Location = new System.Drawing.Point(460, 168);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(75, 23);
            this.btNo.TabIndex = 1;
            this.btNo.Text = "Ні";
            this.btNo.UseVisualStyleBackColor = false;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            this.btNo.MouseEnter += new System.EventHandler(this.btNo_MouseEnter);
            // 
            // lbQ
            // 
            this.lbQ.AutoSize = true;
            this.lbQ.Location = new System.Drawing.Point(284, 104);
            this.lbQ.Name = "lbQ";
            this.lbQ.Size = new System.Drawing.Size(187, 16);
            this.lbQ.TabIndex = 2;
            this.lbQ.Text = "Ви задоволені стипендією?";
            // 
            // StQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbQ);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btYes);
            this.Name = "StQuestion";
            this.Text = "Дайте відповідь на запитання";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btYes;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Label lbQ;
    }
}

