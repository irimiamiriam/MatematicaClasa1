using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematicaClasa1.QuestionForms
{
    public partial class FormFelicitari : Form
    {
        public int scor;
        public string timp;
        public FormFelicitari()
        {
            InitializeComponent();
        }

        private void FormFelicitari_Load(object sender, EventArgs e)
        {
            labelscor.Text = "scor:" + scor;
            labeltimp.Text = "timp:" + timp ;
        }
    }
}
