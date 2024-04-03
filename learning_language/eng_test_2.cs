using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Globalization;
using static System.Formats.Asn1.AsnWriter;


namespace learning_language
{
    public partial class eng_test_2 : Form
    {
        public eng_test_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр второй формы - form2
            form_eng_first form2 = new form_eng_first();
            // Скрываем текущую (первую) форму
            this.Hide();
            // Отображаем вторую форму
            form2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int correctAnswers = 0;
            //индекс начинается с 0, поэтому правильное слово будет 1
            if (comboBox1.SelectedIndex == 1) 
            {
                correctAnswers++;
            }

            if (comboBox2.SelectedIndex == 0) 
            {
                correctAnswers++;
            }

            if (comboBox3.SelectedIndex == 1) 
            {
                correctAnswers++;
            }

            if (comboBox4.SelectedIndex == 2) 
            {
                correctAnswers++;
            }

            if (comboBox5.SelectedIndex == 0) 
            {
                correctAnswers++;
            }

            if (comboBox6.SelectedIndex == 1) 
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
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("en-US"));
            builder.AppendText("Monica got a fluffy and affectionate Cat, she drinks milk.");
            synthesizer.Speak(builder);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("en-US"));
            builder.AppendText("Sam decided to pour tea, but accidentally broke the Glass.");
            synthesizer.Speak(builder);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("en-US"));
            builder.AppendText("My Bed is broken, if I don't fix it I won't be able to sleep.");
            synthesizer.Speak(builder);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("en-US"));
            builder.AppendText("If I miss the airport, my Airplane will leave without me.");
            synthesizer.Speak(builder);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("en-US"));
            builder.AppendText("The Screen on my phone is broken, it needs to be fixed by the master.");
            synthesizer.Speak(builder);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("en-US"));
            builder.AppendText("A wheel burst on my Car, there are still 3 whole ones left.");
            synthesizer.Speak(builder);
        }

        private void eng_test_2_Load(object sender, EventArgs e)
        {

        }
    }
}
