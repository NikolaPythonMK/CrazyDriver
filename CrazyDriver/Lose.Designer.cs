
namespace CrazyDriver
{
    partial class Lose
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
            this.scoreEl = new System.Windows.Forms.Label();
            this.bestEl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.continueForEl = new System.Windows.Forms.Label();
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "You Lost!";
            // 
            // scoreEl
            // 
            this.scoreEl.AutoSize = true;
            this.scoreEl.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreEl.Location = new System.Drawing.Point(288, 90);
            this.scoreEl.Name = "scoreEl";
            this.scoreEl.Size = new System.Drawing.Size(191, 62);
            this.scoreEl.TabIndex = 1;
            this.scoreEl.Text = "Score: 0";
            // 
            // bestEl
            // 
            this.bestEl.AutoSize = true;
            this.bestEl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bestEl.Location = new System.Drawing.Point(288, 152);
            this.bestEl.Name = "bestEl";
            this.bestEl.Size = new System.Drawing.Size(130, 54);
            this.bestEl.TabIndex = 2;
            this.bestEl.Text = "Best:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 3;
            // 
            // continueForEl
            // 
            this.continueForEl.AutoSize = true;
            this.continueForEl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.continueForEl.Location = new System.Drawing.Point(209, 243);
            this.continueForEl.Name = "continueForEl";
            this.continueForEl.Size = new System.Drawing.Size(323, 41);
            this.continueForEl.TabIndex = 4;
            this.continueForEl.Text = "Continue for X money?";
            // 
            // yesBtn
            // 
            this.yesBtn.BackColor = System.Drawing.Color.Chartreuse;
            this.yesBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yesBtn.ForeColor = System.Drawing.Color.White;
            this.yesBtn.Location = new System.Drawing.Point(132, 307);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(187, 81);
            this.yesBtn.TabIndex = 5;
            this.yesBtn.Text = "YES";
            this.yesBtn.UseVisualStyleBackColor = false;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.noBtn.Location = new System.Drawing.Point(401, 307);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(197, 81);
            this.noBtn.TabIndex = 6;
            this.noBtn.Text = "NO";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // Lose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.continueForEl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bestEl);
            this.Controls.Add(this.scoreEl);
            this.Controls.Add(this.label1);
            this.Name = "Lose";
            this.Text = "Lose";
            this.Load += new System.EventHandler(this.Lose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreEl;
        private System.Windows.Forms.Label bestEl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label continueForEl;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
    }
}