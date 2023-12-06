namespace SumGame
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            if (!File.Exists(highScoreFilePath))
            {
                File.WriteAllText(highScoreFilePath, "0");
            }
            int highScore = ReadHighScore(highScoreFilePath);
            lblHighScore.Text = highScore.ToString();

        }
        private const string highScoreFilePath = "highscore.txt";

        private int ReadHighScore(string filePath)
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);

                if (int.TryParse(content, out int score))
                {
                    return score;
                }
            }
            // If the file doesn't exist, return 0;
            return 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Form1'i gizle
            Form2 form2 = new Form2();
            form2.StartProgressBar();
            form2.ShowDialog();
            this.Close();
        }
    }
}