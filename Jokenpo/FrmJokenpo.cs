using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jokenpo
{
    public partial class FrmJokenpo : MetroFramework.Forms.MetroForm
    {

       

        int jogador1 = 0;
        int jogador2 = 0;

        public FrmJokenpo()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            Sort sor = new Sort();
            
            int randomico = sor.Sorteio();
            int randomico2 = sor.Sorteio();

            if (randomico == 0)
            {   //PAPEL
                pct1.Image = Properties.Resources.papel;
            }
            if (randomico == 1)
            {   //PEDRA
                pct1.Image = Properties.Resources.pedra;
            }
            if (randomico == 2)
            {   //TESOURA
                pct1.Image = Properties.Resources.tesoura;
            }
    


            if (randomico2 == 0)
            {   //PAPEL
                pct2.Image = Properties.Resources.papel;
            }
            if (randomico2 == 1)
            {   //PEDRA
                pct2.Image = Properties.Resources.pedra;
            }
            if (randomico2 == 2)
            {   //TESOURA
                pct2.Image = Properties.Resources.tesoura;
            }



            if (randomico2 == randomico)
            {
                lstbox.Items.Add("Empate");
            }


            if (randomico == 0 && randomico2 == 1)//papel vs pedra
            {
                lstbox.Items.Add("Jogador 1");
                jogador1++;
            }
            if (randomico2 == 0 && randomico == 1)
            {
                lstbox.Items.Add("Jogador 2");
                jogador2++;
            }


            if (randomico == 2 && randomico2 == 1)//tesoura vs pedra
            {
                lstbox.Items.Add("Jogador 1");
                jogador1++;
            }
            if (randomico2 == 2 && randomico == 1)
            {
                lstbox.Items.Add("Jogador 2");
                jogador2++;
            }



            if (randomico == 2 && randomico2 == 0)//tesoura vs papel
            {
                lstbox.Items.Add("Jogador 1");
                jogador1++;
            }
            if (randomico2 == 2 && randomico == 0)
            {
                lstbox.Items.Add("Jogador 2");
                jogador2++;
                
            }

            label1.Text = jogador1.ToString();
            label2.Text = jogador2.ToString();
        }

     
    }  
}
