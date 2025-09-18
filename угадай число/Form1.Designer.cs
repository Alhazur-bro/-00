namespace угадай_число
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
            lblResult = new Label();
            txtGuess = new TextBox();
            btnCheck = new Button();
            btnNewGame = new Button();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10F);
            lblResult.Location = new Point(290, 21);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(206, 23);
            lblResult.TabIndex = 0;
            lblResult.Text = "угадай число от 1 до 100";
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(325, 60);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(125, 27);
            txtGuess.TabIndex = 1;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(340, 93);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(94, 29);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "проверить";
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(340, 132);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(94, 29);
            btnNewGame.TabIndex = 3;
            btnNewGame.Text = "по новой";
            btnNewGame.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNewGame);
            Controls.Add(btnCheck);
            Controls.Add(txtGuess);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private TextBox txtGuess;
        private Button btnCheck;
        private Button btnNewGame;
    }
}
