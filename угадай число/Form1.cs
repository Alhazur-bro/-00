using System;
using System.Windows.Forms;

namespace угадай_число
{
    public partial class Form1 : Form
    {
        private int secretNumber;      // загаданное число
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            StartNewGame(); // запускаем новую игру при старте

            // привязываем кнопки к обработчикам
            btnCheck.Click += btnCheck_Click;
            btnNewGame.Click += btnNewGame_Click;
        }

        private void StartNewGame()
        {
            secretNumber = rnd.Next(1, 101); // случайное число 1–100
            lblResult.Text = "Угадай число от 1 до 100";
            txtGuess.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtGuess.Text, out int guess))
            {
                if (guess < secretNumber)
                {
                    lblResult.Text = "Загаданное число больше!";
                }
                else if (guess > secretNumber)
                {
                    lblResult.Text = "Загаданное число меньше!";
                }
                else
                {
                    lblResult.Text = "🎉 Вы угадали!";
                }
            }
            else
            {
                lblResult.Text = "Введите корректное число!";
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // можно оставить пустым
        }
    }
}