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
            this.gpBoxAdd = new System.Windows.Forms.GroupBox();
            this.comboBoxCritAdd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddCrit = new System.Windows.Forms.Button();
            this.txtBoxCritCoefAdd = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnDateLimite = new System.Windows.Forms.Button();
            this.lstCandid = new System.Windows.Forms.ListBox();
            this.gpBoxEval = new System.Windows.Forms.GroupBox();
            this.numUpDownBonusMalus = new System.Windows.Forms.NumericUpDown();
            this.richTextBoxCom = new System.Windows.Forms.RichTextBox();
            this.btnEval = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.dataGridViewReu = new System.Windows.Forms.DataGridView();
            this.colCandid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabOff = new System.Windows.Forms.TabPage();
            this.btnReu = new System.Windows.Forms.Button();
            this.dataGridViewCrit = new System.Windows.Forms.DataGridView();
            this.colCrit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCoef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpBoxDateLimite = new System.Windows.Forms.GroupBox();
            this.tabNot = new System.Windows.Forms.TabPage();
            this.lstOffreNoter = new System.Windows.Forms.ListBox();
            this.dataGridViewCritNote = new System.Windows.Forms.DataGridView();
            this.columnCrit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabReu = new System.Windows.Forms.TabPage();
            this.btnVerr = new System.Windows.Forms.Button();
            this.gpBoxAdd.SuspendLayout();
            this.gpBoxEval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBonusMalus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReu)).BeginInit();
            this.tabCtrl.SuspendLayout();
            this.tabOff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrit)).BeginInit();
            this.gpBoxDateLimite.SuspendLayout();
            this.tabNot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCritNote)).BeginInit();
            this.tabReu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOffre
            // 
            this.lstOffre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOffre.FormattingEnabled = true;
            this.lstOffre.ItemHeight = 15;
            this.lstOffre.Location = new System.Drawing.Point(3, 7);
            this.lstOffre.Name = "lstOffre";
            this.lstOffre.Size = new System.Drawing.Size(245, 469);
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
            this.label2.Location = new System.Drawing.Point(251, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Critères de l\'offre sélectionnée :";
            // 
            // gpBoxAdd
            // 
            this.gpBoxAdd.Controls.Add(this.comboBoxCritAdd);
            this.gpBoxAdd.Controls.Add(this.label5);
            this.gpBoxAdd.Controls.Add(this.label6);
            this.gpBoxAdd.Controls.Add(this.btnAddCrit);
            this.gpBoxAdd.Controls.Add(this.txtBoxCritCoefAdd);
            this.gpBoxAdd.Enabled = false;
            this.gpBoxAdd.Location = new System.Drawing.Point(260, 183);
            this.gpBoxAdd.Name = "gpBoxAdd";
            this.gpBoxAdd.Size = new System.Drawing.Size(242, 109);
            this.gpBoxAdd.TabIndex = 14;
            this.gpBoxAdd.TabStop = false;
            this.gpBoxAdd.Text = "Ajouter un Critère";
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
            this.label6.Location = new System.Drawing.Point(146, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Coefficient :";
            // 
            // btnAddCrit
            // 
            this.btnAddCrit.Location = new System.Drawing.Point(65, 61);
            this.btnAddCrit.Name = "btnAddCrit";
            this.btnAddCrit.Size = new System.Drawing.Size(113, 39);
            this.btnAddCrit.TabIndex = 5;
            this.btnAddCrit.Text = "Ajouter";
            this.btnAddCrit.UseVisualStyleBackColor = true;
            this.btnAddCrit.Click += new System.EventHandler(this.btnAddCrit_Click);
            // 
            // txtBoxCritCoefAdd
            // 
            this.txtBoxCritCoefAdd.Location = new System.Drawing.Point(149, 35);
            this.txtBoxCritCoefAdd.Name = "txtBoxCritCoefAdd";
            this.txtBoxCritCoefAdd.Size = new System.Drawing.Size(76, 20);
            this.txtBoxCritCoefAdd.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(6, 25);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(230, 20);
            this.dateTimePicker.TabIndex = 101;
            // 
            // btnDateLimite
            // 
            this.btnDateLimite.Location = new System.Drawing.Point(65, 66);
            this.btnDateLimite.Name = "btnDateLimite";
            this.btnDateLimite.Size = new System.Drawing.Size(113, 39);
            this.btnDateLimite.TabIndex = 12;
            this.btnDateLimite.Text = "Modifier";
            this.btnDateLimite.UseVisualStyleBackColor = true;
            this.btnDateLimite.Click += new System.EventHandler(this.btnDateLimite_Click);
            // 
            // lstCandid
            // 
            this.lstCandid.FormattingEnabled = true;
            this.lstCandid.Location = new System.Drawing.Point(261, 6);
            this.lstCandid.Name = "lstCandid";
            this.lstCandid.Size = new System.Drawing.Size(254, 160);
            this.lstCandid.TabIndex = 0;
            this.lstCandid.SelectedIndexChanged += new System.EventHandler(this.lstCandid_SelectedIndexChanged);
            // 
            // gpBoxEval
            // 
            this.gpBoxEval.Controls.Add(this.numUpDownBonusMalus);
            this.gpBoxEval.Controls.Add(this.richTextBoxCom);
            this.gpBoxEval.Controls.Add(this.btnEval);
            this.gpBoxEval.Controls.Add(this.label9);
            this.gpBoxEval.Controls.Add(this.label10);
            this.gpBoxEval.Location = new System.Drawing.Point(259, 275);
            this.gpBoxEval.Name = "gpBoxEval";
            this.gpBoxEval.Size = new System.Drawing.Size(256, 185);
            this.gpBoxEval.TabIndex = 105;
            this.gpBoxEval.TabStop = false;
            this.gpBoxEval.Text = "Noter";
            // 
            // numUpDownBonusMalus
            // 
            this.numUpDownBonusMalus.Location = new System.Drawing.Point(118, 119);
            this.numUpDownBonusMalus.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownBonusMalus.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numUpDownBonusMalus.Name = "numUpDownBonusMalus";
            this.numUpDownBonusMalus.Size = new System.Drawing.Size(120, 20);
            this.numUpDownBonusMalus.TabIndex = 112;
            // 
            // richTextBoxCom
            // 
            this.richTextBoxCom.Location = new System.Drawing.Point(17, 44);
            this.richTextBoxCom.Name = "richTextBoxCom";
            this.richTextBoxCom.Size = new System.Drawing.Size(221, 74);
            this.richTextBoxCom.TabIndex = 111;
            this.richTextBoxCom.Text = "";
            // 
            // btnEval
            // 
            this.btnEval.Location = new System.Drawing.Point(91, 149);
            this.btnEval.Name = "btnEval";
            this.btnEval.Size = new System.Drawing.Size(71, 30);
            this.btnEval.TabIndex = 110;
            this.btnEval.Text = "Valider";
            this.btnEval.UseVisualStyleBackColor = true;
            this.btnEval.Click += new System.EventHandler(this.btnEval_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 103;
            this.label9.Text = "Bonus/malus : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 101;
            this.label10.Text = "Commentaire :";
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(8, 178);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(205, 23);
            this.btnPDF.TabIndex = 106;
            this.btnPDF.Text = "Fiche individuelle";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // dataGridViewReu
            // 
            this.dataGridViewReu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCandid,
            this.colMoy});
            this.dataGridViewReu.Location = new System.Drawing.Point(6, 7);
            this.dataGridViewReu.Name = "dataGridViewReu";
            this.dataGridViewReu.Size = new System.Drawing.Size(473, 150);
            this.dataGridViewReu.TabIndex = 107;
            // 
            // colCandid
            // 
            this.colCandid.HeaderText = "Candidat";
            this.colCandid.Name = "colCandid";
            // 
            // colMoy
            // 
            this.colMoy.HeaderText = "Moyenne";
            this.colMoy.Name = "colMoy";
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabOff);
            this.tabCtrl.Controls.Add(this.tabNot);
            this.tabCtrl.Controls.Add(this.tabReu);
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(529, 508);
            this.tabCtrl.TabIndex = 109;
            // 
            // tabOff
            // 
            this.tabOff.Controls.Add(this.btnVerr);
            this.tabOff.Controls.Add(this.gpBoxAdd);
            this.tabOff.Controls.Add(this.btnReu);
            this.tabOff.Controls.Add(this.dataGridViewCrit);
            this.tabOff.Controls.Add(this.lstOffre);
            this.tabOff.Controls.Add(this.label2);
            this.tabOff.Controls.Add(this.gpBoxDateLimite);
            this.tabOff.Location = new System.Drawing.Point(4, 22);
            this.tabOff.Name = "tabOff";
            this.tabOff.Padding = new System.Windows.Forms.Padding(3);
            this.tabOff.Size = new System.Drawing.Size(521, 482);
            this.tabOff.TabIndex = 0;
            this.tabOff.Text = "Offres";
            this.tabOff.UseVisualStyleBackColor = true;
            // 
            // btnReu
            // 
            this.btnReu.Enabled = false;
            this.btnReu.Location = new System.Drawing.Point(260, 451);
            this.btnReu.Name = "btnReu";
            this.btnReu.Size = new System.Drawing.Size(242, 23);
            this.btnReu.TabIndex = 107;
            this.btnReu.Text = "Réunion";
            this.btnReu.UseVisualStyleBackColor = true;
            this.btnReu.Click += new System.EventHandler(this.btnReu_Click);
            // 
            // dataGridViewCrit
            // 
            this.dataGridViewCrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCrit,
            this.colCoef});
            this.dataGridViewCrit.Enabled = false;
            this.dataGridViewCrit.Location = new System.Drawing.Point(260, 27);
            this.dataGridViewCrit.Name = "dataGridViewCrit";
            this.dataGridViewCrit.Size = new System.Drawing.Size(242, 150);
            this.dataGridViewCrit.TabIndex = 103;
            this.dataGridViewCrit.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCrit_CellEndEdit);
            this.dataGridViewCrit.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewCrit_UserAddedRow);
            this.dataGridViewCrit.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewCrit_UserDeletingRow);
            // 
            // colCrit
            // 
            this.colCrit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCrit.HeaderText = "Critère";
            this.colCrit.Name = "colCrit";
            this.colCrit.ReadOnly = true;
            this.colCrit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colCoef
            // 
            this.colCoef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCoef.HeaderText = "Coeficient";
            this.colCoef.Name = "colCoef";
            // 
            // gpBoxDateLimite
            // 
            this.gpBoxDateLimite.Controls.Add(this.btnDateLimite);
            this.gpBoxDateLimite.Controls.Add(this.dateTimePicker);
            this.gpBoxDateLimite.Enabled = false;
            this.gpBoxDateLimite.Location = new System.Drawing.Point(260, 298);
            this.gpBoxDateLimite.Name = "gpBoxDateLimite";
            this.gpBoxDateLimite.Size = new System.Drawing.Size(242, 111);
            this.gpBoxDateLimite.TabIndex = 102;
            this.gpBoxDateLimite.TabStop = false;
            this.gpBoxDateLimite.Text = "Date Limite";
            // 
            // tabNot
            // 
            this.tabNot.Controls.Add(this.lstOffreNoter);
            this.tabNot.Controls.Add(this.dataGridViewCritNote);
            this.tabNot.Controls.Add(this.lstCandid);
            this.tabNot.Controls.Add(this.gpBoxEval);
            this.tabNot.Location = new System.Drawing.Point(4, 22);
            this.tabNot.Name = "tabNot";
            this.tabNot.Padding = new System.Windows.Forms.Padding(3);
            this.tabNot.Size = new System.Drawing.Size(521, 466);
            this.tabNot.TabIndex = 2;
            this.tabNot.Text = "Noter";
            this.tabNot.UseVisualStyleBackColor = true;
            // 
            // lstOffreNoter
            // 
            this.lstOffreNoter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOffreNoter.FormattingEnabled = true;
            this.lstOffreNoter.ItemHeight = 15;
            this.lstOffreNoter.Location = new System.Drawing.Point(6, 6);
            this.lstOffreNoter.Name = "lstOffreNoter";
            this.lstOffreNoter.Size = new System.Drawing.Size(245, 454);
            this.lstOffreNoter.TabIndex = 107;
            this.lstOffreNoter.SelectedIndexChanged += new System.EventHandler(this.lstOffreNoter_SelectedIndexChanged);
            // 
            // dataGridViewCritNote
            // 
            this.dataGridViewCritNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCritNote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCrit,
            this.columnNote});
            this.dataGridViewCritNote.Location = new System.Drawing.Point(259, 172);
            this.dataGridViewCritNote.Name = "dataGridViewCritNote";
            this.dataGridViewCritNote.Size = new System.Drawing.Size(256, 97);
            this.dataGridViewCritNote.TabIndex = 106;
            this.dataGridViewCritNote.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCrit_CellEndEdit);
            // 
            // columnCrit
            // 
            this.columnCrit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCrit.HeaderText = "Critère";
            this.columnCrit.Name = "columnCrit";
            this.columnCrit.ReadOnly = true;
            // 
            // columnNote
            // 
            this.columnNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNote.HeaderText = "Note";
            this.columnNote.Name = "columnNote";
            // 
            // tabReu
            // 
            this.tabReu.Controls.Add(this.dataGridViewReu);
            this.tabReu.Controls.Add(this.btnPDF);
            this.tabReu.Location = new System.Drawing.Point(4, 22);
            this.tabReu.Name = "tabReu";
            this.tabReu.Padding = new System.Windows.Forms.Padding(3);
            this.tabReu.Size = new System.Drawing.Size(521, 466);
            this.tabReu.TabIndex = 3;
            this.tabReu.Text = "Réunion";
            this.tabReu.UseVisualStyleBackColor = true;
            // 
            // btnVerr
            // 
            this.btnVerr.Enabled = false;
            this.btnVerr.Location = new System.Drawing.Point(260, 422);
            this.btnVerr.Name = "btnVerr";
            this.btnVerr.Size = new System.Drawing.Size(242, 23);
            this.btnVerr.TabIndex = 108;
            this.btnVerr.Text = "Verrouiller les critères";
            this.btnVerr.UseVisualStyleBackColor = true;
            this.btnVerr.Click += new System.EventHandler(this.btnVerr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 508);
            this.Controls.Add(this.tabCtrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.gpBoxAdd.ResumeLayout(false);
            this.gpBoxAdd.PerformLayout();
            this.gpBoxEval.ResumeLayout(false);
            this.gpBoxEval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBonusMalus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReu)).EndInit();
            this.tabCtrl.ResumeLayout(false);
            this.tabOff.ResumeLayout(false);
            this.tabOff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrit)).EndInit();
            this.gpBoxDateLimite.ResumeLayout(false);
            this.tabNot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCritNote)).EndInit();
            this.tabReu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOffre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpBoxAdd;
        private System.Windows.Forms.ComboBox comboBoxCritAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddCrit;
        private System.Windows.Forms.TextBox txtBoxCritCoefAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnDateLimite;
        private System.Windows.Forms.ListBox lstCandid;
        private System.Windows.Forms.GroupBox gpBoxEval;
        private System.Windows.Forms.NumericUpDown numUpDownBonusMalus;
        private System.Windows.Forms.RichTextBox richTextBoxCom;
        private System.Windows.Forms.Button btnEval;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.DataGridView dataGridViewReu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCandid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoy;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabOff;
        private System.Windows.Forms.TabPage tabNot;
        private System.Windows.Forms.TabPage tabReu;
        private System.Windows.Forms.GroupBox gpBoxDateLimite;
        private System.Windows.Forms.DataGridView dataGridViewCrit;
        private System.Windows.Forms.Button btnReu;
        private System.Windows.Forms.DataGridView dataGridViewCritNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCoef;
        private System.Windows.Forms.ListBox lstOffreNoter;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCrit;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNote;
        private System.Windows.Forms.Button btnVerr;
    }
}

