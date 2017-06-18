namespace Wifi
{
    partial class frmUse
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
            this.btnOff = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(72)))), ((int)(((byte)(99)))));
            this.btnOff.FlatAppearance.BorderSize = 0;
            this.btnOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(112)))), ((int)(((byte)(149)))));
            this.btnOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(112)))), ((int)(((byte)(149)))));
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.ForeColor = System.Drawing.Color.White;
            this.btnOff.Location = new System.Drawing.Point(263, 86);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(117, 55);
            this.btnOff.TabIndex = 6;
            this.btnOff.Text = "Tắt";
            this.btnOff.UseVisualStyleBackColor = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnOn
            // 
            this.btnOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(72)))), ((int)(((byte)(99)))));
            this.btnOn.FlatAppearance.BorderSize = 0;
            this.btnOn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(112)))), ((int)(((byte)(149)))));
            this.btnOn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(112)))), ((int)(((byte)(149)))));
            this.btnOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOn.ForeColor = System.Drawing.Color.White;
            this.btnOn.Location = new System.Drawing.Point(131, 86);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(117, 55);
            this.btnOn.TabIndex = 7;
            this.btnOn.Text = "Bật";
            this.btnOn.UseVisualStyleBackColor = false;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // frmUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 253);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUse";
            this.Text = "frmUse";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnOn;
    }
}