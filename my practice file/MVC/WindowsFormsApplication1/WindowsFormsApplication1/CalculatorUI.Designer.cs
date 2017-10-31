namespace WindowsFormsApplication1
{
    partial class CalculatorUI
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
            this.FirstNumbertextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondNumbertextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubstractButon = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Number";
            // 
            // FirstNumbertextBox
            // 
            this.FirstNumbertextBox.Location = new System.Drawing.Point(86, 12);
            this.FirstNumbertextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FirstNumbertextBox.Name = "FirstNumbertextBox";
            this.FirstNumbertextBox.Size = new System.Drawing.Size(99, 20);
            this.FirstNumbertextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Second Number";
            // 
            // SecondNumbertextbox
            // 
            this.SecondNumbertextbox.Location = new System.Drawing.Point(86, 61);
            this.SecondNumbertextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SecondNumbertextbox.Name = "SecondNumbertextbox";
            this.SecondNumbertextbox.Size = new System.Drawing.Size(99, 20);
            this.SecondNumbertextbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Result";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(85, 107);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(99, 20);
            this.ResultTextBox.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(28, 161);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(62, 27);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubstractButon
            // 
            this.SubstractButon.Location = new System.Drawing.Point(139, 161);
            this.SubstractButon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SubstractButon.Name = "SubstractButon";
            this.SubstractButon.Size = new System.Drawing.Size(62, 27);
            this.SubstractButon.TabIndex = 4;
            this.SubstractButon.Text = "Substrct";
            this.SubstractButon.UseVisualStyleBackColor = true;
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(28, 194);
            this.Multiplication.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(62, 27);
            this.Multiplication.TabIndex = 5;
            this.Multiplication.Text = "Multiplication";
            this.Multiplication.UseVisualStyleBackColor = true;
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(139, 194);
            this.Divide.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(62, 27);
            this.Divide.TabIndex = 6;
            this.Divide.Text = "DivideButton";
            this.Divide.UseVisualStyleBackColor = true;
            // 
            // CalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 301);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.SubstractButon);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecondNumbertextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNumbertextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "CalculatorUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculatorUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNumbertextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SecondNumbertextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubstractButon;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Divide;
    }
}

