namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lstOffre = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModCrit = new System.Windows.Forms.Button();
            this.lstCrit = new System.Windows.Forms.ListBox();
            this.txtBoxCritMod = new System.Windows.Forms.TextBox();
            this.txtBoxCritCoefMod = new System.Windows.Forms.TextBox();
            this.gpBoxMod = new System.Windows.Forms.GroupBox();
            this.btnSuppCrit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddCrit = new System.Windows.Forms.Button();
            this.gpBoxAdd = new System.Windows.Forms.GroupBox();
            this.comboBoxCritAdd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddCrit = new System.Windows.Forms.Button();
            this.txtBoxCritCoefAdd = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gpBoxDateLimite = new System.Windows.Forms.GroupBox();
            this.btnDateLimite = new System.Windows.Forms.Button();
            this.AddDate = new System.Windows.Forms.Button();
            this.gpNote = new System.Windows.Forms.GroupBox();
            this.btnNoter = new System.Windows.Forms.Button();
            this.radBtnNote5 = new System.Windows.Forms.RadioButton();
            this.radBtnNote4 = new System.Windows.Forms.RadioButton();
            this.radBtnNote3 = new System.Windows.Forms.RadioButton();
            this.radBtnNote2 = new System.Windows.Forms.RadioButton();
            this.radBtnNote1 = new System.Windows.Forms.RadioButton();
            this.radBtnNote0 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxCrit = new System.Windows.Forms.TextBox();
            this.lstCandid = new System.Windows.Forms.ListBox();
            this.gpBoxMod.SuspendLayout();
            this.gpBoxAdd.SuspendLayout();
            this.gpBoxDateLimite.SuspendLayout();
            this.gpNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOffre
            // 
            this.lstOffre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOffre.FormattingEnabled = true;
            this.lstOffre.ItemHeight = 15;
            this.lstOffre.Location = new System.Drawing.Point(12, 38);
            this.lstOffre.Name = "lstOffre";
            this.lstOffre.Size = new System.Drawing.Size(245, 394);
            this.lstOffre.TabIndex = 1;
            this.lstOffre.SelectedIndexChanged += new System.EventHandler(this.lstOffre_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 100;
            this.label1.Text = "Liste des offres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Critères de l\'offre sélectionnée :";
            // 
            // btnModCrit
            // 
            this.btnModCrit.Location = new System.Drawing.Point(20, 105);
            this.btnModCrit.Name = "btnModCrit";
            this.btnModCrit.Size = new System.Drawing.Size(71, 30);
            this.btnModCrit.TabIndex = 5;
            this.btnModCrit.Text = "Modifier";
            this.btnModCrit.UseVisualStyleBackColor = true;
            this.btnModCrit.Click += new System.EventHandler(this.btnModCrit_Click);
            // 
            // lstCrit
            // 
            this.lstCrit.FormattingEnabled = true;
            this.lstCrit.Location = new System.Drawing.Point(299, 72);
            this.lstCrit.Name = "lstCrit";
            this.lstCrit.Size = new System.Drawing.Size(205, 147);
            this.lstCrit.TabIndex = 2;
            this.lstCrit.SelectedIndexChanged += new System.EventHandler(this.lstCrit_SelectedIndexChanged);
            // 
            // txtBoxCritMod
            // 
            this.txtBoxCritMod.Enabled = false;
            this.txtBoxCritMod.Location = new System.Drawing.Point(6, 35);
            this.txtBoxCritMod.Name = "txtBoxCritMod";
            this.txtBoxCritMod.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCritMod.TabIndex = 100;
            // 
            // txtBoxCritCoefMod
            // 
            this.txtBoxCritCoefMod.Location = new System.Drawing.Point(123, 35);
            this.txtBoxCritCoefMod.Name = "txtBoxCritCoefMod";
            this.txtBoxCritCoefMod.Size = new System.Drawing.Size(76, 20);
            this.txtBoxCritCoefMod.TabIndex = 4;
            this.txtBoxCritCoefMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCritCoefMod_KeyPress);
            // 
            // gpBoxMod
            // 
            this.gpBoxMod.Controls.Add(this.btnSuppCrit);
            this.gpBoxMod.Controls.Add(this.label3);
            this.gpBoxMod.Controls.Add(this.label4);
            this.gpBoxMod.Controls.Add(this.btnModCrit);
            this.gpBoxMod.Controls.Add(this.txtBoxCritMod);
            this.gpBoxMod.Controls.Add(this.txtBoxCritCoefMod);
            this.gpBoxMod.Location = new System.Drawing.Point(299, 281);
            this.gpBoxMod.Name = "gpBoxMod";
            this.gpBoxMod.Size = new System.Drawing.Size(205, 151);
            this.gpBoxMod.TabIndex = 12;
            this.gpBoxMod.TabStop = false;
            this.gpBoxMod.Text = "Modifier un Critère";
            this.gpBoxMod.Visible = false;
            // 
            // btnSuppCrit
            // 
            this.btnSuppCrit.Location = new System.Drawing.Point(112, 105);
            this.btnSuppCrit.Name = "btnSuppCrit";
            this.btnSuppCrit.Size = new System.Drawing.Size(71, 30);
            this.btnSuppCrit.TabIndex = 6;
            this.btnSuppCrit.Text = "Supprimer";
            this.btnSuppCrit.UseVisualStyleBackColor = true;
            this.btnSuppCrit.Click += new System.EventHandler(this.btnSuppCrit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Critère :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Coefficient :";
            // 
            // AddCrit
            // 
            this.AddCrit.Enabled = false;
            this.AddCrit.Location = new System.Drawing.Point(299, 225);
            this.AddCrit.Name = "AddCrit";
            this.AddCrit.Size = new System.Drawing.Size(205, 23);
            this.AddCrit.TabIndex = 3;
            this.AddCrit.Text = "Ajouter un critère";
            this.AddCrit.UseVisualStyleBackColor = true;
            this.AddCrit.Visible = false;
            this.AddCrit.Click += new System.EventHandler(this.AddCrit_Click);
            // 
            // gpBoxAdd
            // 
            this.gpBoxAdd.Controls.Add(this.comboBoxCritAdd);
            this.gpBoxAdd.Controls.Add(this.label5);
            this.gpBoxAdd.Controls.Add(this.label6);
            this.gpBoxAdd.Controls.Add(this.btnAddCrit);
            this.gpBoxAdd.Controls.Add(this.txtBoxCritCoefAdd);
            this.gpBoxAdd.Location = new System.Drawing.Point(535, 281);
            this.gpBoxAdd.Name = "gpBoxAdd";
            this.gpBoxAdd.Size = new System.Drawing.Size(205, 151);
            this.gpBoxAdd.TabIndex = 14;
            this.gpBoxAdd.TabStop = false;
            this.gpBoxAdd.Text = "Ajouter un Critère";
            this.gpBoxAdd.Visible = false;
            // 
            // comboBoxCritAdd
            // 
            this.comboBoxCritAdd.FormattingEnabled = true;
            this.comboBoxCritAdd.Location = new System.Drawing.Point(6, 35);
            this.comboBoxCritAdd.Name = "comboBoxCritAdd";
            this.comboBoxCritAdd.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCritAdd.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Critère :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Coefficient :";
            // 
            // btnAddCrit
            // 
            this.btnAddCrit.Location = new System.Drawing.Point(67, 105);
            this.btnAddCrit.Name = "btnAddCrit";
            this.btnAddCrit.Size = new System.Drawing.Size(71, 30);
            this.btnAddCrit.TabIndex = 5;
            this.btnAddCrit.Text = "Ajouter";
            this.btnAddCrit.UseVisualStyleBackColor = true;
            this.btnAddCrit.Click += new System.EventHandler(this.btnAddCrit_Click);
            // 
            // txtBoxCritCoefAdd
            // 
            this.txtBoxCritCoefAdd.Location = new System.Drawing.Point(123, 35);
            this.txtBoxCritCoefAdd.Name = "txtBoxCritCoefAdd";
            this.txtBoxCritCoefAdd.Size = new System.Drawing.Size(76, 20);
            this.txtBoxCritCoefAdd.TabIndex = 4;
            this.txtBoxCritCoefAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCritCoefAdd_KeyPress);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(15, 40);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker.TabIndex = 101;
            // 
            // gpBoxDateLimite
            // 
            this.gpBoxDateLimite.Controls.Add(this.btnDateLimite);
            this.gpBoxDateLimite.Controls.Add(this.dateTimePicker);
            this.gpBoxDateLimite.Location = new System.Drawing.Point(535, 68);
            this.gpBoxDateLimite.Name = "gpBoxDateLimite";
            this.gpBoxDateLimite.Size = new System.Drawing.Size(205, 151);
            this.gpBoxDateLimite.TabIndex = 102;
            this.gpBoxDateLimite.TabStop = false;
            this.gpBoxDateLimite.Text = "Modifier la Date Limite";
            this.gpBoxDateLimite.Visible = false;
            // 
            // btnDateLimite
            // 
            this.btnDateLimite.Location = new System.Drawing.Point(67, 105);
            this.btnDateLimite.Name = "btnDateLimite";
            this.btnDateLimite.Size = new System.Drawing.Size(71, 30);
            this.btnDateLimite.TabIndex = 102;
            this.btnDateLimite.Text = "Modifier";
            this.btnDateLimite.UseVisualStyleBackColor = true;
            this.btnDateLimite.Click += new System.EventHandler(this.btnDateLimite_Click);
            // 
            // AddDate
            // 
            this.AddDate.Enabled = false;
            this.AddDate.Location = new System.Drawing.Point(299, 254);
            this.AddDate.Name = "AddDate";
            this.AddDate.Size = new System.Drawing.Size(205, 23);
            this.AddDate.TabIndex = 103;
            this.AddDate.Text = "Ajouter un date limite";
            this.AddDate.UseVisualStyleBackColor = true;
            this.AddDate.Visible = false;
            this.AddDate.Click += new System.EventHandler(this.AddDate_Click);
            // 
            // gpNote
            // 
            this.gpNote.Controls.Add(this.btnNoter);
            this.gpNote.Controls.Add(this.radBtnNote5);
            this.gpNote.Controls.Add(this.radBtnNote4);
            this.gpNote.Controls.Add(this.radBtnNote3);
            this.gpNote.Controls.Add(this.radBtnNote2);
            this.gpNote.Controls.Add(this.radBtnNote1);
            this.gpNote.Controls.Add(this.radBtnNote0);
            this.gpNote.Controls.Add(this.label8);
            this.gpNote.Controls.Add(this.label7);
            this.gpNote.Controls.Add(this.txtBoxCrit);
            this.gpNote.Location = new System.Drawing.Point(778, 145);
            this.gpNote.Name = "gpNote";
            this.gpNote.Size = new System.Drawing.Size(205, 168);
            this.gpNote.TabIndex = 104;
            this.gpNote.TabStop = false;
            this.gpNote.Text = "Noter";
            // 
            // btnNoter
            // 
            this.btnNoter.Location = new System.Drawing.Point(67, 125);
            this.btnNoter.Name = "btnNoter";
            this.btnNoter.Size = new System.Drawing.Size(71, 30);
            this.btnNoter.TabIndex = 110;
            this.btnNoter.Text = "Noter";
            this.btnNoter.UseVisualStyleBackColor = true;
            this.btnNoter.Click += new System.EventHandler(this.btnNoter_Click);
            // 
            // radBtnNote5
            // 
            this.radBtnNote5.AutoSize = true;
            this.radBtnNote5.Location = new System.Drawing.Point(124, 102);
            this.radBtnNote5.Name = "radBtnNote5";
            this.radBtnNote5.Size = new System.Drawing.Size(31, 17);
            this.radBtnNote5.TabIndex = 109;
            this.radBtnNote5.TabStop = true;
            this.radBtnNote5.Text = "5";
            this.radBtnNote5.UseVisualStyleBackColor = true;
            // 
            // radBtnNote4
            // 
            this.radBtnNote4.AutoSize = true;
            this.radBtnNote4.Location = new System.Drawing.Point(87, 102);
            this.radBtnNote4.Name = "radBtnNote4";
            this.radBtnNote4.Size = new System.Drawing.Size(31, 17);
            this.radBtnNote4.TabIndex = 108;
            this.radBtnNote4.TabStop = true;
            this.radBtnNote4.Text = "4";
            this.radBtnNote4.UseVisualStyleBackColor = true;
            // 
            // radBtnNote3
            // 
            this.radBtnNote3.AutoSize = true;
            this.radBtnNote3.Location = new System.Drawing.Point(50, 102);
            this.radBtnNote3.Name = "radBtnNote3";
            this.radBtnNote3.Size = new System.Drawing.Size(31, 17);
            this.radBtnNote3.TabIndex = 107;
            this.radBtnNote3.TabStop = true;
            this.radBtnNote3.Text = "3";
            this.radBtnNote3.UseVisualStyleBackColor = true;
            // 
            // radBtnNote2
            // 
            this.radBtnNote2.AutoSize = true;
            this.radBtnNote2.Location = new System.Drawing.Point(124, 83);
            this.radBtnNote2.Name = "radBtnNote2";
            this.radBtnNote2.Size = new System.Drawing.Size(31, 17);
            this.radBtnNote2.TabIndex = 106;
            this.radBtnNote2.TabStop = true;
            this.radBtnNote2.Text = "2";
            this.radBtnNote2.UseVisualStyleBackColor = true;
            // 
            // radBtnNote1
            // 
            this.radBtnNote1.AutoSize = true;
            this.radBtnNote1.Location = new System.Drawing.Point(87, 80);
            this.radBtnNote1.Name = "radBtnNote1";
            this.radBtnNote1.Size = new System.Drawing.Size(31, 17);
            this.radBtnNote1.TabIndex = 105;
            this.radBtnNote1.TabStop = true;
            this.radBtnNote1.Text = "1";
            this.radBtnNote1.UseVisualStyleBackColor = true;
            // 
            // radBtnNote0
            // 
            this.radBtnNote0.AutoSize = true;
            this.radBtnNote0.Location = new System.Drawing.Point(50, 80);
            this.radBtnNote0.Name = "radBtnNote0";
            this.radBtnNote0.Size = new System.Drawing.Size(31, 17);
            this.radBtnNote0.TabIndex = 104;
            this.radBtnNote0.TabStop = true;
            this.radBtnNote0.Text = "0";
            this.radBtnNote0.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 103;
            this.label8.Text = "Note :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 101;
            this.label7.Text = "Critère :";
            // 
            // txtBoxCrit
            // 
            this.txtBoxCrit.Enabled = false;
            this.txtBoxCrit.Location = new System.Drawing.Point(17, 44);
            this.txtBoxCrit.Name = "txtBoxCrit";
            this.txtBoxCrit.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCrit.TabIndex = 102;
            // 
            // lstCandid
            // 
            this.lstCandid.FormattingEnabled = true;
            this.lstCandid.Location = new System.Drawing.Point(778, 321);
            this.lstCandid.Name = "lstCandid";
            this.lstCandid.Size = new System.Drawing.Size(205, 147);
            this.lstCandid.TabIndex = 0;
            this.lstCandid.SelectedIndexChanged += new System.EventHandler(this.lstCandid_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 460);
            this.Controls.Add(this.lstCandid);
            this.Controls.Add(this.gpNote);
            this.Controls.Add(this.AddDate);
            this.Controls.Add(this.gpBoxDateLimite);
            this.Controls.Add(this.gpBoxAdd);
            this.Controls.Add(this.AddCrit);
            this.Controls.Add(this.gpBoxMod);
            this.Controls.Add(this.lstCrit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOffre);
            this.Name = "Form1";
            this.gpBoxMod.ResumeLayout(false);
            this.gpBoxMod.PerformLayout();
            this.gpBoxAdd.ResumeLayout(false);
            this.gpBoxAdd.PerformLayout();
            this.gpBoxDateLimite.ResumeLayout(false);
            this.gpNote.ResumeLayout(false);
            this.gpNote.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOffre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModCrit;
        private System.Windows.Forms.ListBox lstCrit;
        private System.Windows.Forms.TextBox txtBoxCritMod;
        private System.Windows.Forms.TextBox txtBoxCritCoefMod;
        private System.Windows.Forms.GroupBox gpBoxMod;
        private System.Windows.Forms.Button AddCrit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpBoxAdd;
        private System.Windows.Forms.ComboBox comboBoxCritAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddCrit;
        private System.Windows.Forms.TextBox txtBoxCritCoefAdd;
        private System.Windows.Forms.Button btnSuppCrit;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox gpBoxDateLimite;
        private System.Windows.Forms.Button btnDateLimite;
        private System.Windows.Forms.Button AddDate;
        private System.Windows.Forms.GroupBox gpNote;
        private System.Windows.Forms.ListBox lstCandid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxCrit;
        private System.Windows.Forms.RadioButton radBtnNote5;
        private System.Windows.Forms.RadioButton radBtnNote4;
        private System.Windows.Forms.RadioButton radBtnNote3;
        private System.Windows.Forms.RadioButton radBtnNote2;
        private System.Windows.Forms.RadioButton radBtnNote1;
        private System.Windows.Forms.RadioButton radBtnNote0;
        private System.Windows.Forms.Button btnNoter;
    }
}

