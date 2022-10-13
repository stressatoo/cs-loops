using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace es1_stadio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            const byte cC = 15;
            const byte cT = 30;
            const byte cD = 55;

            const float scontoPerc = 3;

            float accumulatore = 0;

            string fine = "";

            byte nBiglietti;
            string tipoBiglietto;

            float imp = 0;
            float sconto;

            do
            {
                nBiglietti = Convert.ToByte(Interaction.InputBox("Inserire numero biglietti"));
                tipoBiglietto = Interaction.InputBox("Inserire tipo biglietto: Curva, Tribuna o Distinto");
                switch (tipoBiglietto)
                {
                    case "Curva":
                        imp = cC * nBiglietti;
                        break;
                    case "Tribuna":
                        imp = cT * nBiglietti;
                        break;
                    case "Distinto":
                        imp = cD * nBiglietti;
                        if (nBiglietti > 10)
                        {
                            sconto = (imp * scontoPerc) / 100;
                            imp -= sconto;
                        }
                        break;
                }
                accumulatore += imp;
                lstImporto.Items.Add(imp);
                fine = Interaction.InputBox("Finire il turno? Sì / No");
            } while (fine == "No" || fine == "no" || fine == "NO");
            txtIncassoTotale.Text = accumulatore.ToString();
        }
    }
}
