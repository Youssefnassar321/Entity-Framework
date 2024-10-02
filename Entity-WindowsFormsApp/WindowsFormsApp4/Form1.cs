using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.Name = textBox1.Text.Trim();
            st.Grade = textBox2.Text.Trim();
            st.Country = textBox3.Text.Trim();
            st.Email = textBox4.Text.Trim();

            using (TaskWindowsFormEntities db = new TaskWindowsFormEntities()) 
            {
                db.Students.Add(st);
                db.SaveChanges();
            }
        }
    }
}
