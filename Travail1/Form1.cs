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

                }
                //AddRecentFile(OpenFile.FileName);
            }
        }

        private void BT_Executer_Click(object sender, EventArgs e)
        {

            System.Collections.Specialized.StringCollection Data = new System.Collections.Specialized.StringCollection();
            ExcelWrapper EW = new ExcelWrapper(TB_Source.Text, "Baba");
            //EW.Open();
            //Data = EW.GetLine(1);
            //foreach( string OBJ in Data)
            //{

            //    MessageBox.Show(OBJ);
            //}
            EW.Write();
        }
    }
}
