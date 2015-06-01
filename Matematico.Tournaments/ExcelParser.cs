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

        public ExcelParser()
        {
            if(app == null)
            {
                throw new Exception("EXCEL nebyl nalezen, ujistěte se, že je na pc nainstalována aktuální verze MS Excel. Případně vypněte v nastavení " +
                                    "možnost \"Ukládat výsledky do excelu\"");
            }

            app.Visible = true;
        }

        public void WriteNames(string[] names)
        {
            Excel.Workbook wb = app.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];

            if (ws == null)
            {
                throw new Exception("EXCEL nebyl nalezen, ujistěte se, že je na pc nainstalována aktuální verze MS Excel. Případně vypněte v nastavení " +
                                    "možnost \"Ukládat výsledky do excelu\"");
            }

            ws.Cells[1, 1] = "Jméno";

            for (int i = 0; i < names.Length;i++ )
            {
                ws.Cells[2+i,1] = names[i];
            }
        }
    }
}
