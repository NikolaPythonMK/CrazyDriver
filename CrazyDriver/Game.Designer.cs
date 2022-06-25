
namespace CrazyDriver
{
    partial class Game
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.speedStatus = new System.Windows.Forms.StatusStrip();
            this.xStat = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pauseButton)).BeginInit();
            this.speedStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.ForeColor = System.Drawing.Color.Orange;
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(174, 59);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Score: 0";
            // 
            // pauseButton
            // 
            this.pauseButton.Image = global::CrazyDriver.Properties.Resources.pause__1_1;
            this.pauseButton.Location = new System.Drawing.Point(708, 12);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(71, 66);
            this.pauseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pauseButton.TabIndex = 2;
            this.pauseButton.TabStop = false;
            this.pauseButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(22, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Best score: 0";
            // 
            // speedStatus
            // 
            this.speedStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.speedStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xStat});
            this.speedStatus.Location = new System.Drawing.Point(0, 413);
            this.speedStatus.Name = "speedStatus";
            this.speedStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.speedStatus.Size = new System.Drawing.Size(800, 37);
            this.speedStatus.TabIndex = 4;
            this.speedStatus.Text = "statusStrip1";
            // 
            // xStat
            // 
            this.xStat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xStat.ForeColor = System.Drawing.Color.Black;
            this.xStat.Name = "xStat";
            this.xStat.Size = new System.Drawing.Size(51, 31);
            this.xStat.Text = "X: 0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.speedStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.scoreLabel);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.SizeChanged += new System.EventHandler(this.Game_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pauseButton)).EndInit();
            this.speedStatus.ResumeLayout(false);
            this.speedStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox pauseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip speedStatus;
        private System.Windows.Forms.ToolStripStatusLabel xStat;
    }
}