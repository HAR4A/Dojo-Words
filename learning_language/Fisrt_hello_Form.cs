using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace learning_language
{
    public partial class Fisrt_hello_Form : Form
    {
        public Fisrt_hello_Form()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Fisrt_hello_Form_Load(object sender, EventArgs e)
        {

        }
       

        //КНОПКА АНГЛИЙСКОГО
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Создаем экземпляр второй формы - form2
            form_eng_first form2 = new form_eng_first();
            // Скрываем текущую (первую) форму
            this.Hide();
            // Отображаем вторую форму
            form2.Show();
        }

        //кнопка НЕМЕЦКОГО
        private void button2_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр второй формы - form2
            german_first form3 = new german_first();

            // Скрываем текущую (первую) форму
            this.Hide();
            // Отображаем вторую форму
            form3.Show();
        }
        // кнопка закрыть
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void First_hello_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        //кнопка чешский
        private void button5_Click(object sender, EventArgs e)
        {
            chezh_first form11 = new chezh_first();
            this.Hide();
            form11.Show();
        }


        //кнопка французский
        private void button3_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр первой формы form1
            first_french form7 = new first_french();
            // Закрываем текущую (вторую) форму
            this.Hide();
            // Отображаем первую форму
            form7.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        //кнопка испанский
        private void button4_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр второй формы - form2
            spain_first form9 = new spain_first();
            // Скрываем текущую (первую) форму
            this.Hide();
            // Отображаем вторую форму
            form9.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
