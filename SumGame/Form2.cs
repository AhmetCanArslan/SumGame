namespace SumGame
{
    public partial class Form2 : Form
    {
        private int highScore, totalTimeInSeconds = 30, currentTime = 0;
        private const string path = "highscore.txt";
        private System.Windows.Forms.Timer timer;
        Random randSayi = new Random();
        public Form2()
        {
            InitializeComponent();
            oyunKur();
            InitializeTimer();
            textBox1.MaxLength = 3;
        }
        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }
        public void StartProgressBar()
        {
            currentTime = 0;
            progressBar1.Value = 0;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            currentTime++;

            if (currentTime <= totalTimeInSeconds)
            {
                progressBar1.Value = (int)(100 * (double)currentTime / totalTimeInSeconds);
            }
            else
            {
                string mesaj = "You're out of time!\nYour score is " + highScore;
                MessageBox.Show(mesaj, "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OyunuBitir();
            }
        }
        private int sonuc,cevap,trueCounter = 0,falseCounter=0,sayi1,sayi2;
        private void oyunKur()
        {
            textBox1.Text = null;
            textBox1.Focus();
            while (true)
            {
                sayi1 = randSayi.Next(51);
                sayi2 = randSayi.Next(51);
                if (sayi1 > sayi2)
                    break;
            }
            lblSayi1.Text = sayi1.ToString();
            lblSayi2.Text = sayi2.ToString();
            if (randSayi.Next(2) == 1)//toplama
            {
                lblIslem.Text = "+";
                sonuc = Convert.ToInt16(lblSayi1.Text) + Convert.ToInt16(lblSayi2.Text);
            }
            else
            {
                lblIslem.Text = "-";
                sonuc = Convert.ToInt16(lblSayi1.Text) - Convert.ToInt16(lblSayi2.Text);
            }
            lblFalse.Text = falseCounter.ToString();
            lblTrue.Text = trueCounter.ToString();
            highScore = trueCounter - falseCounter;
            if(highScore < 0)
                highScore = 0;
            WriteHighScore(path, highScore);

        }
        private void WriteHighScore(string filePath, int score)
        {
            // Dosyaya yazma işlemi
            if (score > 0 && score> Convert.ToInt16(File.ReadAllText(filePath)))
            {
                File.WriteAllText(filePath, score.ToString());
                return;
            }
            else if (0 < Convert.ToInt16(File.ReadAllText(filePath)))
            {
                return;
            }
            File.WriteAllText(filePath, "0");
        }
        private void OyunuBitir()
        {
            if (highScore < 0)
                highScore = 0;
            timer.Stop();
            this.Close(); // Form1'i gizle
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'P' || e.KeyChar == 'p')
            {
                oyunKur();
            }
            // Girilen karakterin sayı olup olmadığını kontrol et
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Sayı değilse olayı engelle
                e.Handled = true;
            }         
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space) 
            {
                string mesaj = "The space key has been pressed.!\nYour score is " + highScore;
                MessageBox.Show(mesaj, "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OyunuBitir();
            }
            if (e.KeyCode == Keys.Enter && textBox1.Text != "")
            {
                cevap = Convert.ToInt32(textBox1.Text);
                if (cevap == sonuc)
                {
                    trueCounter++;
                    oyunKur();
                    return;
                }
                falseCounter++;
                oyunKur();
                return;
            }
        }
    }
}
