
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
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.ForeColor = System.Drawing.Color.Orange;
            this.scoreLabel.Location = new System.Drawing.Point(10, 7);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(143, 47);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Score: 0";
            // 
            // pauseButton
            // 
            this.pauseButton.Image = global::CrazyDriver.Properties.Resources.pause__1_1;
            this.pauseButton.Location = new System.Drawing.Point(620, 9);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(62, 50);
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
            this.label2.Location = new System.Drawing.Point(19, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Best score: 0";
            // 
            // speedStatus
            // 
            this.speedStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.speedStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xStat});
            this.speedStatus.Location = new System.Drawing.Point(0, 308);
            this.speedStatus.Name = "speedStatus";
            this.speedStatus.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.speedStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.speedStatus.Size = new System.Drawing.Size(700, 30);
            this.speedStatus.TabIndex = 4;
            this.speedStatus.Text = "statusStrip1";
            // 
            // xStat
            // 
            this.xStat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xStat.ForeColor = System.Drawing.Color.Black;
            this.xStat.Name = "xStat";
            this.xStat.Size = new System.Drawing.Size(42, 25);
            this.xStat.Text = "X: 0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.speedStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.scoreLabel);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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