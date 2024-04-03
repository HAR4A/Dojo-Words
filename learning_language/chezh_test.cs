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
    public partial class chezh_test : Form
    {
        public chezh_test()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр первой формы form1
            chezh_first form12 = new chezh_first();
            // Закрываем текущую (вторую) форму
            this.Close();
            // Отображаем первую форму
            form12.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score = 0;

            if (radioButton2.Checked)
            {
                score++;
            }
            if (radioButton5.Checked)
            {
                score++;
            }
            if (radioButton9.Checked)
            {
                score++;
            }
            if (radioButton11.Checked)
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

        private void chezh_test_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
