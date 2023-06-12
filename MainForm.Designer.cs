namespace Assignment4
{
    partial class MainForm
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
            this.cmbBoxCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.txtBoxDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxRecipes = new System.Windows.Forms.ListBox();
            this.btnEditStart = new System.Windows.Forms.Button();
            this.btnEditFinish = new System.Windows.Forms.Button();
            this.btnDeleate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBoxCategory
            // 
            this.cmbBoxCategory.FormattingEnabled = true;
            this.cmbBoxCategory.Location = new System.Drawing.Point(15, 122);
            this.cmbBoxCategory.Name = "cmbBoxCategory";
            this.cmbBoxCategory.Size = new System.Drawing.Size(112, 28);
            this.cmbBoxCategory.TabIndex = 0;
            this.cmbBoxCategory.Text = "Other";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddRecipe);
            this.groupBox1.Controls.Add(this.txtBoxDescription);
            this.groupBox1.Controls.Add(this.btnAddIngredient);
            this.groupBox1.Controls.Add(this.txtBoxName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbBoxCategory);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 384);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Recipe";
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(6, 310);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(319, 29);
            this.btnAddRecipe.TabIndex = 6;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(6, 156);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(319, 134);
            this.txtBoxDescription.TabIndex = 5;
            this.txtBoxDescription.Text = "";
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(133, 122);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(192, 28);
            this.btnAddIngredient.TabIndex = 4;
            this.btnAddIngredient.Text = "Add ingredient";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(133, 48);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(192, 26);
            this.txtBoxName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of recipe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number of Ingredients";
            // 
            // listBoxRecipes
            // 
            this.listBoxRecipes.ItemHeight = 20;
            this.listBoxRecipes.Location = new System.Drawing.Point(349, 45);
            this.listBoxRecipes.Name = "listBoxRecipes";
            this.listBoxRecipes.Size = new System.Drawing.Size(439, 244);
            this.listBoxRecipes.TabIndex = 6;
            this.listBoxRecipes.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            this.listBoxRecipes.SelectedIndexChanged += new System.EventHandler(this.listBoxRecipes_SelectedIndexChanged);
            // 
            // btnEditStart
            // 
            this.btnEditStart.Location = new System.Drawing.Point(349, 322);
            this.btnEditStart.Name = "btnEditStart";
            this.btnEditStart.Size = new System.Drawing.Size(91, 29);
            this.btnEditStart.TabIndex = 7;
            this.btnEditStart.Text = "Edit-Begin";
            this.btnEditStart.UseVisualStyleBackColor = true;
            this.btnEditStart.Click += new System.EventHandler(this.btnEditStart_Click);
            // 
            // btnEditFinish
            // 
            this.btnEditFinish.Location = new System.Drawing.Point(455, 322);
            this.btnEditFinish.Name = "btnEditFinish";
            this.btnEditFinish.Size = new System.Drawing.Size(99, 29);
            this.btnEditFinish.TabIndex = 8;
            this.btnEditFinish.Text = "Edit-Finish";
            this.btnEditFinish.UseVisualStyleBackColor = true;
            this.btnEditFinish.Click += new System.EventHandler(this.btnEditFinish_Click);
            // 
            // btnDeleate
            // 
            this.btnDeleate.Location = new System.Drawing.Point(570, 322);
            this.btnDeleate.Name = "btnDeleate";
            this.btnDeleate.Size = new System.Drawing.Size(91, 29);
            this.btnDeleate.TabIndex = 9;
            this.btnDeleate.Text = "Delete";
            this.btnDeleate.UseVisualStyleBackColor = true;
            this.btnDeleate.Click += new System.EventHandler(this.btnDeleate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(667, 322);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 29);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear Section";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(430, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Double click on an item for ingredients _cooking instructions";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDeleate);
            this.Controls.Add(this.btnEditFinish);
            this.Controls.Add(this.btnEditStart);
            this.Controls.Add(this.listBoxRecipes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Apu Recipe Book by ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.MaskedTextBox txtBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.RichTextBox txtBoxDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxRecipes;
        private System.Windows.Forms.Button btnEditStart;
        private System.Windows.Forms.Button btnEditFinish;
        private System.Windows.Forms.Button btnDeleate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
    }
}