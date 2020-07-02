namespace Gehaltsbuero.Controls
{
    partial class VertreterControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdVertreter = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNeuerVertreter = new System.Windows.Forms.Button();
            this.btnShowVertraege = new System.Windows.Forms.Button();
            this.btnDeleteVertreter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdVertreter)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdVertreter
            // 
            this.grdVertreter.AllowUserToResizeColumns = false;
            this.grdVertreter.AllowUserToResizeRows = false;
            this.grdVertreter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVertreter.Location = new System.Drawing.Point(6, 19);
            this.grdVertreter.Name = "grdVertreter";
            this.grdVertreter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVertreter.Size = new System.Drawing.Size(410, 232);
            this.grdVertreter.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNeuerVertreter);
            this.groupBox2.Controls.Add(this.btnShowVertraege);
            this.groupBox2.Controls.Add(this.btnDeleteVertreter);
            this.groupBox2.Controls.Add(this.grdVertreter);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 286);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vertreter";
            // 
            // btnNeuerVertreter
            // 
            this.btnNeuerVertreter.Location = new System.Drawing.Point(87, 257);
            this.btnNeuerVertreter.Name = "btnNeuerVertreter";
            this.btnNeuerVertreter.Size = new System.Drawing.Size(75, 23);
            this.btnNeuerVertreter.TabIndex = 4;
            this.btnNeuerVertreter.Text = "Neu";
            this.btnNeuerVertreter.UseVisualStyleBackColor = true;
            this.btnNeuerVertreter.Click += new System.EventHandler(this.btnNeuerVertreter_Click);
            // 
            // btnShowVertraege
            // 
            this.btnShowVertraege.Location = new System.Drawing.Point(310, 257);
            this.btnShowVertraege.Name = "btnShowVertraege";
            this.btnShowVertraege.Size = new System.Drawing.Size(106, 23);
            this.btnShowVertraege.TabIndex = 3;
            this.btnShowVertraege.Text = "Zeige Verträge";
            this.btnShowVertraege.UseVisualStyleBackColor = true;
            // 
            // btnDeleteVertreter
            // 
            this.btnDeleteVertreter.Location = new System.Drawing.Point(6, 257);
            this.btnDeleteVertreter.Name = "btnDeleteVertreter";
            this.btnDeleteVertreter.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteVertreter.TabIndex = 2;
            this.btnDeleteVertreter.Text = "Löschen";
            this.btnDeleteVertreter.UseVisualStyleBackColor = true;
            // 
            // VertreterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "VertreterControl";
            this.Size = new System.Drawing.Size(440, 355);
            ((System.ComponentModel.ISupportInitialize)(this.grdVertreter)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdVertreter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowVertraege;
        private System.Windows.Forms.Button btnDeleteVertreter;
        private System.Windows.Forms.Button btnNeuerVertreter;
    }
}
