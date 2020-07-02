namespace Gehaltsbuero.Dialogs
{
    partial class NeuerVertreter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.tbNachname = new System.Windows.Forms.TextBox();
            this.btnAddVertreter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbVorname);
            this.groupBox1.Controls.Add(this.tbNachname);
            this.groupBox1.Controls.Add(this.btnAddVertreter);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 129);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vertreter Hinzufügen";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(6, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Abbrechen";
            this.button1.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vorname";
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
            // btnAddVertreter
            // 
            this.btnAddVertreter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddVertreter.Location = new System.Drawing.Point(247, 100);
            this.btnAddVertreter.Name = "btnAddVertreter";
            this.btnAddVertreter.Size = new System.Drawing.Size(75, 23);
            this.btnAddVertreter.TabIndex = 2;
            this.btnAddVertreter.Text = "Speichern";
            this.btnAddVertreter.UseVisualStyleBackColor = true;
            this.btnAddVertreter.Click += new System.EventHandler(this.btnAddVertreter_Click);
            // 
            // NeuerVertreter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 153);
            this.Controls.Add(this.groupBox1);
            this.Name = "NeuerVertreter";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeuerVertreter";
            this.Load += new System.EventHandler(this.NeuerVertreter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.TextBox tbNachname;
        private System.Windows.Forms.Button btnAddVertreter;
    }
}