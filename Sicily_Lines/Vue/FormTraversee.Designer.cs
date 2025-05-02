namespace Sicily_Lines.Vue
{
    partial class FormTraversee
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
            this.lbTraversee = new System.Windows.Forms.ListBox();
            this.BoutonUpdate = new System.Windows.Forms.Button();
            this.BoutonSupp = new System.Windows.Forms.Button();
            this.BoutonAdd = new System.Windows.Forms.Button();
            this.gpUpdate = new System.Windows.Forms.GroupBox();
            this.gpSupp = new System.Windows.Forms.GroupBox();
            this.gpAdd = new System.Windows.Forms.GroupBox();
            this.tbDateMAJ = new System.Windows.Forms.TextBox();
            this.tbHeureMAJ = new System.Windows.Forms.TextBox();
            this.labelDateMAJ = new System.Windows.Forms.Label();
            this.labelHeureMAJ = new System.Windows.Forms.Label();
            this.cbBateau = new System.Windows.Forms.ComboBox();
            this.tbIdTrav = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbHeure = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelHeure = new System.Windows.Forms.Label();
            this.btQuitter = new System.Windows.Forms.Button();
            this.gpUpdate.SuspendLayout();
            this.gpSupp.SuspendLayout();
            this.gpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTraversee
            // 
            this.lbTraversee.FormattingEnabled = true;
            this.lbTraversee.ItemHeight = 16;
            this.lbTraversee.Location = new System.Drawing.Point(56, 26);
            this.lbTraversee.Name = "lbTraversee";
            this.lbTraversee.Size = new System.Drawing.Size(580, 260);
            this.lbTraversee.TabIndex = 0;
            // 
            // BoutonUpdate
            // 
            this.BoutonUpdate.Location = new System.Drawing.Point(53, 107);
            this.BoutonUpdate.Name = "BoutonUpdate";
            this.BoutonUpdate.Size = new System.Drawing.Size(120, 39);
            this.BoutonUpdate.TabIndex = 1;
            this.BoutonUpdate.Text = "Mise à jour";
            this.BoutonUpdate.UseVisualStyleBackColor = true;
            this.BoutonUpdate.Click += new System.EventHandler(this.BoutonUpdate_Click);
            // 
            // BoutonSupp
            // 
            this.BoutonSupp.Location = new System.Drawing.Point(58, 71);
            this.BoutonSupp.Name = "BoutonSupp";
            this.BoutonSupp.Size = new System.Drawing.Size(120, 39);
            this.BoutonSupp.TabIndex = 2;
            this.BoutonSupp.Text = "Supprimer";
            this.BoutonSupp.UseVisualStyleBackColor = true;
            this.BoutonSupp.Click += new System.EventHandler(this.BoutonSupp_Click);
            // 
            // BoutonAdd
            // 
            this.BoutonAdd.Location = new System.Drawing.Point(149, 166);
            this.BoutonAdd.Name = "BoutonAdd";
            this.BoutonAdd.Size = new System.Drawing.Size(110, 28);
            this.BoutonAdd.TabIndex = 3;
            this.BoutonAdd.Text = "Ajouter";
            this.BoutonAdd.UseVisualStyleBackColor = true;
            this.BoutonAdd.Click += new System.EventHandler(this.BoutonAdd_Click);
            // 
            // gpUpdate
            // 
            this.gpUpdate.Controls.Add(this.labelHeureMAJ);
            this.gpUpdate.Controls.Add(this.labelDateMAJ);
            this.gpUpdate.Controls.Add(this.tbHeureMAJ);
            this.gpUpdate.Controls.Add(this.tbDateMAJ);
            this.gpUpdate.Controls.Add(this.BoutonUpdate);
            this.gpUpdate.Location = new System.Drawing.Point(46, 320);
            this.gpUpdate.Name = "gpUpdate";
            this.gpUpdate.Size = new System.Drawing.Size(241, 194);
            this.gpUpdate.TabIndex = 4;
            this.gpUpdate.TabStop = false;
            this.gpUpdate.Text = "Mise à jour";
            // 
            // gpSupp
            // 
            this.gpSupp.Controls.Add(this.BoutonSupp);
            this.gpSupp.Location = new System.Drawing.Point(345, 320);
            this.gpSupp.Name = "gpSupp";
            this.gpSupp.Size = new System.Drawing.Size(236, 200);
            this.gpSupp.TabIndex = 5;
            this.gpSupp.TabStop = false;
            this.gpSupp.Text = "Suppression";
            // 
            // gpAdd
            // 
            this.gpAdd.Controls.Add(this.labelHeure);
            this.gpAdd.Controls.Add(this.labelDate);
            this.gpAdd.Controls.Add(this.label1);
            this.gpAdd.Controls.Add(this.labelId);
            this.gpAdd.Controls.Add(this.tbHeure);
            this.gpAdd.Controls.Add(this.tbDate);
            this.gpAdd.Controls.Add(this.tbIdTrav);
            this.gpAdd.Controls.Add(this.cbBateau);
            this.gpAdd.Controls.Add(this.BoutonAdd);
            this.gpAdd.Location = new System.Drawing.Point(625, 320);
            this.gpAdd.Name = "gpAdd";
            this.gpAdd.Size = new System.Drawing.Size(296, 200);
            this.gpAdd.TabIndex = 6;
            this.gpAdd.TabStop = false;
            this.gpAdd.Text = "Insertion";
            // 
            // tbDateMAJ
            // 
            this.tbDateMAJ.Location = new System.Drawing.Point(29, 35);
            this.tbDateMAJ.Name = "tbDateMAJ";
            this.tbDateMAJ.Size = new System.Drawing.Size(100, 22);
            this.tbDateMAJ.TabIndex = 2;
            // 
            // tbHeureMAJ
            // 
            this.tbHeureMAJ.Location = new System.Drawing.Point(29, 71);
            this.tbHeureMAJ.Name = "tbHeureMAJ";
            this.tbHeureMAJ.Size = new System.Drawing.Size(100, 22);
            this.tbHeureMAJ.TabIndex = 3;
            // 
            // labelDateMAJ
            // 
            this.labelDateMAJ.AutoSize = true;
            this.labelDateMAJ.Location = new System.Drawing.Point(152, 38);
            this.labelDateMAJ.Name = "labelDateMAJ";
            this.labelDateMAJ.Size = new System.Drawing.Size(36, 16);
            this.labelDateMAJ.TabIndex = 4;
            this.labelDateMAJ.Text = "Date";
            // 
            // labelHeureMAJ
            // 
            this.labelHeureMAJ.AutoSize = true;
            this.labelHeureMAJ.Location = new System.Drawing.Point(152, 71);
            this.labelHeureMAJ.Name = "labelHeureMAJ";
            this.labelHeureMAJ.Size = new System.Drawing.Size(44, 16);
            this.labelHeureMAJ.TabIndex = 5;
            this.labelHeureMAJ.Text = "Heure";
            // 
            // cbBateau
            // 
            this.cbBateau.FormattingEnabled = true;
            this.cbBateau.Location = new System.Drawing.Point(25, 63);
            this.cbBateau.Name = "cbBateau";
            this.cbBateau.Size = new System.Drawing.Size(178, 24);
            this.cbBateau.TabIndex = 4;
            // 
            // tbIdTrav
            // 
            this.tbIdTrav.Location = new System.Drawing.Point(25, 32);
            this.tbIdTrav.Name = "tbIdTrav";
            this.tbIdTrav.Size = new System.Drawing.Size(100, 22);
            this.tbIdTrav.TabIndex = 5;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(25, 93);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 22);
            this.tbDate.TabIndex = 6;
            // 
            // tbHeure
            // 
            this.tbHeure.Location = new System.Drawing.Point(25, 124);
            this.tbHeure.Name = "tbHeure";
            this.tbHeure.Size = new System.Drawing.Size(100, 22);
            this.tbHeure.TabIndex = 7;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(149, 35);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(84, 16);
            this.labelId.TabIndex = 8;
            this.labelId.Text = "Id Traversée";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bateau";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(152, 98);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 16);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "Date";
            // 
            // labelHeure
            // 
            this.labelHeure.AutoSize = true;
            this.labelHeure.Location = new System.Drawing.Point(149, 129);
            this.labelHeure.Name = "labelHeure";
            this.labelHeure.Size = new System.Drawing.Size(44, 16);
            this.labelHeure.TabIndex = 11;
            this.labelHeure.Text = "Heure";
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(682, 67);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(224, 84);
            this.btQuitter.TabIndex = 7;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // FormTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 553);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.gpAdd);
            this.Controls.Add(this.gpSupp);
            this.Controls.Add(this.gpUpdate);
            this.Controls.Add(this.lbTraversee);
            this.Name = "FormTraversee";
            this.Text = "FormTraversee";
            this.Load += new System.EventHandler(this.FormTraversee_Load);
            this.gpUpdate.ResumeLayout(false);
            this.gpUpdate.PerformLayout();
            this.gpSupp.ResumeLayout(false);
            this.gpAdd.ResumeLayout(false);
            this.gpAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTraversee;
        private System.Windows.Forms.Button BoutonUpdate;
        private System.Windows.Forms.Button BoutonSupp;
        private System.Windows.Forms.Button BoutonAdd;
        private System.Windows.Forms.GroupBox gpUpdate;
        private System.Windows.Forms.GroupBox gpSupp;
        private System.Windows.Forms.GroupBox gpAdd;
        private System.Windows.Forms.TextBox tbHeureMAJ;
        private System.Windows.Forms.TextBox tbDateMAJ;
        private System.Windows.Forms.Label labelHeureMAJ;
        private System.Windows.Forms.Label labelDateMAJ;
        private System.Windows.Forms.TextBox tbIdTrav;
        private System.Windows.Forms.ComboBox cbBateau;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox tbHeure;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label labelHeure;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btQuitter;
    }
}