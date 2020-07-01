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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddVertreter = new System.Windows.Forms.Button();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.tbNachname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteVertreter = new System.Windows.Forms.Button();
            this.btnShowVertraege = new System.Windows.Forms.Button();
            this.Nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdVertreter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdVertreter
            // 
            this.grdVertreter.AllowUserToAddRows = false;
            this.grdVertreter.AllowUserToDeleteRows = false;
            this.grdVertreter.AllowUserToResizeColumns = false;
            this.grdVertreter.AllowUserToResizeRows = false;
            this.grdVertreter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVertreter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nachname,
            this.Vorname});
            this.grdVertreter.Location = new System.Drawing.Point(6, 19);
            this.grdVertreter.Name = "grdVertreter";
            this.grdVertreter.ReadOnly = true;
            this.grdVertreter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVertreter.Size = new System.Drawing.Size(410, 232);
            this.grdVertreter.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddVertreter
            // 
            this.btnAddVertreter.Location = new System.Drawing.Point(328, 38);
            this.btnAddVertreter.Name = "btnAddVertreter";
            this.btnAddVertreter.Size = new System.Drawing.Size(75, 23);
            this.btnAddVertreter.TabIndex = 2;
            this.btnAddVertreter.Text = "Speichern";
            this.btnAddVertreter.UseVisualStyleBackColor = true;
            this.btnAddVertreter.Click += new System.EventHandler(this.btnAddVertreter_Click);
            // 
            // tbVorname
            // 
            this.tbVorname.Location = new System.Drawing.Point(14, 40);
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.Size = new System.Drawing.Size(150, 20);
            this.tbVorname.TabIndex = 3;
            // 
            // tbNachname
            // 
            this.tbNachname.Location = new System.Drawing.Point(172, 40);
            this.tbNachname.Name = "tbNachname";
            this.tbNachname.Size = new System.Drawing.Size(150, 20);
            this.tbNachname.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbVorname);
            this.groupBox1.Controls.Add(this.tbNachname);
            this.groupBox1.Controls.Add(this.btnAddVertreter);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vertreter Hinzufügen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vorname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nachname";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowVertraege);
            this.groupBox2.Controls.Add(this.btnDeleteVertreter);
            this.groupBox2.Controls.Add(this.grdVertreter);
            this.groupBox2.Location = new System.Drawing.Point(3, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 286);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vertreter";
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
            // btnShowVertraege
            // 
            this.btnShowVertraege.Location = new System.Drawing.Point(310, 257);
            this.btnShowVertraege.Name = "btnShowVertraege";
            this.btnShowVertraege.Size = new System.Drawing.Size(106, 23);
            this.btnShowVertraege.TabIndex = 3;
            this.btnShowVertraege.Text = "Zeige Verträge";
            this.btnShowVertraege.UseVisualStyleBackColor = true;
            // 
            // Nachname
            // 
            this.Nachname.HeaderText = "Nachname";
            this.Nachname.Name = "Nachname";
            this.Nachname.ReadOnly = true;
            this.Nachname.Width = 200;
            // 
            // Vorname
            // 
            this.Vorname.HeaderText = "Vorname";
            this.Vorname.Name = "Vorname";
            this.Vorname.ReadOnly = true;
            this.Vorname.Width = 150;
            // 
            // VertreterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "VertreterControl";
            this.Size = new System.Drawing.Size(656, 404);
            ((System.ComponentModel.ISupportInitialize)(this.grdVertreter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdVertreter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddVertreter;
        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.TextBox tbNachname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowVertraege;
        private System.Windows.Forms.Button btnDeleteVertreter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vorname;
    }
}
