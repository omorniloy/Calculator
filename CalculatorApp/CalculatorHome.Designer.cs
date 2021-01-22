namespace CalculatorApp
{
    partial class CalculatorHome
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
            this.FirstTextBox = new System.Windows.Forms.TextBox();
            this.SecondTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SubButton = new System.Windows.Forms.Button();
            this.MulButton = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // FirstTextBox
            // 
            this.FirstTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FirstTextBox.Location = new System.Drawing.Point(332, 32);
            this.FirstTextBox.Name = "FirstTextBox";
            this.FirstTextBox.Size = new System.Drawing.Size(200, 26);
            this.FirstTextBox.TabIndex = 3;
            this.FirstTextBox.TextChanged += new System.EventHandler(this.FirstTextBox_TextChanged);
            // 
            // SecondTextBox
            // 
            this.SecondTextBox.Location = new System.Drawing.Point(332, 105);
            this.SecondTextBox.Name = "SecondTextBox";
            this.SecondTextBox.Size = new System.Drawing.Size(200, 26);
            this.SecondTextBox.TabIndex = 4;
            this.SecondTextBox.TextChanged += new System.EventHandler(this.SecondTextBox_TextChanged);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(332, 229);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(200, 26);
            this.ResultTextBox.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddButton.Location = new System.Drawing.Point(306, 176);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(79, 26);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(332, 291);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 18);
            this.ErrorLabel.TabIndex = 7;
            // 
            // SubButton
            // 
            this.SubButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SubButton.Location = new System.Drawing.Point(391, 176);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(79, 26);
            this.SubButton.TabIndex = 6;
            this.SubButton.Text = "Sub";
            this.SubButton.UseVisualStyleBackColor = false;
            this.SubButton.Click += new System.EventHandler(this.SubButton_Click);
            // 
            // MulButton
            // 
            this.MulButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MulButton.Location = new System.Drawing.Point(476, 176);
            this.MulButton.Name = "MulButton";
            this.MulButton.Size = new System.Drawing.Size(79, 26);
            this.MulButton.TabIndex = 6;
            this.MulButton.Text = "Mul";
            this.MulButton.UseVisualStyleBackColor = false;
            this.MulButton.Click += new System.EventHandler(this.MulButton_Click);
            // 
            // DivButton
            // 
            this.DivButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DivButton.Location = new System.Drawing.Point(561, 176);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(79, 26);
            this.DivButton.TabIndex = 6;
            this.DivButton.Text = "Div";
            this.DivButton.UseVisualStyleBackColor = false;
            this.DivButton.Click += new System.EventHandler(this.DivButton_Click);
            // 
            // CalculatorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 316);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.DivButton);
            this.Controls.Add(this.MulButton);
            this.Controls.Add(this.SubButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.SecondTextBox);
            this.Controls.Add(this.FirstTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalculatorHome";
            this.Text = "My Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstTextBox;
        private System.Windows.Forms.TextBox SecondTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button SubButton;
        private System.Windows.Forms.Button MulButton;
        private System.Windows.Forms.Button DivButton;
    }
}

