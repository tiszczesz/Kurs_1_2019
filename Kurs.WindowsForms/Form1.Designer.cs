namespace Kurs.WindowsForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbZakres = new System.Windows.Forms.TextBox();
            this.btnGener = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(266, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generator Liczb pierwszych";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podaj zakres górny:";
            // 
            // tbZakres
            // 
            this.tbZakres.Location = new System.Drawing.Point(118, 63);
            this.tbZakres.Name = "tbZakres";
            this.tbZakres.Size = new System.Drawing.Size(100, 20);
            this.tbZakres.TabIndex = 2;
            this.tbZakres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbZakres_KeyPress);
            // 
            // btnGener
            // 
            this.btnGener.Location = new System.Drawing.Point(235, 61);
            this.btnGener.Name = "btnGener";
            this.btnGener.Size = new System.Drawing.Size(142, 23);
            this.btnGener.TabIndex = 3;
            this.btnGener.Text = "Generuj";
            this.btnGener.UseVisualStyleBackColor = true;
            this.btnGener.Click += new System.EventHandler(this.btnGener_Click);
            // 
            // wynik
            // 
            this.wynik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.wynik.Location = new System.Drawing.Point(1, 113);
            this.wynik.Multiline = true;
            this.wynik.Name = "wynik";
            this.wynik.ReadOnly = true;
            this.wynik.Size = new System.Drawing.Size(941, 431);
            this.wynik.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGener);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbZakres);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 107);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wynik);
            this.Name = "Form1";
            this.Text = "Liczby Pierwsze";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbZakres;
        private System.Windows.Forms.Button btnGener;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.Panel panel1;
    }
}

