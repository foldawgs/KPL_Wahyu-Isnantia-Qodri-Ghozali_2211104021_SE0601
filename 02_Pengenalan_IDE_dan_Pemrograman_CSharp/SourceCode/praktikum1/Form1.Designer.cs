namespace praktikum1
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
            this.btnNamakuSiapa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNamakuSiapa
            // 
            this.btnNamakuSiapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNamakuSiapa.Location = new System.Drawing.Point(279, 203);
            this.btnNamakuSiapa.Name = "btnNamakuSiapa";
            this.btnNamakuSiapa.Size = new System.Drawing.Size(619, 401);
            this.btnNamakuSiapa.TabIndex = 0;
            this.btnNamakuSiapa.Text = "NAMAKU SIAPA?";
            this.btnNamakuSiapa.UseVisualStyleBackColor = true;
            this.btnNamakuSiapa.Click += new System.EventHandler(this.btnNamakuSiapa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 858);
            this.Controls.Add(this.btnNamakuSiapa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNamakuSiapa;
    }
}

