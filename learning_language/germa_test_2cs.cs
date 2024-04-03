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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace learning_language
{
    public partial class germa_test_2cs : Form
    {
        public germa_test_2cs()
        {
            InitializeComponent();
        }

        private void germa_test_2cs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр второй формы - form2
            german_first form3 = new german_first();
            // Скрываем текущую (первую) форму
            this.Hide();
            // Отображаем вторую форму
            form3.Show();
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
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("de-DE"));
            builder.AppendText("Ein kleiner Spatz thront auf einem Baum");
            synthesizer.Speak(builder);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("de-DE"));
            builder.AppendText("Wir haben einen neuen Tisch von Ike gekauft.");
            synthesizer.Speak(builder);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("de-DE"));
            builder.AppendText("Wir kamen im Restaurant an, die Servietten waren wunderschön ausgelegt.");
            synthesizer.Speak(builder);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("de-DE"));
            builder.AppendText("Wir haben ein Schiff im Stadthafen");
            synthesizer.Speak(builder);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("de-DE"));
            builder.AppendText("Wenn Sie unter einer Decke  schlafen, wird es wärmer");
            synthesizer.Speak(builder);
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 1;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("de-DE"));
            builder.AppendText("Ich habe einen Monitor ür meinen Computer gekauft, jetzt wird das Bild besser.");
            synthesizer.Speak(builder);
        }
    }
}
