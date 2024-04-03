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
    public partial class german_first : Form
    {
        public german_first()
        {
            InitializeComponent();
        }
        //Кнопка начать
        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр первой формы form1
            german_test form5 = new german_test();
            // Закрываем текущую (вторую) форму
            this.Close();
            // Отображаем первую форму
            form5.Show();
        }
        //Кнопка назад
        private void button2_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр первой формы form1
            Fisrt_hello_Form form1 = new Fisrt_hello_Form();
            // Закрываем текущую (вторую) форму
            this.Close();
            // Отображаем первую форму
            form1.Show();
        }

        private void german_first_Load(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр первой формы form1
            germa_test_2cs form15 = new germa_test_2cs();
            // Закрываем текущую (вторую) форму
            this.Close();
            // Отображаем первую форму
            form15.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
