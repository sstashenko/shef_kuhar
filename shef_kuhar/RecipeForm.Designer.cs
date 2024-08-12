namespace shef_kuhar
{
    partial class RecipeForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ingredientsTextBox = new System.Windows.Forms.TextBox();
            this.instructionsTextBox = new System.Windows.Forms.TextBox();
            this.preparationTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.servingsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.preparationTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servingsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Інгрідієнти";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Інструкція \r\nприготування";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Час \r\nприготування (хв)";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(281, 82);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // ingredientsTextBox
            // 
            this.ingredientsTextBox.Location = new System.Drawing.Point(281, 121);
            this.ingredientsTextBox.Name = "ingredientsTextBox";
            this.ingredientsTextBox.Size = new System.Drawing.Size(100, 22);
            this.ingredientsTextBox.TabIndex = 5;
            // 
            // instructionsTextBox
            // 
            this.instructionsTextBox.Location = new System.Drawing.Point(281, 174);
            this.instructionsTextBox.Name = "instructionsTextBox";
            this.instructionsTextBox.Size = new System.Drawing.Size(100, 22);
            this.instructionsTextBox.TabIndex = 6;
            // 
            // preparationTimeNumericUpDown
            // 
            this.preparationTimeNumericUpDown.Location = new System.Drawing.Point(314, 245);
            this.preparationTimeNumericUpDown.Name = "preparationTimeNumericUpDown";
            this.preparationTimeNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.preparationTimeNumericUpDown.TabIndex = 7;
            this.preparationTimeNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(393, 337);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(116, 23);
            this.viewButton.TabIndex = 9;
            this.viewButton.Text = "Переглянути";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Кількість порцій";
            // 
            // servingsNumericUpDown
            // 
            this.servingsNumericUpDown.Location = new System.Drawing.Point(292, 202);
            this.servingsNumericUpDown.Name = "servingsNumericUpDown";
            this.servingsNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.servingsNumericUpDown.TabIndex = 11;
            this.servingsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.servingsNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.preparationTimeNumericUpDown);
            this.Controls.Add(this.instructionsTextBox);
            this.Controls.Add(this.ingredientsTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RecipeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати рецепти";
            ((System.ComponentModel.ISupportInitialize)(this.preparationTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servingsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ingredientsTextBox;
        private System.Windows.Forms.TextBox instructionsTextBox;
        private System.Windows.Forms.NumericUpDown preparationTimeNumericUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown servingsNumericUpDown;
    }
}