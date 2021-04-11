
namespace Quizz_App
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblQuizz = new System.Windows.Forms.Label();
            this.btnComp = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quizz_App.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(510, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblQuizz
            // 
            this.lblQuizz.AutoSize = true;
            this.lblQuizz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizz.Location = new System.Drawing.Point(487, 127);
            this.lblQuizz.Name = "lblQuizz";
            this.lblQuizz.Size = new System.Drawing.Size(175, 37);
            this.lblQuizz.TabIndex = 1;
            this.lblQuizz.Text = "Quizz App";
            this.lblQuizz.Click += new System.EventHandler(this.lblQuizz_Click);
            // 
            // btnComp
            // 
            this.btnComp.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComp.Location = new System.Drawing.Point(429, 245);
            this.btnComp.Name = "btnComp";
            this.btnComp.Size = new System.Drawing.Size(276, 52);
            this.btnComp.TabIndex = 2;
            this.btnComp.Text = "Computer Science";
            this.btnComp.UseVisualStyleBackColor = false;
            this.btnComp.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEnglish
            // 
            this.btnEnglish.BackColor = System.Drawing.Color.Green;
            this.btnEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnglish.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnglish.Location = new System.Drawing.Point(429, 322);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(276, 52);
            this.btnEnglish.TabIndex = 3;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = false;
            this.btnEnglish.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.Color.DimGray;
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneral.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeneral.Location = new System.Drawing.Point(429, 402);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(276, 52);
            this.btnGeneral.TabIndex = 4;
            this.btnGeneral.Text = "General Knowledge";
            this.btnGeneral.UseVisualStyleBackColor = false;
            this.btnGeneral.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1149, 560);
            this.Controls.Add(this.btnGeneral);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnComp);
            this.Controls.Add(this.lblQuizz);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQuizz;
        private System.Windows.Forms.Button btnComp;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnGeneral;
    }
}

