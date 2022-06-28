
namespace CrazyDriver
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.playBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.shopBtn = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblbestscore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.playBtn.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playBtn.ForeColor = System.Drawing.Color.White;
            this.playBtn.Location = new System.Drawing.Point(509, 375);
            this.playBtn.Margin = new System.Windows.Forms.Padding(0);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(262, 79);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "PLAY";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Location = new System.Drawing.Point(0, 375);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(262, 79);
            this.settingsBtn.TabIndex = 2;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // shopBtn
            // 
            this.shopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.shopBtn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shopBtn.ForeColor = System.Drawing.Color.White;
            this.shopBtn.Location = new System.Drawing.Point(256, 375);
            this.shopBtn.Margin = new System.Windows.Forms.Padding(0);
            this.shopBtn.Name = "shopBtn";
            this.shopBtn.Size = new System.Drawing.Size(262, 79);
            this.shopBtn.TabIndex = 3;
            this.shopBtn.Text = "Shop";
            this.shopBtn.UseVisualStyleBackColor = false;
            this.shopBtn.Click += new System.EventHandler(this.shopBtn_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.IndianRed;
            this.lblMoney.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMoney.ForeColor = System.Drawing.Color.White;
            this.lblMoney.Location = new System.Drawing.Point(484, -1);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(105, 37);
            this.lblMoney.TabIndex = 4;
            this.lblMoney.Text = "Money:";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.IndianRed;
            this.lbluser.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbluser.ForeColor = System.Drawing.Color.White;
            this.lbluser.Location = new System.Drawing.Point(0, -1);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(76, 37);
            this.lbluser.TabIndex = 6;
            this.lbluser.Text = "User:";
            // 
            // lblbestscore
            // 
            this.lblbestscore.AutoSize = true;
            this.lblbestscore.BackColor = System.Drawing.Color.IndianRed;
            this.lblbestscore.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblbestscore.ForeColor = System.Drawing.Color.White;
            this.lblbestscore.Location = new System.Drawing.Point(0, 338);
            this.lblbestscore.Name = "lblbestscore";
            this.lblbestscore.Size = new System.Drawing.Size(141, 37);
            this.lblbestscore.TabIndex = 7;
            this.lblbestscore.Text = "Best score:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(658, 196);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblbestscore);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.shopBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.playBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button shopBtn;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblbestscore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNext;
    }
}