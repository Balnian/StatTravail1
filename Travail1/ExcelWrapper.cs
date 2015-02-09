using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
namespace Travail1
{
    class ExcelWrapper
    {
        private Application App = new Application();
        private Workbook Wrb;
        private Worksheet Wrs;
        private String PathSource;
        private String Destination;
        private String Name;
        private System.Collections.Specialized.StringCollection Data2;
        public int Length {get;set;}
        public int Width{get;set;}
        public ExcelWrapper(String Source, String Destination)
        {
            PathSource = Source;
            this.Destination = Destination;           

        }
        public void Open()
        {              
            Wrb =   App.Workbooks.Open(PathSource);
            Wrs = Wrb.ActiveSheet;         
        }

        public String[] GetLine(int Line)
        {
            String[] Data = new String[Wrs.UsedRange.Columns.Count];
            Range carry;
            int j = 0;     
             for (int i = 1; i <= Wrs.UsedRange.Columns.Count; i++) //trouvons pourvoir column.count ne marche pas il depassse toujours 
            {
                carry = Wrs.Cells[Line, i];
                object OBJ = carry.Value2;
                Data[j] = (OBJ.ToString());
                j++;
            }
            return Data;
        }

        public String[] GetColumn(int Col)
        {
            String[] Data = new String[Wrs.UsedRange.Rows.Count];
            Range carry;

            for (int i = 1; i <= Wrs.UsedRange.Rows.Count  ; i++)
            {
                carry = Wrs.Cells[i, Col];
                object OBJ = carry.Value2;
                Data[i]= (OBJ.ToString());
            }
            return Data;
        }

        public string GetCell(int Line, int Col)
        {
            Range carry;
            carry = Wrs.Cells[Line, Col];
            object OBJ = carry.Value2;

            return OBJ.ToString();
        }

        public void  Write(String[,] data,int Line,int column, String FileName)
        {
            //Il faut la reicrire pour parcourir la liste
            Wrb = App.Workbooks.Add();
            Wrs = (Worksheet)Wrb.Worksheets.Item[1];
            for (int i = 0; i < Line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Wrs.Cells[i + 1, j + 1] = data[i,j];
                }
            }
              
                Wrb.SaveAs(Destination + @"\" + FileName + ".xls");             
        }

        public  String[] GetAllData()
        {
            //System.Collections.Specialized.StringCollection Data = new System.Collections.Specialized.StringCollection();
           
            Excel.Range range = Wrs.get_Range(Wrs.UsedRange);
            System.Array myvalues = (System.Array)range.Cells.Value;
            string[] strArray = ConvertToStringArray(myvalues);

            return strArray;           
            }
        private string[] ConvertToStringArray(System.Array values)
        {

            // create a new string array
            string[] theArray = new string[values.Length];

            // loop through the 2-D System.Array and populate the 1-D String Array
            for (int i = 1; i <= values.Length; i++)
            {
                if (values.GetValue(1, i) == null)
                    theArray[i - 1] = "";
                else
                    theArray[i - 1] = (string)values.GetValue(1, i).ToString();
            }

            return theArray;
        }
       ~ExcelWrapper()
        {
           Wrb.Close();
           App.Quit();        
        }

       public int GetNbRows()
       {
          int rows = Wrs.UsedRange.Rows.Count;
          return rows;
       
       }
       public int GetnbColumns()
       {
           int Column = Wrs.UsedRange.Columns.Count;
           return Column;       
       }
    }
}
