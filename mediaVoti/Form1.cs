using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace es5_mediaVoti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            string nome;
            float voto;

            float sommavoti = 0;

            float mediaStud;
            float mediaClasse;

            float sommaMedia = 0;

            for (int i = 1; i <= 20; i++)
            {
                nome = Interaction.InputBox("Inserire nome per alunno numero " + i);
                lstNomi.Items.Add(nome);
                for (int j = 1; j <= 8; j++)
                {
                    voto = Convert.ToSingle(Interaction.InputBox("Inserire il voto della materia numero " + j + " per l'alunno numero " + i));
                    sommavoti += voto;
                }
                mediaStud = sommavoti / 8;
                lstMedie.Items.Add(mediaStud);
                sommavoti = 0;
                sommaMedia += mediaStud;
            }
            mediaClasse = sommaMedia / 20;
            txtMediaClasse.Text = mediaClasse.ToString();
        }
    }
}