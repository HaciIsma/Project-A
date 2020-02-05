using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Can_I_do
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool checkUserName = default;
            for (int i = 0; i < Account.Size(); i++)
            {
                if (Account.GetUser(i).Username == _name.Text)
                {
                    checkUserName = true;
                }
            }
            if (!checkUserName)
            {
                Account.AddUser(new User { Username = _name.Text, Password = _password.Text, Name = _name.Text, Lastname = _lastname.Text, Age = _age.Text });
            }
            else
            {
                MessageBox.Show("This username exists try another username");
            }
        }
    }
}
