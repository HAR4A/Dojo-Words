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
    public partial class spain_test_2 : Form
    {
        public spain_test_2()
        {
            InitializeComponent();
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
            PromptBuilder builder = new PromptBuilder(new CultureInfo("es-ES"));
            builder.AppendText("¡Juan estaba en el zoológico y vio muchas Pájaro exóticas!");
            synthesizer.Speak(builder);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр второй формы - form2
            spain_first form9 = new spain_first();
            // Скрываем текущую (первую) форму
            this.Hide();
            // Отображаем вторую форму
            form9.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 0;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("es-ES"));
            builder.AppendText("Mateo tiene un Armario nuevo, ahora puede poner todas sus cosas allí.");
            synthesizer.Speak(builder);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 0;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("es-ES"));
            builder.AppendText("Compré una nueva Cuchara de oro como regalo.");
            synthesizer.Speak(builder);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 0;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("es-ES"));
            builder.AppendText("Me mareé cuando navegamos en el Barco.");
            synthesizer.Speak(builder);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 0;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("es-ES"));
            builder.AppendText("La nueva Almohada es mucho más cómoda para dormir.");
            synthesizer.Speak(builder);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synthesizer.Rate = 0;
            synthesizer.Volume = 100;
            PromptBuilder builder = new PromptBuilder(new CultureInfo("es-ES"));
            builder.AppendText("Me compré un Teléfono nuevo, ahora puedo hablar por video.");
            synthesizer.Speak(builder);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void spain_test_2_Load(object sender, EventArgs e)
        {

        }
    }
}
