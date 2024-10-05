using MatematicaClasa1.Resurse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematicaClasa1.QuestionForms
{
    public partial class FormIntrebare : Form
    {

        List<Intrebare> intrebari= new List<Intrebare>();
        string path = @"C:\Users\Miriam\Documents\Aplicatii C\Proiecte CSHARP\MatematicaClasa1\Resurse\Intrebari.txt";
        int indInt;
        int lat, h;
        int x; int y;
        int corAct;
        int scor;
        int timp;
        int minute, secunde;
        
        public FormIntrebare()
        {
            InitializeComponent();
        }

        private void FormIntrebare_Load(object sender, EventArgs e)
        {
            timer.Start();
            lat = (panelIntrebari.Width / 2) - 10;
            h= (panelIntrebari.Height / 2) - 10;
            using (StreamReader reader = new StreamReader(path)) {
                while (reader.Peek() > 0) {
                    string[] line = reader.ReadLine().Split(';');
                    Intrebare intrebare = new Intrebare()
                    {
                        Enunt = line[0],
                        Raspunsuri= new string[4] { line[1], line[2], line[3], line[4]},
                        RaspunsCorect= Convert.ToInt32(line[5])
                        
                    };
                    intrebari.Add(intrebare);
                }
                
            }
            IntrebareNoua();
        }

        private void IntrebareNoua()
        {
            if (indInt < intrebari.Count)
            {
                x = y = 0;
                panelIntrebari.Controls.Clear();
                Intrebare intrebare = intrebari[indInt];
                label.Text = intrebare.Enunt;
                corAct = intrebare.RaspunsCorect;
                for (int i = 0; i < 4; i++)
                {
                    Button button = new Button()
                    {
                        Width = lat,
                        Height = h,
                        BackColor = Color.Gold,
                        Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        Text = intrebare.Raspunsuri[i],
                        Tag = (i + 1).ToString(),
                        Location = new Point(x, y),


                    };
                    button.Click += button_Click;
                    panelIntrebari.Controls.Add(button);
                    x += lat + 10;
                    if (i == 1)
                    {
                        x = 0;
                        y = h + 10;
                    }
                }
            }
            else
            {
                FormFelicitari form = new FormFelicitari();
                form.scor = scor;
                form.timp = labelceas.Text;
                this.Hide();
                form.ShowDialog();
                this.Close();

            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string min=null, sec=null;
            timp++;
            minute = timp / 60;
            secunde = timp - minute * 60;

            if (minute < 10) { min = "0" + minute; }
            else { min = minute.ToString(); }
            if (secunde < 10) { sec = "0" + secunde; }
            else { sec = secunde.ToString(); }
           
            labelceas.Text = min+":"+sec;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (Convert.ToInt32(button.Tag)==corAct) {
                scor += 10;
            }   indInt++;
                IntrebareNoua();
        }
    }
}
