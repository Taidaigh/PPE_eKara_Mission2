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
            this.btnAddCrit = new System.Windows.Forms.Button();
            this.GridViewCrit = new System.Windows.Forms.DataGridView();
            this.ClmCritere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCoef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstCrit = new System.Windows.Forms.ListBox();
            this.txtBoxCrit = new System.Windows.Forms.TextBox();
            this.txtBoxCritCoef = new System.Windows.Forms.TextBox();
            this.groupBoxCrit = new System.Windows.Forms.GroupBox();
            this.AddCrit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCrit)).BeginInit();
            this.groupBoxCrit.SuspendLayout();
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
            this.lstOffre.TabIndex = 0;
            this.lstOffre.SelectedIndexChanged += new System.EventHandler(this.lstOffre_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
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
            // btnAddCrit
            // 
            this.btnAddCrit.Enabled = false;
            this.btnAddCrit.Location = new System.Drawing.Point(42, 85);
            this.btnAddCrit.Name = "btnAddCrit";
            this.btnAddCrit.Size = new System.Drawing.Size(145, 49);
            this.btnAddCrit.TabIndex = 7;
            this.btnAddCrit.Text = "Modifier";
            this.btnAddCrit.UseVisualStyleBackColor = true;
            this.btnAddCrit.Click += new System.EventHandler(this.btnAddCrit_Click);
            // 
            // GridViewCrit
            // 
            this.GridViewCrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCrit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCritere,
            this.ClmCoef});
            this.GridViewCrit.Enabled = false;
            this.GridViewCrit.Location = new System.Drawing.Point(556, 72);
            this.GridViewCrit.Name = "GridViewCrit";
            this.GridViewCrit.Size = new System.Drawing.Size(243, 150);
            this.GridViewCrit.TabIndex = 8;
            // 
            // ClmCritere
            // 
            this.ClmCritere.HeaderText = "Critere";
            this.ClmCritere.Name = "ClmCritere";
            // 
            // ClmCoef
            // 
            this.ClmCoef.HeaderText = "Coef";
            this.ClmCoef.Name = "ClmCoef";
            // 
            // lstCrit
            // 
            this.lstCrit.FormattingEnabled = true;
            this.lstCrit.Location = new System.Drawing.Point(299, 72);
            this.lstCrit.Name = "lstCrit";
            this.lstCrit.Size = new System.Drawing.Size(205, 147);
            this.lstCrit.TabIndex = 9;
            this.lstCrit.SelectedIndexChanged += new System.EventHandler(this.listCrit_SelectedIndexChanged);
            // 
            // txtBoxCrit
            // 
            this.txtBoxCrit.Enabled = false;
            this.txtBoxCrit.Location = new System.Drawing.Point(10, 49);
            this.txtBoxCrit.Name = "txtBoxCrit";
            this.txtBoxCrit.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCrit.TabIndex = 10;
            // 
            // txtBoxCritCoef
            // 
            this.txtBoxCritCoef.Enabled = false;
            this.txtBoxCritCoef.Location = new System.Drawing.Point(139, 49);
            this.txtBoxCritCoef.Name = "txtBoxCritCoef";
            this.txtBoxCritCoef.Size = new System.Drawing.Size(76, 20);
            this.txtBoxCritCoef.TabIndex = 11;
            this.txtBoxCritCoef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCritCoef_KeyPress);
            // 
            // groupBoxCrit
            // 
            this.groupBoxCrit.Controls.Add(this.btnAddCrit);
            this.groupBoxCrit.Controls.Add(this.txtBoxCrit);
            this.groupBoxCrit.Controls.Add(this.txtBoxCritCoef);
            this.groupBoxCrit.Location = new System.Drawing.Point(289, 281);
            this.groupBoxCrit.Name = "groupBoxCrit";
            this.groupBoxCrit.Size = new System.Drawing.Size(229, 151);
            this.groupBoxCrit.TabIndex = 12;
            this.groupBoxCrit.TabStop = false;
            this.groupBoxCrit.Text = "Modifier/Ajouter un critère";
            // 
            // AddCrit
            // 
            this.AddCrit.Enabled = false;
            this.AddCrit.Location = new System.Drawing.Point(299, 236);
            this.AddCrit.Name = "AddCrit";
            this.AddCrit.Size = new System.Drawing.Size(205, 23);
            this.AddCrit.TabIndex = 13;
            this.AddCrit.Text = "Mode ajouter un critère";
            this.AddCrit.UseVisualStyleBackColor = true;
            this.AddCrit.Click += new System.EventHandler(this.AddCrit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 460);
            this.Controls.Add(this.AddCrit);
            this.Controls.Add(this.groupBoxCrit);
            this.Controls.Add(this.lstCrit);
            this.Controls.Add(this.GridViewCrit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOffre);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCrit)).EndInit();
            this.groupBoxCrit.ResumeLayout(false);
            this.groupBoxCrit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOffre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddCrit;
        private System.Windows.Forms.DataGridView GridViewCrit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCritere;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCoef;
        private System.Windows.Forms.ListBox lstCrit;
        private System.Windows.Forms.TextBox txtBoxCrit;
        private System.Windows.Forms.TextBox txtBoxCritCoef;
        private System.Windows.Forms.GroupBox groupBoxCrit;
        private System.Windows.Forms.Button AddCrit;
    }
}

