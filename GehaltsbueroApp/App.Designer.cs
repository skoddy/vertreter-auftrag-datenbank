namespace Gehaltsbuero
{
    partial class App
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowVertreter = new System.Windows.Forms.Button();
            this.btnShowAuftraege = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(220, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 426);
            this.panel1.TabIndex = 4;
            // 
            // btnShowVertreter
            // 
            this.btnShowVertreter.Location = new System.Drawing.Point(12, 12);
            this.btnShowVertreter.Name = "btnShowVertreter";
            this.btnShowVertreter.Size = new System.Drawing.Size(145, 23);
            this.btnShowVertreter.TabIndex = 5;
            this.btnShowVertreter.Text = "Vertreter";
            this.btnShowVertreter.UseVisualStyleBackColor = true;
            this.btnShowVertreter.Click += new System.EventHandler(this.btnShowVertreter_Click);
            // 
            // btnShowAuftraege
            // 
            this.btnShowAuftraege.Location = new System.Drawing.Point(12, 41);
            this.btnShowAuftraege.Name = "btnShowAuftraege";
            this.btnShowAuftraege.Size = new System.Drawing.Size(145, 23);
            this.btnShowAuftraege.TabIndex = 6;
            this.btnShowAuftraege.Text = "Aufträge";
            this.btnShowAuftraege.UseVisualStyleBackColor = true;
            this.btnShowAuftraege.Click += new System.EventHandler(this.btnShowAuftraege_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowAuftraege);
            this.Controls.Add(this.btnShowVertreter);
            this.Controls.Add(this.panel1);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowVertreter;
        private System.Windows.Forms.Button btnShowAuftraege;
    }
}

