using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatematicaClasa1.QuestionForms;

namespace MatematicaClasa1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //asdasd
            InitializeComponent();  //adsfsgdfhg
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormIntrebare form = new FormIntrebare();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
