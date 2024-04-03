using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace learning_language
{
    public partial class eng_test_form : Form
    {

        public eng_test_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр второй формы - form2
            form_eng_first form3 = new form_eng_first();
            // Скрываем текущую (первую) форму
            this.Hide();
            // Отображаем вторую форму
            form3.Show();
        }


        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void eng_test_form_Load(object sender, EventArgs e)
        {

        }

        private void eng_test_form_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //кнопка проверки

        private void button2_Click(object sender, EventArgs e)
        {
            int score = 0;

            if (radioButton1.Checked)
            {
                score++;
            }

            if (radioButton8.Checked)
            {
                score++;
            }

            if (radioButton6.Checked)
            {
                score++;
            }

            if (radioButton10.Checked)
            {
                score++;
            }

            if (radioButton14.Checked)
            {
                score++;
            }

            if (score > 0)
            {
                MessageBox.Show($"Правильных ответов: {score} из 5");
            }
            else
            {
                MessageBox.Show("Выберите варианты ответа");
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
