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
           //Ewr.Open();
           GetRandomNumber(EW);
        
           for (int i = 0; i < NUD_Copie.Value; i++)
           {
               Ewr.Write(ReadInfo(EW, Number), int.Parse(NUD_Taille.Value.ToString()), EW.GetNbRows(), TB_Nom.Text);
           }
           
          
        }

        private void SystematiqueFunction()
        { 
        
        
        
        
        }

        private void AleatoirFunction()
        { 
        
        
        }

        private int GenerateRandom(int Max)
        {
          Random rnd = new Random();
          return rnd.Next(1, Max);
        
        }
        private String[,] ReadInfo(ExcelWrapper EW , int[] Ligne)
        {   
           String[,] Data  = new String [Ligne.Length,EW.GetnbColumns()];
           String [] carry;
            int w = 1; //pas le choix sinon avec ma boucle je commence a 0 et boom
          // EW.Open();
            
           for (int i = 0; i < Ligne.Length; i++)
			{
               for (int j = 0; j < EW.GetnbColumns(); j++)
			    {
                   carry = EW.GetLine(Ligne[w]); //out of range ici je sais pas encore pourquoi
                   Data[i, j] = carry[j];
                   w++;
			    }			    
			}     
           return Data;
        
        }
        private void BT_Sortie_Click(object sender, EventArgs e)
        {
            SavedFile();

        }
        private void GetRandomNumber(ExcelWrapper e)
        {           
            int Rnumber;
            for (int i = 0; i < NUD_Taille.Value; i++)
            {
                do
                {
                    Rnumber =  GenerateRandom(e.GetNbRows());
                    Number[i] = Rnumber;
                } while (!Verif(Number,Rnumber));            
            }        
        }

        private bool Verif(int[] array,int Rnumber)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == Rnumber)
                    return true;
            }
            return false;
        }
    }
}
