using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Can_I_do
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
            Account.UserlistLoad();
        }
        private void SignUp_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form2());
        }

        private void ChatOpen()
        {
            
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            bool checkUsername = default;
            bool checkPassword = default;
           
            int length = Account.Size();
            for (int i = 0; i < length; i++)
            {
                if (Account.GetUser(i).Username == textBox1.Text)
                {
                    if (Account.GetUser(i).Password == textBox2.Text)
                    {
                        ChatOpen();
                        MessageBox.Show("Hello");
                        Git.GitPush();
                        return;
                    }
                }
            }

        }
    }
}
