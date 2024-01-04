namespace WindowsFormsApp3
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtEnterNumber = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(381, 252);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 51);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.CheckNumber);
            // 
            // txtEnterNumber
            // 
            this.txtEnterNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterNumber.Location = new System.Drawing.Point(381, 174);
            this.txtEnterNumber.Name = "txtEnterNumber";
            this.txtEnterNumber.Size = new System.Drawing.Size(177, 31);
            this.txtEnterNumber.TabIndex = 1;
            this.txtEnterNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(41, 59);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(868, 31);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "I have a number between 1 and 1000--can you guess my number?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(482, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtEnterNumber);
            this.Controls.Add(this.btnCheck);
            this.Name = "Form1";
            this.Text = "Number Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtEnterNumber;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button button1;
    }
}

