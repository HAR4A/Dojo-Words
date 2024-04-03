namespace learning_language
{
    public partial class form_eng_first : Form
    {
        public form_eng_first()
        {
            InitializeComponent();
            
        }

        private void form_eng_first_Load(object sender, EventArgs e)
        {

        }

        private void form_eng_first_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Создаем экземпляр второй формы - form2
            eng_test_form form4 = new eng_test_form();
            // Скрываем текущую (первую) форму
            this.Hide();
            // Отображаем вторую форму
            form4.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //кнопка назад (обратно к main.form)
        private void button2_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр первой формы form1
            Fisrt_hello_Form form1 = new Fisrt_hello_Form();
            // Закрываем текущую (вторую) форму
            this.Close();
            // Отображаем первую форму
            form1.Show();
        }

        private void form_eng_first_Load_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр второй формы - form2
            eng_test_2 form14 = new eng_test_2();
            // Скрываем текущую (первую) форму
            this.Hide();
            // Отображаем вторую форму
            form14.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}