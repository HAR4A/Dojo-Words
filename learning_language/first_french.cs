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
    public partial class first_french : Form
    {
        public first_french()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр первой формы form1
            Fisrt_hello_Form form1 = new Fisrt_hello_Form();
            // Закрываем текущую (вторую) форму
            this.Close();
            // Отображаем первую форму
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр первой формы form1
            french_test form8 = new french_test();
            // Закрываем текущую (вторую) форму
            this.Close();
            // Отображаем первую форму
            form8.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр первой формы form1
            french_test_2 form16 = new french_test_2();
            // Закрываем текущую (вторую) форму
            this.Close();
            // Отображаем первую форму
            form16.Show();
        }
    }
}
