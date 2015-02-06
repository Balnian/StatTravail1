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
        
        public System.Collections.Specialized.StringCollection GetLine(int Line)
        {
            System.Collections.Specialized.StringCollection Data = new System.Collections.Specialized.StringCollection();
            Range carry;
                  
             for (int i = 1; i < Wrs.UsedRange.Columns.Count ; i++) //trouvons pourvoir column.count ne marche pas il depassse toujours 
            {
                carry = Wrs.Cells[Line, i];
                object OBJ = carry.Value2;
                Data.Add(OBJ.ToString());
            }
            return Data;
        }

        public System.Collections.Specialized.StringCollection GetColumn(int Col)
        {
            System.Collections.Specialized.StringCollection Data = new System.Collections.Specialized.StringCollection();
            Range carry;

           

            for (int i = 1; i < Wrs.UsedRange.Rows.Count  ; i++)
            {
                carry = Wrs.Cells[i, Col];
                object OBJ = carry.Value2;
                Data.Add(OBJ.ToString());
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

        public void  Write(List<object> data, String FileName)
        {
            //Il faut la reicrire pour parcourir la liste
                Workbook newWorkbook;
                Worksheet newWorksheet;
                newWorkbook = App.Workbooks.Add();
                newWorksheet = (Worksheet)newWorkbook.Worksheets.Item[1];
                newWorksheet.Cells[1, 1] = "test";
                newWorkbook.SaveAs(Destination + @"\" + FileName + ".xls");
                newWorkbook.Close();
                App.Quit();                 
        }

        public  String[] GetAllData()
        {
            //System.Collections.Specialized.StringCollection Data = new System.Collections.Specialized.StringCollection();
           
            Excel.Range range = Wrs.get_Range(Wrs.UsedRange);
            System.Array myvalues = (System.Array)range.Cells.Value;
            string[] strArray = ConvertToStringArray(myvalues);

            return strArray;

            //for (int i = 1; i < Wrs.UsedRange.Rows.Count; i++)
            //{
            //   for (int j = 1; j<Wrs.UsedRange.Columns.Count ; j++)
            //   {
            //      Data.Add(GetCell(i, j));
            //   }
           
            //}
            //return Data;

         
           
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


    }
}
