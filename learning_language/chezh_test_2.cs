using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learning_language
{
    public partial class chezh_test_2 : Form
    {
        public chezh_test_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр первой формы form1
            chezh_first form11 = new chezh_first();
            // Закрываем текущую (вторую) форму
            this.Hide();
            // Отображаем первую форму
            form11.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int correctAnswers = 0;
            //индекс начинается с 0, поэтому правильное слово будет 1
            if (comboBox1.SelectedIndex == 1) // если выбрано правильное слово в первом ComboBox
            {
                correctAnswers++;
            }

            if (comboBox2.SelectedIndex == 0) // если выбрано правильное слово в первом ComboBox
            {
                correctAnswers++;
            }

            if (comboBox3.SelectedIndex == 1) // если выбрано правильное слово в первом ComboBox
            {
                correctAnswers++;
            }

            if (comboBox4.SelectedIndex == 2) // если выбрано правильное слово в первом ComboBox
            {
                correctAnswers++;
            }

            if (comboBox5.SelectedIndex == 0) // если выбрано правильное слово в первом ComboBox
            {
                correctAnswers++;
            }

            if (comboBox6.SelectedIndex == 1) // если выбрано правильное слово в первом ComboBox
            {
                correctAnswers++;
            }


            if (correctAnswers > 0)
            {
                MessageBox.Show($"Правильных ответов: {correctAnswers} из 6");
            }
            else
            {
                MessageBox.Show("Выберите варианты ответа");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 0;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("pl-PL"));
            builder.AppendText("Pes, kterého jsme viděli na ulici, byl velmi přítulný.");
            synthesizer.Speak(builder);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 0;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("pl-PL"));
            builder.AppendText("Koupili jsme černý noční stolek z Ikea, je velmi pohodlný.");
            synthesizer.Speak(builder);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 0;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("pl-PL"));
            builder.AppendText("V restauraci nám naservírovali špinavé vidličky, jsme nešťastní!");
            synthesizer.Speak(builder);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 0;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("pl-PL"));
            builder.AppendText("Haroldův otec dal červený a výkonný moped.");
            synthesizer.Speak(builder);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 0;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("pl-PL"));
            builder.AppendText("Potřebuji vyměnit matraci, moje je už celá propadlá a trčí z ní pružiny.");
            synthesizer.Speak(builder);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 0;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("pl-PL"));
            builder.AppendText("Dnes jdeme do pizzerie, jíme pizzu s ananasem.");
            synthesizer.Speak(builder);
        }
    }
}
