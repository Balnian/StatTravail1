using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace Travail1
{
    class ExcelWrapper
    {
        private Application App = new Application();
        private Workbook Wrb;
        private Worksheet Wrs;
        private String PathSource;
        private String Name;
        private System.Collections.Specialized.StringCollection Data2;
        public int Length {get;set;}
        public int Width{get;set;}
        public ExcelWrapper(String Source, String Name)
        {
            PathSource = Source;
            this.Name = Name; 
            //App = App.Workbooks.Open("csharp.net-informations.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
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
       
             for (int i = 1; i <3 ; i++) //trouvons pourvoir column.count ne marche pas il depassse toujours 
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
            for (int i = 1; i < Wrs.Rows.Count  && Wrs.Cells.Value2 != null; i++)
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

        public void  Write()
        {

                Workbook newWorkbook;
                Worksheet newWorksheet;
                object misValue = System.Reflection.Missing.Value;
                newWorkbook = App.Workbooks.Add();
                newWorksheet = (Worksheet)newWorkbook.Worksheets.Item[1];
                newWorksheet.Cells[1, 1] = "test";
                newWorkbook.SaveAs(@"C:\Users\Razma\Desktop\testtt.xls");
                newWorkbook.Close();
                App.Quit();
         
         
        }
       //private ~ExcelWrapper() 
       //{
       //    Wrb.Close();
       //    App.Close();
       // }


    }
}
