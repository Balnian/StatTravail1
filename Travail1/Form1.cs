using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail1
{
    public partial class Form1 : Form
    {
        private String Destination;
        private String Sources;
        private List<string> Info = new List<string>();
        private int[] Number;
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Source_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Filter = "Fichier Excel (*.xlsx)|*.xlsx|CSV (*.csv)|*.csv";
           
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                if ((TB_Source.Text = OpenFile.FileName) != "")
                {                 
                    Sources = OpenFile.FileName;
                }            
            }
        }

        private void SavedFile()
        {
            FolderBrowserDialog savedFile = new FolderBrowserDialog();
            if (savedFile.ShowDialog() == DialogResult.OK)
            {
                if ((TB_Sortie.Text = savedFile.SelectedPath)!= "")
                {
                    Destination = savedFile.SelectedPath;
                }           
            }       
        }

        private void BT_Executer_Click(object sender, EventArgs e)
        {
              Number = new int[int.Parse(NUD_Taille.Value.ToString())];
              ExcelWrapper EW = new ExcelWrapper(Sources, Destination);
              ExcelWrapper Ewr = new ExcelWrapper(Sources, Destination);
              EW.Open();
            if (RB_Simple.Checked)
                AleatoirFunction(EW);
            else
                SystematiqueFunction(EW);

            for (int i = 0; i < NUD_Copie.Value; i++)
            {
                Ewr.Write(ReadInfo(EW, Number), int.Parse(NUD_Taille.Value.ToString()), EW.GetnbColumns(), TB_Nom.Text + (i + 1));
            }
            EW.Close();
            Ewr.Close();
        }

        private void SystematiqueFunction(ExcelWrapper EW)
        {
            GetSystematicNumber(EW);        
        }

        private void AleatoirFunction(ExcelWrapper EW)
        {
            GetRandomNumber(EW);     
        }

        private int GenerateRandom(int Max)
        {
          Random rnd = new Random();
          return rnd.Next(1, Max);
        
        }
        private String[,] ReadInfo(ExcelWrapper EW , int[] Ligne)
        {   
           String[,] Data  = new String [Ligne.Length,EW.GetnbColumns()];
           String[] carry = new String[EW.GetnbColumns()];
            int w = 0; //pas le choix sinon avec ma boucle je commence a 0 et boom
                   
           for (int i = 0; i < Ligne.Length; i++)
			{           
                   carry = EW.GetLine(Ligne[w]); //out of range ici je sais pas encore pourquoi
                   for (int j = 0; j < EW.GetnbColumns(); j++)
			    {
                   Data[i, j] = carry[j];                 
			    }
               w++;
			}     
           return Data;
        
        }
        private void BT_Sortie_Click(object sender, EventArgs e)
        {
            SavedFile();

        }

        /// <summary>
        /// Génère une liste de liqne pointant sur les lignes choisi pour faire partie de l'échantillon de manière aléatoire
        /// </summary>
        /// <param name="e"></param>
        private void GetRandomNumber(ExcelWrapper e)
        {           
            int Rnumber;
            for (int i = 0; i < NUD_Taille.Value; i++)
            {
                do
                {
                   Rnumber =  GenerateRandom(e.GetNbRows()-1)+1;                   
                } while (Verif(Number,Rnumber));
                Number[i] = Rnumber;
            }        
        }

        private bool Verif(int[] array,int Rnumber)
        {
            return array.Contains(Rnumber);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] == Rnumber)
            //        return true;
            //}
            //return false;
        }

        /// <summary>
        /// Génère une liste de liqne pointant sur les lignes choisi pour faire partie de l'échantillon de manière systematique
        /// </summary>
        /// <param name="e"></param>
        private void GetSystematicNumber(ExcelWrapper e)
        {

            
            int Step = e.GetNbRows()-1 / (int)NUD_Taille.Value;
            int Nrandom = GenerateRandom(Step)+1;


            Number[0] =  Nrandom;
            for (int i = 1; i < NUD_Taille.Value; i++)
            {
                Number[i] = Nrandom + Step*i;
            }              
        }

        private bool AllEntryValide()
        {
            Boolean valide = false;
            valide |= String.IsNullOrEmpty(TB_Nom.Text);
            valide |= String.IsNullOrEmpty(TB_Source.Text) || !System.IO.Directory.Exists(TB_Source.Text);
            valide |= String.IsNullOrEmpty(TB_Sortie.Text) || !System.IO.Directory.Exists(TB_Sortie.Text);
            return !valide;
        }

        private void BT_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TB_Nom_TextChanged(object sender, EventArgs e)
        {
            BT_Executer.Enabled = AllEntryValide();
        }

        private void TB_Source_TextChanged(object sender, EventArgs e)
        {
            BT_Executer.Enabled = AllEntryValide();
        }

        private void TB_Sortie_TextChanged(object sender, EventArgs e)
        {
            BT_Executer.Enabled = AllEntryValide();
        }
    }
}
