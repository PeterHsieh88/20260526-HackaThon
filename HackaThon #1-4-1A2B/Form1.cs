namespace HackaThon__1_4_1A2B
{
    public partial class Form1 : Form
    {
        List<int> answer = new List<int>();
        public Form1()
        {
            InitializeComponent();
            startBtn.Enabled = true;
            restartBtn.Enabled = false;
            checkAnsBtn.Enabled = false;
            revealBtn.Enabled = false;
            textBox1.Enabled = false;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            answer.Clear();
            startBtn.Enabled = false;
            restartBtn.Enabled = true;
            checkAnsBtn.Enabled = true;
            revealBtn.Enabled = true;
            textBox1.Enabled = true;
            randAnswer();
        }
        private void gameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void restartBtn_Click(object sender, EventArgs e)
        {

            gameListBox.Items.Clear();
            answer.Clear();
            randAnswer();
        }

        private void randAnswer()
        {

            Random rand = new Random();
            while (answer.Count < 4)
            {
                int num = rand.Next(0, 9);
                if (!answer.Contains(num))
                {
                    answer.Add(num);
                }
            }
            //gameListBox.Items.Add(string.Join("", answer));//印答案出來參考
        }

        private void checkAnsBtn_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            var guessInput = textBox1.Text;

            if (guessInput.Length != 4)
            {
                MessageBox.Show("請輸入四位數的數字!!!");
                return;
            }
            else if (guessInput.Distinct().Count() != 4)
            {
                MessageBox.Show("請輸入四位數且不重複的數字!!!");
                return;
            }
            for (var i = 0; i < 4; i++)
            {
                var number = int.Parse(guessInput[i].ToString());
                if (answer[i] == number)
                {
                    a++;
                }
                else if (answer.Contains(number))
                {
                    b++;
                }

            }
            gameListBox.Items.Add($"{a}A{b}B");
            if (a == 4)
            {
                MessageBox.Show("恭喜過關!!");
                gameListBox.Items.Add($"過關!!");
                startBtn.Enabled = true;
                restartBtn.Enabled = false;
                checkAnsBtn.Enabled = false;
                revealBtn.Enabled = false;
                gameListBox.Items.Clear();

            }


        }

        private void revealBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"答案是:{string.Join("",answer)}");
            gameListBox.Items.Clear();
            startBtn.Enabled = true;
            restartBtn.Enabled = false;
            checkAnsBtn.Enabled = false;
            revealBtn.Enabled = false;

        }
    }
}
