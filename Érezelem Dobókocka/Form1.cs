using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


//2020.04.15.
namespace Érezelem_Dobókocka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_general_Click(object sender, EventArgs e)
        {

            int elozo_veletlenszam = 100;
            if (radioButton_egyszerű_alapérzelmek.Checked)
            {
                string[] szoveg = { "FIGYELEM", "NYUGALOM", "BOLDOGSÁG", "ENERGIKUSSÁG", "BIZALOM", "JÁTÉKOSSÁG", "DÜH", "SZORONGÁS", "SZOMORÚSÁG", "UNALOM", "ZAVARODOTTSÁG", "ÜRESSÉG", "UNDOR" };

                Random rnd = new Random();
                int veletelenszam = rnd.Next(0, szoveg.Length - 1);
                if (veletelenszam != elozo_veletlenszam)
                    textBox1.Text = szoveg[veletelenszam];
                else
                    button_general.PerformClick();
            }


            if (radioButton_Részletes_alapérzelmek.Checked)
            {
                string[] szoveg = { "jóindulat", "segítőkészség","gondoskodás", "együttérzés", "gyengédség", "tisztelet",
"ámulat", "csodálat", "behódolás", "higgadtság", "békesség", "derű",
"harmónia", "ellazultság", "elégedettség",
"gondtalanság", "összeszedettség","öröm", "szeretet", "kiteljesedés",
"jóllét","bizakodás", "optimizmus",
"lelkesedés", "büszkeség", "céltudatosság",
"elszántság","elfogadás", "hála", "izgatottság", "vidámság",
"felszabadultság", "spontaneitás", "kíváncsiság",
"érdeklődés", "nyitottság", "élvezet","elégedetlenség", "frusztráció", "feszültség",
"keserűség", "ingerültség", "bosszúság", "neheztelés",
"idegesség", "harag", "zaklatottság","nyugtalanság", "aggodalom", "félénkség",
"kétségbeesés", "riadalom", "ijedtség", "rémület", "félelem",
"rettegés","bánat", "mélabú", "csüggedtség",
"csalódottság", "boldogtalanság","fásultság", "kedvetlenség", "egykedvűség",
"érdektelenség", "érzéketlenség", "közömbösség","bizonytalanság","tétlenség",
"meglepődés","értetlenség","tehetetlenség","szégyen","bűntudat","lelkiismeretfurdalás",
"kiüresedés","gyűlölet","utálat","lenézés","irtózás","megvetés","kárörvendés" };

                Random rnd = new Random();
                int veletelenszam = rnd.Next(0, szoveg.Length - 1);
                if (veletelenszam != elozo_veletlenszam)
                    textBox1.Text = szoveg[veletelenszam];
                else
                    button_general.PerformClick();
            }

        }
    }
}
