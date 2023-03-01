namespace multiple_choice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAns1 = new System.Windows.Forms.Button();
            this.btnAns2 = new System.Windows.Forms.Button();
            this.btnAns3 = new System.Windows.Forms.Button();
            this.btnAns4 = new System.Windows.Forms.Button();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.btnAnsSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAns1
            // 
            this.btnAns1.Location = new System.Drawing.Point(56, 53);
            this.btnAns1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAns1.Name = "btnAns1";
            this.btnAns1.Size = new System.Drawing.Size(78, 20);
            this.btnAns1.TabIndex = 0;
            this.btnAns1.Text = "btnAns1";
            this.btnAns1.UseVisualStyleBackColor = true;
            // 
            // btnAns2
            // 
            this.btnAns2.Location = new System.Drawing.Point(371, 53);
            this.btnAns2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAns2.Name = "btnAns2";
            this.btnAns2.Size = new System.Drawing.Size(78, 20);
            this.btnAns2.TabIndex = 1;
            this.btnAns2.Text = "btnAns2";
            this.btnAns2.UseVisualStyleBackColor = true;
            // 
            // btnAns3
            // 
            this.btnAns3.Location = new System.Drawing.Point(56, 150);
            this.btnAns3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAns3.Name = "btnAns3";
            this.btnAns3.Size = new System.Drawing.Size(78, 20);
            this.btnAns3.TabIndex = 2;
            this.btnAns3.Text = "btnAns3";
            this.btnAns3.UseVisualStyleBackColor = true;
            // 
            // btnAns4
            // 
            this.btnAns4.Location = new System.Drawing.Point(371, 150);
            this.btnAns4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAns4.Name = "btnAns4";
            this.btnAns4.Size = new System.Drawing.Size(78, 20);
            this.btnAns4.TabIndex = 3;
            this.btnAns4.Text = "btnAns4";
            this.btnAns4.UseVisualStyleBackColor = true;
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Location = new System.Drawing.Point(223, 105);
            this.lblQuestionText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(72, 15);
            this.lblQuestionText.TabIndex = 4;
            this.lblQuestionText.Text = "Place holder\r\n";
            // 
            // btnAnsSubmit
            // 
            this.btnAnsSubmit.Location = new System.Drawing.Point(220, 221);
            this.btnAnsSubmit.Name = "btnAnsSubmit";
            this.btnAnsSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnAnsSubmit.TabIndex = 5;
            this.btnAnsSubmit.Text = "Submit";
            this.btnAnsSubmit.UseVisualStyleBackColor = true;
            this.btnAnsSubmit.Click += new System.EventHandler(this.btnAnsSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.btnAnsSubmit);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.btnAns4);
            this.Controls.Add(this.btnAns3);
            this.Controls.Add(this.btnAns2);
            this.Controls.Add(this.btnAns1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAns1;
        private System.Windows.Forms.Button btnAns2;
        private System.Windows.Forms.Button btnAns3;
        private System.Windows.Forms.Button btnAns4;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Button btnAnsSubmit;
    }
}
