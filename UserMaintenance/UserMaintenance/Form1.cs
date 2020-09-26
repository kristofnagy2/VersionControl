using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;
using System.IO;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {

        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();

            label1.Text = Resource1.FullName;
            button1.Text = Resource1.Add;
            button2.Text = Resource1.WriteFile;
            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new User()

            {

                FullName = textBox1.Text


            };

            users.Add(u);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = @"C:\";
            sfd.RestoreDirectory = true;
            sfd.FileName = "*.txt";
            sfd.DefaultExt = "*.txt";
            sfd.Filter = "txt files (*.txt)|*.txt";
            if (sfd.ShowDialog()==DialogResult.OK)


            {
                Stream fileStream = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(fileStream);

                sw.Write(listBox1.Text);
                

                sw.Close();
                fileStream.Close();
               
            }
            
              

                
            {

            }
        }
    }
}
