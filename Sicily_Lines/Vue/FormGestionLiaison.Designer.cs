namespace Sicily_Lines
{
    partial class FormGestionLiaison
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbLiaison = new System.Windows.Forms.ListBox();
            this.gbMAJ = new System.Windows.Forms.GroupBox();
            this.buttonMAJ = new System.Windows.Forms.Button();
            this.labelDuree = new System.Windows.Forms.Label();
            this.tbDuree = new System.Windows.Forms.TextBox();
            this.gbSUPP = new System.Windows.Forms.GroupBox();
            this.buttonSupp = new System.Windows.Forms.Button();
            this.gbADD = new System.Windows.Forms.GroupBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbDureeAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.lbSecteur = new System.Windows.Forms.ListBox();
            this.gbTraversee = new System.Windows.Forms.GroupBox();
            this.BoutonTraversee = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.gbMAJ.SuspendLayout();
            this.gbSUPP.SuspendLayout();
            this.gbADD.SuspendLayout();
            this.gbTraversee.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLiaison
            // 
            this.lbLiaison.FormattingEnabled = true;
            this.lbLiaison.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbLiaison.Location = new System.Drawing.Point(251, 24);
            this.lbLiaison.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbLiaison.Name = "lbLiaison";
            this.lbLiaison.ScrollAlwaysVisible = true;
            this.lbLiaison.Size = new System.Drawing.Size(470, 238);
            this.lbLiaison.TabIndex = 0;
            this.lbLiaison.SelectedIndexChanged += new System.EventHandler(this.lbLiaison_SelectedIndexChanged);
            // 
            // gbMAJ
            // 
            this.gbMAJ.Controls.Add(this.buttonMAJ);
            this.gbMAJ.Controls.Add(this.labelDuree);
            this.gbMAJ.Controls.Add(this.tbDuree);
            this.gbMAJ.Location = new System.Drawing.Point(38, 296);
            this.gbMAJ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbMAJ.Name = "gbMAJ";
            this.gbMAJ.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbMAJ.Size = new System.Drawing.Size(145, 148);
            this.gbMAJ.TabIndex = 1;
            this.gbMAJ.TabStop = false;
            this.gbMAJ.Text = "Mise à jour";
            // 
            // buttonMAJ
            // 
            this.buttonMAJ.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMAJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMAJ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMAJ.Location = new System.Drawing.Point(7, 79);
            this.buttonMAJ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMAJ.Name = "buttonMAJ";
            this.buttonMAJ.Size = new System.Drawing.Size(73, 22);
            this.buttonMAJ.TabIndex = 2;
            this.buttonMAJ.Text = "MAJ";
            this.buttonMAJ.UseVisualStyleBackColor = false;
            this.buttonMAJ.Click += new System.EventHandler(this.buttonMAJ_Click);
            // 
            // labelDuree
            // 
            this.labelDuree.AutoSize = true;
            this.labelDuree.Location = new System.Drawing.Point(96, 46);
            this.labelDuree.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDuree.Name = "labelDuree";
            this.labelDuree.Size = new System.Drawing.Size(36, 13);
            this.labelDuree.TabIndex = 1;
            this.labelDuree.Text = "Durée";
            // 
            // tbDuree
            // 
            this.tbDuree.Location = new System.Drawing.Point(4, 44);
            this.tbDuree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDuree.Name = "tbDuree";
            this.tbDuree.Size = new System.Drawing.Size(76, 20);
            this.tbDuree.TabIndex = 0;
            // 
            // gbSUPP
            // 
            this.gbSUPP.Controls.Add(this.buttonSupp);
            this.gbSUPP.Location = new System.Drawing.Point(207, 296);
            this.gbSUPP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSUPP.Name = "gbSUPP";
            this.gbSUPP.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSUPP.Size = new System.Drawing.Size(115, 148);
            this.gbSUPP.TabIndex = 2;
            this.gbSUPP.TabStop = false;
            this.gbSUPP.Text = "Suppression";
            // 
            // buttonSupp
            // 
            this.buttonSupp.Location = new System.Drawing.Point(15, 49);
            this.buttonSupp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSupp.Name = "buttonSupp";
            this.buttonSupp.Size = new System.Drawing.Size(72, 31);
            this.buttonSupp.TabIndex = 0;
            this.buttonSupp.Text = "Supprimer";
            this.buttonSupp.UseVisualStyleBackColor = true;
            this.buttonSupp.Click += new System.EventHandler(this.buttonSupp_Click);
            // 
            // gbADD
            // 
            this.gbADD.Controls.Add(this.cbPort);
            this.gbADD.Controls.Add(this.label3);
            this.gbADD.Controls.Add(this.label2);
            this.gbADD.Controls.Add(this.tbId);
            this.gbADD.Controls.Add(this.tbDureeAdd);
            this.gbADD.Controls.Add(this.label1);
            this.gbADD.Controls.Add(this.buttonAdd);
            this.gbADD.Location = new System.Drawing.Point(347, 296);
            this.gbADD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbADD.Name = "gbADD";
            this.gbADD.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbADD.Size = new System.Drawing.Size(190, 148);
            this.gbADD.TabIndex = 3;
            this.gbADD.TabStop = false;
            this.gbADD.Text = "Insertion";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(15, 48);
            this.cbPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(79, 21);
            this.cbPort.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Durée";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(15, 18);
            this.tbId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(79, 20);
            this.tbId.TabIndex = 4;
            // 
            // tbDureeAdd
            // 
            this.tbDureeAdd.Location = new System.Drawing.Point(15, 83);
            this.tbDureeAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDureeAdd.Name = "tbDureeAdd";
            this.tbDureeAdd.Size = new System.Drawing.Size(79, 20);
            this.tbDureeAdd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port d\'arrivée";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 112);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(56, 19);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Insérer";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // lbSecteur
            // 
            this.lbSecteur.FormattingEnabled = true;
            this.lbSecteur.Location = new System.Drawing.Point(22, 24);
            this.lbSecteur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbSecteur.Name = "lbSecteur";
            this.lbSecteur.Size = new System.Drawing.Size(209, 238);
            this.lbSecteur.TabIndex = 4;
            this.lbSecteur.SelectedIndexChanged += new System.EventHandler(this.lbSecteur_SelectedIndexChanged);
            // 
            // gbTraversee
            // 
            this.gbTraversee.Controls.Add(this.BoutonTraversee);
            this.gbTraversee.Location = new System.Drawing.Point(570, 296);
            this.gbTraversee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTraversee.Name = "gbTraversee";
            this.gbTraversee.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTraversee.Size = new System.Drawing.Size(150, 101);
            this.gbTraversee.TabIndex = 5;
            this.gbTraversee.TabStop = false;
            this.gbTraversee.Text = "Traversée";
            // 
            // BoutonTraversee
            // 
            this.BoutonTraversee.Location = new System.Drawing.Point(43, 49);
            this.BoutonTraversee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoutonTraversee.Name = "BoutonTraversee";
            this.BoutonTraversee.Size = new System.Drawing.Size(74, 40);
            this.BoutonTraversee.TabIndex = 0;
            this.BoutonTraversee.Text = "Afficher Traversées";
            this.BoutonTraversee.UseVisualStyleBackColor = true;
            this.BoutonTraversee.Click += new System.EventHandler(this.BoutonTraversee_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(570, 407);
            this.btQuitter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(150, 37);
            this.btQuitter.TabIndex = 6;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // FormGestionLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 473);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.gbTraversee);
            this.Controls.Add(this.lbSecteur);
            this.Controls.Add(this.gbADD);
            this.Controls.Add(this.gbSUPP);
            this.Controls.Add(this.gbMAJ);
            this.Controls.Add(this.lbLiaison);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormGestionLiaison";
            this.Text = "FormGestionLiaison";
            this.Load += new System.EventHandler(this.FormGestionLiaison_Load);
            this.gbMAJ.ResumeLayout(false);
            this.gbMAJ.PerformLayout();
            this.gbSUPP.ResumeLayout(false);
            this.gbADD.ResumeLayout(false);
            this.gbADD.PerformLayout();
            this.gbTraversee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbLiaison;
        private System.Windows.Forms.GroupBox gbMAJ;
        private System.Windows.Forms.GroupBox gbSUPP;
        private System.Windows.Forms.GroupBox gbADD;
        private System.Windows.Forms.Label labelDuree;
        private System.Windows.Forms.TextBox tbDuree;
        private System.Windows.Forms.ListBox lbSecteur;
        private System.Windows.Forms.Button buttonMAJ;
        private System.Windows.Forms.Button buttonSupp;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbDureeAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.GroupBox gbTraversee;
        private System.Windows.Forms.Button BoutonTraversee;
        private System.Windows.Forms.Button btQuitter;
    }
}

