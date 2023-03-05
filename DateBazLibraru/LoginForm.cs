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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.BoxPass.AutoSize = false;
            this.BoxPass.Size = new Size(this.BoxPass.Size.Width,27);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void labelavtr_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           Application.Exit();
         //   Close();
         
;
        }
        Point col;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)
            {
                this.Left +=e.X - col.X;
                this.Top += e.Y - col.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            col = new Point(e.X, e.Y);
        }

        private void GoTu_Click(object sender, EventArgs e)
        {
            String log = BoxLog.Text;//создали  переменную поместили в ее память значение из текст бокса   
            String Pass = BoxPass.Text;
            DB db = new DB();


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(); //создали память под адаптер

           // MySqlCommand comm = new MySqlCommand("SELECT * FROM readeers WHERE login = @uL AND password = @uP",db.getConnection()); это если для юзеров
            //Выбрать все элементы из бд юзер с таким логином и паролем c @ заглушки
            MySqlCommand comm = new MySqlCommand("SELECT * FROM adminisstrators WHERE login = @uL AND PASSWORD = @uP", db.getConnection());

            comm.Parameters.Add("@uL", MySqlDbType.VarChar).Value = log; //внесли в заглушку значение переменной
            comm.Parameters.Add("@uP", MySqlDbType.VarChar).Value = Pass;

            adapter.SelectCommand= comm;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                // this.Hide();
                //  MainForm mainfo = new MainForm();   
                // mainfo.ShowDialog();
              
                Bazess baz = new Bazess();
             //   Bazess.Set_ip(newIp);
                this.Hide();
                baz.ShowDialog();
            } 
            else
                MessageBox.Show("Данные введены не верно,проверьте правильность заполнения");
        }

        private void BoxLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registr_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrs registrs = new Registrs();

            registrs.Show();

        }
    }
}

