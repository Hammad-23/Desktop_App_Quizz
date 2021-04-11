
namespace Quizz_App
{
    partial class CompSci
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
            this.lblQ = new System.Windows.Forms.Label();
            this.btnOpt1 = new System.Windows.Forms.Button();
            this.btnOpt2 = new System.Windows.Forms.Button();
            this.btnOpt3 = new System.Windows.Forms.Button();
            this.btnOpt4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.Location = new System.Drawing.Point(554, 104);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(113, 40);
            this.lblQ.TabIndex = 0;
            this.lblQ.Text = "label1";
            // 
            // btnOpt1
            // 
            this.btnOpt1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpt1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpt1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOpt1.Location = new System.Drawing.Point(54, 291);
            this.btnOpt1.Name = "btnOpt1";
            this.btnOpt1.Size = new System.Drawing.Size(416, 71);
            this.btnOpt1.TabIndex = 1;
            this.btnOpt1.Text = "button1";
            this.btnOpt1.UseVisualStyleBackColor = false;
            this.btnOpt1.Click += new System.EventHandler(this.btnOpt1_Click);
            // 
            // btnOpt2
            // 
            this.btnOpt2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpt2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpt2.Location = new System.Drawing.Point(815, 291);
            this.btnOpt2.Name = "btnOpt2";
            this.btnOpt2.Size = new System.Drawing.Size(416, 71);
            this.btnOpt2.TabIndex = 2;
            this.btnOpt2.Text = "button2";
            this.btnOpt2.UseVisualStyleBackColor = false;
            // 
            // btnOpt3
            // 
            this.btnOpt3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpt3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpt3.Location = new System.Drawing.Point(54, 462);
            this.btnOpt3.Name = "btnOpt3";
            this.btnOpt3.Size = new System.Drawing.Size(416, 71);
            this.btnOpt3.TabIndex = 3;
            this.btnOpt3.Text = "button3";
            this.btnOpt3.UseVisualStyleBackColor = false;
            // 
            // btnOpt4
            // 
            this.btnOpt4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpt4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpt4.Location = new System.Drawing.Point(815, 462);
            this.btnOpt4.Name = "btnOpt4";
            this.btnOpt4.Size = new System.Drawing.Size(416, 71);
            this.btnOpt4.TabIndex = 4;
            this.btnOpt4.Text = "button4";
            this.btnOpt4.UseVisualStyleBackColor = false;
            // 
            // CompSci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1291, 662);
            this.Controls.Add(this.btnOpt4);
            this.Controls.Add(this.btnOpt3);
            this.Controls.Add(this.btnOpt2);
            this.Controls.Add(this.btnOpt1);
            this.Controls.Add(this.lblQ);
            this.MaximizeBox = false;
            this.Name = "CompSci";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CompSci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Button btnOpt1;
        private System.Windows.Forms.Button btnOpt2;
        private System.Windows.Forms.Button btnOpt3;
        private System.Windows.Forms.Button btnOpt4;
    }
}