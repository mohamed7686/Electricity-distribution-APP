using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace myDataBase
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel()
        {

        }

        public Excel(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];

        }

        public string readCell(int i, int j)
        {
            string s = "";
            if (ws.Cells[i, j].Value2 != null)
            {
                s = (ws.Cells[i, j].Value2).ToString();
                return s;
            }
            else { return ""; }
        }

        public int sumrang(int istart ,int jstart ,int iend ,int jend)
        {
            int s = 0;
            for (int i = istart; i <= iend; i++)
            {
                for (int j = jstart; j <= jend; j++)
                {
                    if (ws.Cells[i, j].Value2 != null)
                    {
                        s += (ws.Cells[i, j].Value2);
                       
                    }
                    else {  }
                }
            }
            return s;
        }


        public void writeCell(int i, int j, string s)
        {
            ws.Cells[i, j].Value2 = s;
        }

        public void save()
        {
            wb.Save();
        }

        public void saveAs(string path)
        {
            wb.SaveAs(path);
        }

        public void close()
        {
            wb.Close();
        }

        public void show()
        {

            this.wb.Application.Visible = true;

        }
        public void print(int sheet , int copies)
        {
            wb.PrintOutEx(sheet, sheet, copies, true);
        }

       

        public void nfile()
        {
            this.wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
        }

        public void nsheet()
        {
            Worksheet temptsheet = wb.Worksheets.Add(After: ws);
            this.ws = wb.Worksheets[1];
        }

        public void selectSheet(int sheet)
        {
            this.ws = wb.Worksheets[sheet];
        }



        public string[,] readRange(int starti, int startj, int endi, int endj)
        {
            Range range = (Range)ws.Range[ws.Cells[starti, startj], ws.Cells[endi, endj]];
            object[,] holder = range.Value;
            string[,] retstring = new string[endi - starti, endj - startj];
            for (int i = 1; i <= (endi - starti); i++)
            {
                for (int j = 1; j <= (endj - startj); j++)
                {
                    retstring[i - 1, j - 1] = holder[i, j].ToString();
                }
            }
            return retstring;
        }


        public void writeRange(int starti, int startj, int endi, int endj, string[,] str)
        {
            Range range = (Range)ws.Range[ws.Cells[starti, startj], ws.Cells[endi, endj]];
            range.Value = str;
        }






    }
}
