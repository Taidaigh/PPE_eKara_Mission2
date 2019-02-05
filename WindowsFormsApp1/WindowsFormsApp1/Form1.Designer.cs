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
            this.dataGridViewCrit = new System.Windows.Forms.DataGridView();
            this.colCrit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCoef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpBoxDateLimite = new System.Windows.Forms.GroupBox();
            this.tabCrit = new System.Windows.Forms.TabPage();
            this.tabNot = new System.Windows.Forms.TabPage();
            this.tabReu = new System.Windows.Forms.TabPage();
            this.btnReu = new System.Windows.Forms.Button();
            this.gpBoxAdd.SuspendLayout();
            this.gpNote.SuspendLayout();
            this.gpBoxEval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBonusMalus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReu)).BeginInit();
            this.tabCtrl.SuspendLayout();
            this.tabOff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrit)).BeginInit();
            this.gpBoxDateLimite.SuspendLayout();
            this.tabCrit.SuspendLayout();
            this.tabNot.SuspendLayout();
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
            this.lstOffre.Size = new System.Drawing.Size(245, 334);
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
            this.gpBoxAdd.Location = new System.Drawing.Point(11, 22);
            this.gpBoxAdd.Name = "gpBoxAdd";
            this.gpBoxAdd.Size = new System.Drawing.Size(205, 151);
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
            this.gpNote.Location = new System.Drawing.Point(8, 7);
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
            this.lstCandid.Location = new System.Drawing.Point(262, 15);
            this.lstCandid.Name = "lstCandid";
            this.lstCandid.Size = new System.Drawing.Size(205, 147);
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
            this.gpBoxEval.Location = new System.Drawing.Point(8, 180);
            this.gpBoxEval.Name = "gpBoxEval";
            this.gpBoxEval.Size = new System.Drawing.Size(276, 170);
            this.gpBoxEval.TabIndex = 105;
            this.gpBoxEval.TabStop = false;
            this.gpBoxEval.Text = "Noter";
            // 
            // numUpDownBonusMalus
            // 
            this.numUpDownBonusMalus.Location = new System.Drawing.Point(143, 146);
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
            this.richTextBoxCom.Size = new System.Drawing.Size(246, 96);
            this.richTextBoxCom.TabIndex = 111;
            this.richTextBoxCom.Text = "";
            // 
            // btnEval
            // 
            this.btnEval.Location = new System.Drawing.Point(105, 172);
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
            this.label9.Location = new System.Drawing.Point(17, 146);
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
            this.dataGridViewReu.Enabled = false;
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
            this.tabCtrl.Controls.Add(this.tabCrit);
            this.tabCtrl.Controls.Add(this.tabNot);
            this.tabCtrl.Controls.Add(this.tabReu);
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(547, 380);
            this.tabCtrl.TabIndex = 109;
            this.tabCtrl.SelectedIndexChanged += new System.EventHandler(this.tabCtrl_SelectedIndexChanged);
            // 
            // tabOff
            // 
            this.tabOff.Controls.Add(this.btnReu);
            this.tabOff.Controls.Add(this.dataGridViewCrit);
            this.tabOff.Controls.Add(this.lstOffre);
            this.tabOff.Controls.Add(this.label2);
            this.tabOff.Controls.Add(this.gpBoxDateLimite);
            this.tabOff.Location = new System.Drawing.Point(4, 22);
            this.tabOff.Name = "tabOff";
            this.tabOff.Padding = new System.Windows.Forms.Padding(3);
            this.tabOff.Size = new System.Drawing.Size(539, 354);
            this.tabOff.TabIndex = 0;
            this.tabOff.Text = "Offres";
            this.tabOff.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCrit
            // 
            this.dataGridViewCrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCrit,
            this.colCoef});
            this.dataGridViewCrit.Location = new System.Drawing.Point(260, 27);
            this.dataGridViewCrit.Name = "dataGridViewCrit";
            this.dataGridViewCrit.Size = new System.Drawing.Size(242, 150);
            this.dataGridViewCrit.TabIndex = 103;
            this.dataGridViewCrit.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCrit_CellEndEdit);
            this.dataGridViewCrit.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewCrit_UserAddedRow);
            this.dataGridViewCrit.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewCrit_UserDeletingRow);
            this.dataGridViewCrit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewCrit_KeyPress);
            // 
            // colCrit
            // 
            this.colCrit.HeaderText = "Critère";
            this.colCrit.Name = "colCrit";
            this.colCrit.ReadOnly = true;
            this.colCrit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colCoef
            // 
            this.colCoef.HeaderText = "Coeficient";
            this.colCoef.Name = "colCoef";
            // 
            // gpBoxDateLimite
            // 
            this.gpBoxDateLimite.Controls.Add(this.btnDateLimite);
            this.gpBoxDateLimite.Controls.Add(this.dateTimePicker);
            this.gpBoxDateLimite.Location = new System.Drawing.Point(260, 183);
            this.gpBoxDateLimite.Name = "gpBoxDateLimite";
            this.gpBoxDateLimite.Size = new System.Drawing.Size(242, 111);
            this.gpBoxDateLimite.TabIndex = 102;
            this.gpBoxDateLimite.TabStop = false;
            this.gpBoxDateLimite.Text = "Date Limite";
            // 
            // tabCrit
            // 
            this.tabCrit.Controls.Add(this.gpBoxAdd);
            this.tabCrit.Location = new System.Drawing.Point(4, 22);
            this.tabCrit.Name = "tabCrit";
            this.tabCrit.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrit.Size = new System.Drawing.Size(539, 354);
            this.tabCrit.TabIndex = 1;
            this.tabCrit.Text = "Critères";
            this.tabCrit.UseVisualStyleBackColor = true;
            // 
            // tabNot
            // 
            this.tabNot.Controls.Add(this.gpNote);
            this.tabNot.Controls.Add(this.lstCandid);
            this.tabNot.Controls.Add(this.gpBoxEval);
            this.tabNot.Location = new System.Drawing.Point(4, 22);
            this.tabNot.Name = "tabNot";
            this.tabNot.Padding = new System.Windows.Forms.Padding(3);
            this.tabNot.Size = new System.Drawing.Size(539, 354);
            this.tabNot.TabIndex = 2;
            this.tabNot.Text = "Noter";
            this.tabNot.UseVisualStyleBackColor = true;
            // 
            // tabReu
            // 
            this.tabReu.Controls.Add(this.dataGridViewReu);
            this.tabReu.Controls.Add(this.btnPDF);
            this.tabReu.Location = new System.Drawing.Point(4, 22);
            this.tabReu.Name = "tabReu";
            this.tabReu.Padding = new System.Windows.Forms.Padding(3);
            this.tabReu.Size = new System.Drawing.Size(539, 354);
            this.tabReu.TabIndex = 3;
            this.tabReu.Text = "Réunion";
            this.tabReu.UseVisualStyleBackColor = true;
            // 
            // btnReu
            // 
            this.btnReu.Location = new System.Drawing.Point(281, 300);
            this.btnReu.Name = "btnReu";
            this.btnReu.Size = new System.Drawing.Size(205, 23);
            this.btnReu.TabIndex = 107;
            this.btnReu.Text = "Réunion";
            this.btnReu.UseVisualStyleBackColor = true;
            this.btnReu.Click += new System.EventHandler(this.btnReu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 380);
            this.Controls.Add(this.tabCtrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.gpBoxAdd.ResumeLayout(false);
            this.gpBoxAdd.PerformLayout();
            this.gpNote.ResumeLayout(false);
            this.gpNote.PerformLayout();
            this.gpBoxEval.ResumeLayout(false);
            this.gpBoxEval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBonusMalus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReu)).EndInit();
            this.tabCtrl.ResumeLayout(false);
            this.tabOff.ResumeLayout(false);
            this.tabOff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrit)).EndInit();
            this.gpBoxDateLimite.ResumeLayout(false);
            this.tabCrit.ResumeLayout(false);
            this.tabNot.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabCrit;
        private System.Windows.Forms.TabPage tabNot;
        private System.Windows.Forms.TabPage tabReu;
        private System.Windows.Forms.GroupBox gpBoxDateLimite;
        private System.Windows.Forms.DataGridView dataGridViewCrit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCoef;
        private System.Windows.Forms.Button btnReu;
    }
}

