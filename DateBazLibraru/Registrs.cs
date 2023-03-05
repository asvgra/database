using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBazLibraru
{
    public partial class Registrs : Form
    {
        public Registrs()
        {
            InitializeComponent();


            textBoxName.Text = "Введите логин";
            textBoxName.ForeColor = Color.Gray;

            textFIOReg.Text = "Введите пароль";
            textFIOReg.ForeColor = Color.Gray;

          //  BoxLogReg.Text = "Введите логин";
          //  BoxLogReg.ForeColor = Color.Gray;
//
        //    BoxPassReg.Text = "Введите пароль";
         //   BoxPassReg.ForeColor = Color.Gray;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point col;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - col.X;
                this.Top += e.Y - col.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            col = new Point(e.X, e.Y);
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Введите логин")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;
            }

        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "Введите логин";
                textBoxName.ForeColor = Color.Gray;
            }

        }

        private void textFIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFIO_Enter(object sender, EventArgs e)
        {
            if (textFIOReg.Text == "Введите пароль")
            {
                textFIOReg.Text = "";
                textFIOReg.ForeColor = Color.Black;
            }
        }

        private void textFIO_Leave(object sender, EventArgs e)
        {
            if (textFIOReg.Text == "")
            {
                textFIOReg.Text = "Введите пароль";
                textFIOReg.ForeColor = Color.Gray;
            }
        }

        private void BoxLog_TextChanged(object sender, EventArgs e)
        {

        }



        private void BoxLog_Enter(object sender, EventArgs e)
        {
            
        }
        private void BoxLog_Leave(object sender, EventArgs e)
        {
           
        }


        private void BoxPass_Enter(object sender, EventArgs e)
        {
           
        }

        private void BoxPass_Leave(object sender, EventArgs e)
        {

           
        }

        private void Registrsh_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (textFIOReg.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
       
            if (checUz())
                return;
            DB db = new DB(); //имеем доступ к функциям с класса DBЫ
            MySqlCommand comm = new MySqlCommand("INSERT INTO `adminisstrators` (`login`,  `password`) VALUES (@name, @surname)", db.getConnection());
            String login = textBoxName.Text;
            String password = textFIOReg.Text;

            comm.Parameters.Add("@name", MySqlDbType.VarChar).Value = login; //внесли в заглушку значение переменной
            comm.Parameters.Add("@surname", MySqlDbType.VarChar).Value = password;
           
            db.open(); // открывает соединение с базой данных

            if (comm.ExecuteNonQuery() == 1)
                MessageBox.Show("Поздравляем Вы успешно зарегистрировались");
            else
                MessageBox.Show("Извините,но аккаунт не может быть создан,проверьте данные или позвоните в библиотеку");



            db.close();

        }

        public Boolean checUz()
        {

            DB db = new DB();


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(); //создали память под адаптер

            MySqlCommand comm = new MySqlCommand("SELECT * FROM readeers WHERE `login` = @uL", db.getConnection());
            //Выбрать все элементы из бд юзер с таким логином и паролем c @ заглушки


            comm.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textBoxName.Text; //внесли в заглушку значение переменной


            adapter.SelectCommand = comm;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Данный логин уже имеется в базе,пожалуйста,придумайте новый");
                return true;
            }

            else
                return false;
        }

        Point coll;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - coll.X;
                this.Top += e.Y - coll.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
     
            coll = new Point(e.X, e.Y);
        }

        private void Registr_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();  
            login.ShowDialog();
        }
    }
}
