namespace SimpleCalculator
{
    partial class Form1
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
            this.addButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 183);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(103, 183);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(75, 23);
            this.subButton.TabIndex = 1;
            this.subButton.Text = "Subtract";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // divButton
            // 
            this.divButton.Location = new System.Drawing.Point(265, 183);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(75, 23);
            this.divButton.TabIndex = 2;
            this.divButton.Text = "Divide";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // mulButton
            // 
            this.mulButton.Location = new System.Drawing.Point(184, 183);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(75, 23);
            this.mulButton.TabIndex = 3;
            this.mulButton.Text = "Multiply";
            this.mulButton.UseVisualStyleBackColor = true;
            this.mulButton.Click += new System.EventHandler(this.mulButton_Click);
            // 
            // firstTextBox
            // 
            this.firstTextBox.Location = new System.Drawing.Point(121, 22);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(181, 20);
            this.firstTextBox.TabIndex = 4;
            this.firstTextBox.TextChanged += new System.EventHandler(this.firstTextBox_TextChanged);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(121, 100);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(181, 20);
            this.resultTextBox.TabIndex = 5;
            // 
            // secondTextBox
            // 
            this.secondTextBox.Location = new System.Drawing.Point(121, 60);
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(181, 20);
            this.secondTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Second number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondTextBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.firstTextBox);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Second number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

