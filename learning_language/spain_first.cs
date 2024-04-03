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
    public partial class spain_first : Form
    {
        public spain_first()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр первой формы form1
            Fisrt_hello_Form form1 = new Fisrt_hello_Form();
            // Закрываем текущую (вторую) форму
            this.Close();
            // Отображаем первую форму
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр первой формы form1
            spain_test form10 = new spain_test();
            // Закрываем текущую (вторую) форму
            this.Close();
            // Отображаем первую форму
            form10.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр первой формы form1
            spain_test_2 form17 = new spain_test_2();
            // Закрываем текущую (вторую) форму
            this.Close();
            // Отображаем первую форму
            form17.Show();
        }
    }
}
