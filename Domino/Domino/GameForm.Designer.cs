namespace Domino
{
    partial class GameForm
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
            this.gameTablePanel = new System.Windows.Forms.Panel();
            this.player1GroupBox = new System.Windows.Forms.GroupBox();
            this.player2GroupBox = new System.Windows.Forms.GroupBox();
            this.player3GroupBox = new System.Windows.Forms.GroupBox();
            this.player4GroupBox = new System.Windows.Forms.GroupBox();
            this.bazarGroupBox = new System.Windows.Forms.GroupBox();
            this.takeDominoButton = new System.Windows.Forms.Button();
            this.skipmoveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTablePanel
            // 
            this.gameTablePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameTablePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameTablePanel.Location = new System.Drawing.Point(12, 12);
            this.gameTablePanel.Name = "gameTablePanel";
            this.gameTablePanel.Size = new System.Drawing.Size(965, 496);
            this.gameTablePanel.TabIndex = 0;
            // 
            // player1GroupBox
            // 
            this.player1GroupBox.AutoSize = true;
            this.player1GroupBox.Enabled = false;
            this.player1GroupBox.Location = new System.Drawing.Point(12, 572);
            this.player1GroupBox.Name = "player1GroupBox";
            this.player1GroupBox.Size = new System.Drawing.Size(477, 104);
            this.player1GroupBox.TabIndex = 1;
            this.player1GroupBox.TabStop = false;
            this.player1GroupBox.Text = "groupBox1";
            this.player1GroupBox.Visible = false;
            // 
            // player2GroupBox
            // 
            this.player2GroupBox.AutoSize = true;
            this.player2GroupBox.Enabled = false;
            this.player2GroupBox.Location = new System.Drawing.Point(787, 572);
            this.player2GroupBox.Name = "player2GroupBox";
            this.player2GroupBox.Size = new System.Drawing.Size(477, 104);
            this.player2GroupBox.TabIndex = 2;
            this.player2GroupBox.TabStop = false;
            this.player2GroupBox.Text = "groupBox2";
            this.player2GroupBox.Visible = false;
            // 
            // player3GroupBox
            // 
            this.player3GroupBox.AutoSize = true;
            this.player3GroupBox.Enabled = false;
            this.player3GroupBox.Location = new System.Drawing.Point(12, 702);
            this.player3GroupBox.Name = "player3GroupBox";
            this.player3GroupBox.Size = new System.Drawing.Size(477, 104);
            this.player3GroupBox.TabIndex = 2;
            this.player3GroupBox.TabStop = false;
            this.player3GroupBox.Text = "groupBox3";
            this.player3GroupBox.Visible = false;
            // 
            // player4GroupBox
            // 
            this.player4GroupBox.AutoSize = true;
            this.player4GroupBox.Enabled = false;
            this.player4GroupBox.Location = new System.Drawing.Point(787, 698);
            this.player4GroupBox.Name = "player4GroupBox";
            this.player4GroupBox.Size = new System.Drawing.Size(477, 104);
            this.player4GroupBox.TabIndex = 2;
            this.player4GroupBox.TabStop = false;
            this.player4GroupBox.Text = "groupBox4";
            this.player4GroupBox.Visible = false;
            // 
            // bazarGroupBox
            // 
            this.bazarGroupBox.Location = new System.Drawing.Point(991, 74);
            this.bazarGroupBox.Name = "bazarGroupBox";
            this.bazarGroupBox.Size = new System.Drawing.Size(273, 433);
            this.bazarGroupBox.TabIndex = 3;
            this.bazarGroupBox.TabStop = false;
            this.bazarGroupBox.Text = "Базар";
            // 
            // takeDominoButton
            // 
            this.takeDominoButton.Location = new System.Drawing.Point(991, 513);
            this.takeDominoButton.Name = "takeDominoButton";
            this.takeDominoButton.Size = new System.Drawing.Size(273, 40);
            this.takeDominoButton.TabIndex = 4;
            this.takeDominoButton.Text = "Взять домино с базара";
            this.takeDominoButton.UseVisualStyleBackColor = true;
            this.takeDominoButton.Visible = false;
            this.takeDominoButton.Click += new System.EventHandler(this.takeDominoButton_Click);
            // 
            // skipmoveButton
            // 
            this.skipmoveButton.Location = new System.Drawing.Point(12, 514);
            this.skipmoveButton.Name = "skipmoveButton";
            this.skipmoveButton.Size = new System.Drawing.Size(224, 40);
            this.skipmoveButton.TabIndex = 5;
            this.skipmoveButton.Text = "Пропустить ход";
            this.skipmoveButton.UseVisualStyleBackColor = true;
            this.skipmoveButton.Click += new System.EventHandler(this.skipmoveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(991, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 48);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сейчас ход";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Игрок";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1277, 818);
            this.Controls.Add(this.player2GroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.skipmoveButton);
            this.Controls.Add(this.takeDominoButton);
            this.Controls.Add(this.bazarGroupBox);
            this.Controls.Add(this.player4GroupBox);
            this.Controls.Add(this.player3GroupBox);
            this.Controls.Add(this.player1GroupBox);
            this.Controls.Add(this.gameTablePanel);
            this.Name = "GameForm";
            this.Text = "Домино";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gameTablePanel;
        private System.Windows.Forms.GroupBox player1GroupBox;
        private System.Windows.Forms.GroupBox player2GroupBox;
        private System.Windows.Forms.GroupBox player3GroupBox;
        private System.Windows.Forms.GroupBox player4GroupBox;
        private System.Windows.Forms.GroupBox bazarGroupBox;
        private System.Windows.Forms.Button takeDominoButton;
        private System.Windows.Forms.Button skipmoveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label1;
    }
}