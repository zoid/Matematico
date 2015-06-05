using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excel = Microsoft.Office.Interop.Excel;

namespace Matematico.Tournaments
{
    public class ExcelParser
    {
        Excel.Application app = new Excel.Application();
        Excel.Worksheet Sheet;

        public ExcelParser()
        {
            if(app == null)
            {
                throw new Exception("EXCEL nebyl nalezen, ujistěte se, že je na pc nainstalována aktuální verze MS Excel. Případně vypněte v nastavení " +
                                    "možnost \"Ukládat výsledky do excelu\"");
            }

            app.Visible = false;

            Excel.Workbook wb = app.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Sheet = (Excel.Worksheet)wb.Worksheets[1];
        }

        public void CreateHeader(string tournamentName)
        {
            Sheet.Cells[1, 1] = "Název Turnaje: ";
            Sheet.Cells[1, 1].Font.Bold = true;

            Sheet.Cells[1, 2] = tournamentName;

            Sheet.get_Range("A:A", System.Type.Missing).EntireColumn.ColumnWidth = 20;

            Sheet.Cells[3, 1].EntireRow.Font.Bold = true;

            Sheet.Cells[3, 1] = "Jméno";
            Sheet.Cells[3, 2] = "1. kolo";
            Sheet.Cells[3, 3] = "2. kolo";
            Sheet.Cells[3, 4] = "3. kolo";
            Sheet.Cells[3, 5] = "Celkem";
        }

        public void WriteNames(string[] names)
        {
            if (Sheet == null)
            {
                throw new Exception("EXCEL nebyl nalezen, ujistěte se, že je na pc nainstalována aktuální verze MS Excel. Případně vypněte v nastavení " +
                                    "možnost \"Ukládat výsledky do excelu\"");
            }

            for (int i = 0; i < names.Length;i++ )
            {
                Sheet.Cells[4 + i, 1] = names[i];
            }
        }
    }
}
