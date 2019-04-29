namespace OOFinal
{
    partial class FightForm
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
            this.playerLabel = new System.Windows.Forms.Label();
            this.enemyLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PlayerHealth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EnemyHealth = new System.Windows.Forms.Label();
            this.PlayerArmor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EnemyArmor = new System.Windows.Forms.Label();
            this.PlayerWeapon = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EnemyWeapon = new System.Windows.Forms.Label();
            this.FightBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // playerLabel
            // 
            this.playerLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.Location = new System.Drawing.Point(28, 9);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(155, 44);
            this.playerLabel.TabIndex = 0;
            this.playerLabel.Text = "Player";
            // 
            // enemyLabel
            // 
            this.enemyLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyLabel.Location = new System.Drawing.Point(478, 9);
            this.enemyLabel.Name = "enemyLabel";
            this.enemyLabel.Size = new System.Drawing.Size(160, 44);
            this.enemyLabel.TabIndex = 1;
            this.enemyLabel.Text = "Enemy";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Action";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayerHealth
            // 
            this.PlayerHealth.AutoSize = true;
            this.PlayerHealth.Location = new System.Drawing.Point(36, 70);
            this.PlayerHealth.Name = "PlayerHealth";
            this.PlayerHealth.Size = new System.Drawing.Size(46, 17);
            this.PlayerHealth.TabIndex = 4;
            this.PlayerHealth.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Health";
            // 
            // EnemyHealth
            // 
            this.EnemyHealth.AutoSize = true;
            this.EnemyHealth.Location = new System.Drawing.Point(499, 70);
            this.EnemyHealth.Name = "EnemyHealth";
            this.EnemyHealth.Size = new System.Drawing.Size(46, 17);
            this.EnemyHealth.TabIndex = 6;
            this.EnemyHealth.Text = "label3";
            // 
            // PlayerArmor
            // 
            this.PlayerArmor.AutoSize = true;
            this.PlayerArmor.Location = new System.Drawing.Point(36, 121);
            this.PlayerArmor.Name = "PlayerArmor";
            this.PlayerArmor.Size = new System.Drawing.Size(46, 17);
            this.PlayerArmor.TabIndex = 7;
            this.PlayerArmor.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Armor";
            // 
            // EnemyArmor
            // 
            this.EnemyArmor.AutoSize = true;
            this.EnemyArmor.Location = new System.Drawing.Point(499, 121);
            this.EnemyArmor.Name = "EnemyArmor";
            this.EnemyArmor.Size = new System.Drawing.Size(46, 17);
            this.EnemyArmor.TabIndex = 9;
            this.EnemyArmor.Text = "label6";
            // 
            // PlayerWeapon
            // 
            this.PlayerWeapon.AutoSize = true;
            this.PlayerWeapon.Location = new System.Drawing.Point(36, 171);
            this.PlayerWeapon.Name = "PlayerWeapon";
            this.PlayerWeapon.Size = new System.Drawing.Size(46, 17);
            this.PlayerWeapon.TabIndex = 10;
            this.PlayerWeapon.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Weapon";
            // 
            // EnemyWeapon
            // 
            this.EnemyWeapon.AutoSize = true;
            this.EnemyWeapon.Location = new System.Drawing.Point(499, 171);
            this.EnemyWeapon.Name = "EnemyWeapon";
            this.EnemyWeapon.Size = new System.Drawing.Size(46, 17);
            this.EnemyWeapon.TabIndex = 12;
            this.EnemyWeapon.Text = "label9";
            // 
            // FightBox1
            // 
            this.FightBox1.FormattingEnabled = true;
            this.FightBox1.Location = new System.Drawing.Point(39, 217);
            this.FightBox1.Name = "FightBox1";
            this.FightBox1.Size = new System.Drawing.Size(165, 24);
            this.FightBox1.TabIndex = 13;
            // 
            // FightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 290);
            this.Controls.Add(this.FightBox1);
            this.Controls.Add(this.EnemyWeapon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PlayerWeapon);
            this.Controls.Add(this.EnemyArmor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlayerArmor);
            this.Controls.Add(this.EnemyHealth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlayerHealth);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enemyLabel);
            this.Controls.Add(this.playerLabel);
            this.Name = "FightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FightForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label enemyLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox FightBox1;
        public System.Windows.Forms.Label PlayerHealth;
        public System.Windows.Forms.Label PlayerArmor;
        public System.Windows.Forms.Label EnemyHealth;
        public System.Windows.Forms.Label PlayerWeapon;
        public System.Windows.Forms.Label EnemyArmor;
        public System.Windows.Forms.Label EnemyWeapon;
    }
}