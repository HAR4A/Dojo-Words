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
    public partial class french_test_2 : Form
    {
        public french_test_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр первой формы form1
            first_french form7 = new first_french();
            // Закрываем текущую (вторую) форму
            this.Hide();
            // Отображаем первую форму
            form7.Show();
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


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("fr-FR"));
            builder.AppendText("Pedro a acheté une nouvelle Bouilloire pour faire un délicieux thé.");
            synthesizer.Speak(builder);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("fr-FR"));
            builder.AppendText("les Сhampignons poussent dans la forêt à l'extérieur de la ville.");
            synthesizer.Speak(builder);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("fr-FR"));
            builder.AppendText("L'oncle Antoine a démarré son Tracteur pour labourer le champ.");
            synthesizer.Speak(builder);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("fr-FR"));
            builder.AppendText("Emmanuel a oublié sa Serviette avant de prendre sa douche.");
            synthesizer.Speak(builder);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("fr-FR"));
            builder.AppendText("Sur la plage près du lac, du Sable a été versé pour les enfants.");
            synthesizer.Speak(builder);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("fr-FR"));
            builder.AppendText("Valera a acheté une Pizza dans une épicerie.");
            synthesizer.Speak(builder);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
