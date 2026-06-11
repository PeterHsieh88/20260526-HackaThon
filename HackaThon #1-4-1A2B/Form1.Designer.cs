namespace HackaThon__1_4_1A2B
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startBtn = new Button();
            revealBtn = new Button();
            textBox1 = new TextBox();
            checkAnsBtn = new Button();
            restartBtn = new Button();
            groupBox1 = new GroupBox();
            gameListBox = new ListBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // startBtn
            // 
            startBtn.BackColor = SystemColors.ButtonHighlight;
            startBtn.Location = new Point(74, 87);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(130, 55);
            startBtn.TabIndex = 0;
            startBtn.Text = "開始遊戲";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click;
            // 
            // revealBtn
            // 
            revealBtn.Location = new Point(74, 174);
            revealBtn.Name = "revealBtn";
            revealBtn.Size = new Size(130, 55);
            revealBtn.TabIndex = 1;
            revealBtn.Text = "看答案";
            revealBtn.UseVisualStyleBackColor = true;
            revealBtn.Click += revealBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 365);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 2;
            textBox1.Text = "請按\"開始遊戲\"";
            // 
            // checkAnsBtn
            // 
            checkAnsBtn.Location = new Point(74, 458);
            checkAnsBtn.Name = "checkAnsBtn";
            checkAnsBtn.Size = new Size(112, 34);
            checkAnsBtn.TabIndex = 3;
            checkAnsBtn.Text = "檢查答案";
            checkAnsBtn.UseVisualStyleBackColor = true;
            checkAnsBtn.Click += checkAnsBtn_Click;
            // 
            // restartBtn
            // 
            restartBtn.Location = new Point(277, 458);
            restartBtn.Name = "restartBtn";
            restartBtn.Size = new Size(112, 34);
            restartBtn.TabIndex = 4;
            restartBtn.Text = "放棄重來";
            restartBtn.UseVisualStyleBackColor = true;
            restartBtn.Click += restartBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gameListBox);
            groupBox1.Location = new Point(464, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 420);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "遊戲歷程";
            // 
            // gameListBox
            // 
            gameListBox.FormattingEnabled = true;
            gameListBox.Location = new Point(0, 29);
            gameListBox.Name = "gameListBox";
            gameListBox.Size = new Size(300, 395);
            gameListBox.TabIndex = 0;
            gameListBox.SelectedIndexChanged += gameListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 339);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 6;
            label1.Text = "輸入";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 546);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(restartBtn);
            Controls.Add(checkAnsBtn);
            Controls.Add(textBox1);
            Controls.Add(revealBtn);
            Controls.Add(startBtn);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startBtn;
        private Button revealBtn;
        private TextBox textBox1;
        private Button checkAnsBtn;
        private Button restartBtn;
        private GroupBox groupBox1;
        private ListBox gameListBox;
        private Label label1;
        private TextBox textBox2;
    }
}
