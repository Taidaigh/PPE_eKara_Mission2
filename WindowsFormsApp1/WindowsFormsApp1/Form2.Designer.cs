namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCritAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBoxCritAdd = new System.Windows.Forms.ComboBox();
            this.numUpCoefAdd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numUpCoefMod = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCritMod = new System.Windows.Forms.Button();
            this.txtCritmodif = new System.Windows.Forms.TextBox();
            this.GridViewCrit = new System.Windows.Forms.DataGridView();
            this.critere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpCoefAdd)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpCoefMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCrit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des critères de l\'offre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Critère :";
            // 
            // btnCritAdd
            // 
            this.btnCritAdd.Enabled = false;
            this.btnCritAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCritAdd.Location = new System.Drawing.Point(287, 135);
            this.btnCritAdd.Name = "btnCritAdd";
            this.btnCritAdd.Size = new System.Drawing.Size(87, 37);
            this.btnCritAdd.TabIndex = 4;
            this.btnCritAdd.Text = "Valider";
            this.btnCritAdd.UseVisualStyleBackColor = true;
            this.btnCritAdd.Click += new System.EventHandler(this.btnCritAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboBoxCritAdd);
            this.groupBox1.Controls.Add(this.numUpCoefAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCritAdd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(265, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 191);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter un critère";
            // 
            // ComboBoxCritAdd
            // 
            this.ComboBoxCritAdd.FormattingEnabled = true;
            this.ComboBoxCritAdd.Location = new System.Drawing.Point(23, 93);
            this.ComboBoxCritAdd.Name = "ComboBoxCritAdd";
            this.ComboBoxCritAdd.Size = new System.Drawing.Size(164, 24);
            this.ComboBoxCritAdd.TabIndex = 8;
            // 
            // numUpCoefAdd
            // 
            this.numUpCoefAdd.Location = new System.Drawing.Point(231, 93);
            this.numUpCoefAdd.Name = "numUpCoefAdd";
            this.numUpCoefAdd.Size = new System.Drawing.Size(143, 23);
            this.numUpCoefAdd.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Coefficient du critère :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numUpCoefMod);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnCritMod);
            this.groupBox2.Controls.Add(this.txtCritmodif);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(265, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 191);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modification du critère sélectionné";
            // 
            // numUpCoefMod
            // 
            this.numUpCoefMod.Enabled = false;
            this.numUpCoefMod.Location = new System.Drawing.Point(231, 93);
            this.numUpCoefMod.Name = "numUpCoefMod";
            this.numUpCoefMod.Size = new System.Drawing.Size(143, 23);
            this.numUpCoefMod.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Coefficient du critère :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Critère :";
            // 
            // btnCritMod
            // 
            this.btnCritMod.Enabled = false;
            this.btnCritMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCritMod.Location = new System.Drawing.Point(287, 135);
            this.btnCritMod.Name = "btnCritMod";
            this.btnCritMod.Size = new System.Drawing.Size(87, 37);
            this.btnCritMod.TabIndex = 4;
            this.btnCritMod.Text = "Modifier";
            this.btnCritMod.UseVisualStyleBackColor = true;
            this.btnCritMod.Click += new System.EventHandler(this.btnCritMod_Click);
            // 
            // txtCritmodif
            // 
            this.txtCritmodif.Enabled = false;
            this.txtCritmodif.Location = new System.Drawing.Point(23, 92);
            this.txtCritmodif.Name = "txtCritmodif";
            this.txtCritmodif.Size = new System.Drawing.Size(164, 23);
            this.txtCritmodif.TabIndex = 3;
            // 
            // GridViewCrit
            // 
            this.GridViewCrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCrit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.critere,
            this.Coef});
            this.GridViewCrit.Location = new System.Drawing.Point(12, 70);
            this.GridViewCrit.Name = "GridViewCrit";
            this.GridViewCrit.ReadOnly = true;
            this.GridViewCrit.Size = new System.Drawing.Size(240, 317);
            this.GridViewCrit.TabIndex = 7;
            this.GridViewCrit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // critere
            // 
            this.critere.HeaderText = "Critère";
            this.critere.Name = "critere";
            this.critere.ReadOnly = true;
            this.critere.Width = 150;
            // 
            // Coef
            // 
            this.Coef.HeaderText = "Coef";
            this.Coef.Name = "Coef";
            this.Coef.ReadOnly = true;
            this.Coef.Width = 47;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridViewCrit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpCoefAdd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpCoefMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCrit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCritAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numUpCoefAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numUpCoefMod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCritMod;
        private System.Windows.Forms.TextBox txtCritmodif;
        private System.Windows.Forms.DataGridView GridViewCrit;
        private System.Windows.Forms.DataGridViewTextBoxColumn critere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coef;
        private System.Windows.Forms.ComboBox ComboBoxCritAdd;
    }
}