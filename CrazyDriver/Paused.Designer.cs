
namespace CrazyDriver
{
    partial class Paused
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(171, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 81);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game is paused";
            // 
            // scoreEl
            // 
            this.scoreEl.AutoSize = true;
            this.scoreEl.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreEl.Location = new System.Drawing.Point(270, 113);
            this.scoreEl.Name = "scoreEl";
            this.scoreEl.Size = new System.Drawing.Size(191, 62);
            this.scoreEl.TabIndex = 2;
            this.scoreEl.Text = "Score: 0";
            // 
            // bestEl
            // 
            this.bestEl.AutoSize = true;
            this.bestEl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bestEl.Location = new System.Drawing.Point(270, 175);
            this.bestEl.Name = "bestEl";
            this.bestEl.Size = new System.Drawing.Size(130, 54);
            this.bestEl.TabIndex = 3;
            this.bestEl.Text = "Best:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(161, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(404, 73);
            this.button1.TabIndex = 4;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(161, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(404, 73);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back to garage";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Paused
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bestEl);
            this.Controls.Add(this.scoreEl);
            this.Controls.Add(this.label1);
            this.Name = "Paused";
            this.Text = "Paused";
            this.Load += new System.EventHandler(this.Paused_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreEl;
        private System.Windows.Forms.Label bestEl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}