namespace shef_kuhar
{
    partial class MenuForm
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
            this.recipesComboBox = new System.Windows.Forms.ComboBox();
            this.recipesDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.showAllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // recipesComboBox
            // 
            this.recipesComboBox.FormattingEnabled = true;
            this.recipesComboBox.Location = new System.Drawing.Point(21, 76);
            this.recipesComboBox.Name = "recipesComboBox";
            this.recipesComboBox.Size = new System.Drawing.Size(155, 24);
            this.recipesComboBox.TabIndex = 0;
            this.recipesComboBox.SelectedIndexChanged += new System.EventHandler(this.recipesComboBox_SelectedIndexChanged);
            // 
            // recipesDataGridView
            // 
            this.recipesDataGridView.AllowUserToAddRows = false;
            this.recipesDataGridView.AllowUserToDeleteRows = false;
            this.recipesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipesDataGridView.Location = new System.Drawing.Point(251, 68);
            this.recipesDataGridView.Name = "recipesDataGridView";
            this.recipesDataGridView.ReadOnly = true;
            this.recipesDataGridView.RowHeadersWidth = 51;
            this.recipesDataGridView.RowTemplate.Height = 24;
            this.recipesDataGridView.Size = new System.Drawing.Size(835, 312);
            this.recipesDataGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Рецепт";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(41, 195);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Швидко готуються";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(41, 250);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(102, 29);
            this.showAllButton.TabIndex = 5;
            this.showAllButton.Text = "Показати всі";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 482);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recipesDataGridView);
            this.Controls.Add(this.recipesComboBox);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма меню";
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox recipesComboBox;
        private System.Windows.Forms.DataGridView recipesDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button showAllButton;
    }
}