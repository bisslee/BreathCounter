using System;
using System.Threading;
using System.Windows.Forms;

namespace Biss.BreathCounter
{
    public partial class Main : Form
    {
        private int timerTicker = 0;
        private int breathTypeCounter = 0;
        private enum BreathType { Inspira, Expira };
        private string[] breathTypeColor = { "LightBlue", "LightGreen" };

        public Main()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InstructionsDisplayLabel.Text = @"Respire e prenda a respiração pelo tempo determinado no contador. " +
                "Assim que o contador de tempo reiniciar, solte lentamente a respiração." +
                Environment.NewLine + Environment.NewLine +
                "O contador de série irá informar quantas séries faltam";

            AppVersionDisplay.Text = $"{Application.ProductName} [{Application.ProductVersion}] - {CompanyName}";
        }

        private void TimeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void SeriesInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void TimeInput_TextChanged(object sender, EventArgs e)
        {
            HasNumber();
        }

        private void SeriesInput_TextChanged(object sender, EventArgs e)
        {
            HasNumber();
        }

        private static void OnlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void HasNumber()
        {
            StartButton.Enabled = !string.IsNullOrEmpty(TimeInput.Text) && !string.IsNullOrEmpty(SeriesInput.Text);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int series = Convert.ToInt32(SeriesInput.Text);
            int time = Convert.ToInt32(TimeInput.Text);

            SeriesDisplay.Text = series.ToString();
            breathTypeCounter = 0;
            ChangeBreathType();

            Application.DoEvents();
            timerTicker = 0;
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void ChangeBreathType()
        {
            BreathType breathType = (BreathType)breathTypeCounter;
            BreathTypeDisplay.Text = breathType.ToString();
            string selectedColor = breathTypeColor[breathTypeCounter];
            BreathTypeDisplay.BackColor = System.Drawing.Color.FromName(selectedColor);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(TimeInput.Text);

            timerTicker++;
            TimerDisplay.Text = timerTicker.ToString("00#");

            if (timerTicker > time)
            {
                timer1.Stop();
                timerTicker = 0;
                TimerDisplay.Text = timerTicker.ToString("00#");

                switch (breathTypeCounter)
                {
                    case 0:
                        breathTypeCounter++;
                        break;
                    case 1:
                        breathTypeCounter--;
                        break;
                }

                ChangeBreathType();

                if (breathTypeCounter == 0)
                {
                    int series = Convert.ToInt32(SeriesDisplay.Text);
                    series--;
                    SeriesDisplay.Text = series.ToString();

                    if (series > 0)
                    {
                        timer1.Start();
                    }
                    else
                    {
                        FormCleaner();
                        BreathTypeDisplay.Text = "Fim da série";
                        Application.DoEvents();
                        Thread.Sleep(1000);
                        BreathTypeDisplay.Text = "";
                    }
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void FormCleaner()
        {
            SeriesDisplay.Text = "";
            BreathTypeDisplay.Text = "";
            BreathTypeDisplay.BackColor = System.Drawing.Color.FromName("Control");

            TimerDisplay.Text = "";
            TimeInput.Text = "";
            SeriesInput.Text = "";
        }
    }
}
