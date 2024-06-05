namespace Domino
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.player1Label = new System.Windows.Forms.Label();
            this.player1Textbox = new System.Windows.Forms.TextBox();
            this.player3Label = new System.Windows.Forms.Label();
            this.player3Textbox = new System.Windows.Forms.TextBox();
            this.player2Label = new System.Windows.Forms.Label();
            this.player2Textbox = new System.Windows.Forms.TextBox();
            this.player4Label = new System.Windows.Forms.Label();
            this.player4Textbox = new System.Windows.Forms.TextBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(104, 160);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(177, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите имя игрока";
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(104, 201);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(177, 29);
            this.addPlayerButton.TabIndex = 3;
            this.addPlayerButton.Text = "Добавить игрока";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(558, 37);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(56, 16);
            this.player1Label.TabIndex = 5;
            this.player1Label.Text = "Игрок 1";
            this.player1Label.Visible = false;
            // 
            // player1Textbox
            // 
            this.player1Textbox.Location = new System.Drawing.Point(561, 56);
            this.player1Textbox.Name = "player1Textbox";
            this.player1Textbox.ReadOnly = true;
            this.player1Textbox.Size = new System.Drawing.Size(177, 22);
            this.player1Textbox.TabIndex = 4;
            this.player1Textbox.Visible = false;
            // 
            // player3Label
            // 
            this.player3Label.AutoSize = true;
            this.player3Label.Location = new System.Drawing.Point(558, 155);
            this.player3Label.Name = "player3Label";
            this.player3Label.Size = new System.Drawing.Size(56, 16);
            this.player3Label.TabIndex = 9;
            this.player3Label.Text = "Игрок 3";
            this.player3Label.Visible = false;
            // 
            // player3Textbox
            // 
            this.player3Textbox.Location = new System.Drawing.Point(561, 174);
            this.player3Textbox.Name = "player3Textbox";
            this.player3Textbox.ReadOnly = true;
            this.player3Textbox.Size = new System.Drawing.Size(177, 22);
            this.player3Textbox.TabIndex = 8;
            this.player3Textbox.Visible = false;
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Location = new System.Drawing.Point(558, 99);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(56, 16);
            this.player2Label.TabIndex = 11;
            this.player2Label.Text = "Игрок 2";
            this.player2Label.Visible = false;
            // 
            // player2Textbox
            // 
            this.player2Textbox.Location = new System.Drawing.Point(561, 118);
            this.player2Textbox.Name = "player2Textbox";
            this.player2Textbox.ReadOnly = true;
            this.player2Textbox.Size = new System.Drawing.Size(177, 22);
            this.player2Textbox.TabIndex = 10;
            this.player2Textbox.Visible = false;
            // 
            // player4Label
            // 
            this.player4Label.AutoSize = true;
            this.player4Label.Location = new System.Drawing.Point(558, 214);
            this.player4Label.Name = "player4Label";
            this.player4Label.Size = new System.Drawing.Size(56, 16);
            this.player4Label.TabIndex = 13;
            this.player4Label.Text = "Игрок 4";
            this.player4Label.Visible = false;
            // 
            // player4Textbox
            // 
            this.player4Textbox.Location = new System.Drawing.Point(561, 233);
            this.player4Textbox.Name = "player4Textbox";
            this.player4Textbox.ReadOnly = true;
            this.player4Textbox.Size = new System.Drawing.Size(177, 22);
            this.player4Textbox.TabIndex = 12;
            this.player4Textbox.Visible = false;
            // 
            // startGameButton
            // 
            this.startGameButton.Enabled = false;
            this.startGameButton.Location = new System.Drawing.Point(104, 304);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(177, 29);
            this.startGameButton.TabIndex = 14;
            this.startGameButton.Text = "Начать игру";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.player4Label);
            this.Controls.Add(this.player4Textbox);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player2Textbox);
            this.Controls.Add(this.player3Label);
            this.Controls.Add(this.player3Textbox);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.player1Textbox);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Name = "StartForm";
            this.Text = "Домино";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.TextBox player1Textbox;
        private System.Windows.Forms.Label player3Label;
        private System.Windows.Forms.TextBox player3Textbox;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.TextBox player2Textbox;
        private System.Windows.Forms.Label player4Label;
        private System.Windows.Forms.TextBox player4Textbox;
        private System.Windows.Forms.Button startGameButton;
    }
}

