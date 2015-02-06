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
            //OpenFile.InitialDirectory = getLastDirectory();
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                if ((TB_Source.Text = OpenFile.FileName) != "")
                {
                   // Properties.Settings.Default.LastSaveDirectory = CurrentFile.Remove(CurrentFile.LastIndexOf('\\'));
                   // OpenData();
                    Sources = OpenFile.FileName;
                }
                //AddRecentFile(OpenFile.FileName);
            }
        }

        private void SavedFile()
        {

            SaveFileDialog savedFile = new SaveFileDialog();
            if (savedFile.ShowDialog() == DialogResult.OK)
            {
                if ((TB_Sortie.Text = savedFile.FileName)!= "")
                {
                    Destination = savedFile.FileName;
                }           
            }       
        }

        private void BT_Executer_Click(object sender, EventArgs e)
        {


          
        


           System.Collections.Specialized.StringCollection Data = new System.Collections.Specialized.StringCollection();

           ExcelWrapper EW = new ExcelWrapper(Sources, Destination);
           EW.Open();
           Data = EW.GetAllData();
          
           foreach (String data in Data)
           {
              Info.Add(data);
              MessageBox.Show(data);
           }          
          
        }

        private void SystematiqueFunction()
        { 
        
        
        
        
        }

        private void AleatoirFunction()
        { 
        
        
        }
        private void ReadInfo()
        {
           ExcelWrapper EW = new ExcelWrapper(Sources, Destination);
           System.Collections.Specialized.StringCollection Data = new System.Collections.Specialized.StringCollection();
           EW.Open();
           Data = EW.GetAllData();

           foreach (String data in Data)
           { 
            Info.Add(data);         
           }
        
        }
        private void BT_Sortie_Click(object sender, EventArgs e)
        {
            SavedFile();

        }
    }
}
