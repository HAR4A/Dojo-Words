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
    public partial class chezh_first : Form
    {
        public chezh_first()
        {
            InitializeComponent();
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
            chezh_test form13 = new chezh_test();
            // Закрываем текущую (вторую) форму
            this.Close();
            // Отображаем первую форму
            form13.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр первой формы form1
            chezh_test_2 form18 = new chezh_test_2();
            // Закрываем текущую (вторую) форму
            this.Close();
            // Отображаем первую форму
            form18.Show();
        }
    }
}
