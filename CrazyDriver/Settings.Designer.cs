
namespace CrazyDriver
{
    partial class Settings
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
            this.backBtn = new System.Windows.Forms.Button();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.menuMusicEl = new System.Windows.Forms.CheckBox();
            this.gameMusicEl = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.arrowsEl = new System.Windows.Forms.RadioButton();
            this.lettersEl = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backBtn.Location = new System.Drawing.Point(705, 527);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(166, 65);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveChangesBtn.Location = new System.Drawing.Point(524, 527);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(166, 65);
            this.saveChangesBtn.TabIndex = 1;
            this.saveChangesBtn.Text = "Save Changes";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // menuMusicEl
            // 
            this.menuMusicEl.AutoSize = true;
            this.menuMusicEl.BackColor = System.Drawing.Color.Transparent;
            this.menuMusicEl.Checked = true;
            this.menuMusicEl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuMusicEl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuMusicEl.ForeColor = System.Drawing.Color.White;
            this.menuMusicEl.Location = new System.Drawing.Point(38, 40);
            this.menuMusicEl.Name = "menuMusicEl";
            this.menuMusicEl.Size = new System.Drawing.Size(220, 49);
            this.menuMusicEl.TabIndex = 2;
            this.menuMusicEl.Text = "Menu music";
            this.menuMusicEl.UseVisualStyleBackColor = false;
            // 
            // gameMusicEl
            // 
            this.gameMusicEl.AutoSize = true;
            this.gameMusicEl.BackColor = System.Drawing.Color.Transparent;
            this.gameMusicEl.Checked = true;
            this.gameMusicEl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gameMusicEl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameMusicEl.ForeColor = System.Drawing.Color.White;
            this.gameMusicEl.Location = new System.Drawing.Point(38, 102);
            this.gameMusicEl.Name = "gameMusicEl";
            this.gameMusicEl.Size = new System.Drawing.Size(220, 49);
            this.gameMusicEl.TabIndex = 3;
            this.gameMusicEl.Text = "Game music";
            this.gameMusicEl.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Controls:";
            // 
            // arrowsEl
            // 
            this.arrowsEl.AutoSize = true;
            this.arrowsEl.BackColor = System.Drawing.Color.Transparent;
            this.arrowsEl.Checked = true;
            this.arrowsEl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrowsEl.ForeColor = System.Drawing.Color.White;
            this.arrowsEl.Location = new System.Drawing.Point(38, 265);
            this.arrowsEl.Name = "arrowsEl";
            this.arrowsEl.Size = new System.Drawing.Size(332, 42);
            this.arrowsEl.TabIndex = 5;
            this.arrowsEl.TabStop = true;
            this.arrowsEl.Text = "Left arrow / Right arrow";
            this.arrowsEl.UseVisualStyleBackColor = false;
            // 
            // lettersEl
            // 
            this.lettersEl.AutoSize = true;
            this.lettersEl.BackColor = System.Drawing.Color.Transparent;
            this.lettersEl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lettersEl.ForeColor = System.Drawing.Color.White;
            this.lettersEl.Location = new System.Drawing.Point(38, 347);
            this.lettersEl.Name = "lettersEl";
            this.lettersEl.Size = new System.Drawing.Size(103, 42);
            this.lettersEl.TabIndex = 6;
            this.lettersEl.Text = "A / D";
            this.lettersEl.UseVisualStyleBackColor = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CrazyDriver.Properties.Resources.settings_background;
            this.ClientSize = new System.Drawing.Size(883, 604);
            this.Controls.Add(this.lettersEl);
            this.Controls.Add(this.arrowsEl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameMusicEl);
            this.Controls.Add(this.menuMusicEl);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.backBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.CheckBox menuMusicEl;
        private System.Windows.Forms.CheckBox gameMusicEl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton arrowsEl;
        private System.Windows.Forms.RadioButton lettersEl;
    }
}