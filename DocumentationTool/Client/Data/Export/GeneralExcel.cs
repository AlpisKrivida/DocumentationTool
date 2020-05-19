using DocumentationTool.Shared.Entities.Hardware;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Data.Export
{
    public class GeneralExcel
    {
        private int Columns { get; set; } = 7;
        private int Offset { get; set; }

        public GeneralExcel(int Offset)
        {
            this.Offset = Offset;
        }

        public int GetOffset()
        {
            return Offset;
        }

        public ExcelWorksheet GetColumnName(ref ExcelWorksheet ew, int row)
        {
            if (ew != null)
            { 
                ew.Cells[row, Offset + 1].Value = "Title";
                ew.Cells[row, Offset + 2].Value = "Purpose";
                ew.Cells[row, Offset + 3].Value = "Status";
                ew.Cells[row, Offset + 4].Value = "CreationDate";
                ew.Cells[row, Offset + 5].Value = "DateOfChange";
                ew.Cells[row, Offset + 6].Value = "Tags";
                ew.Cells[row, Offset + 7].Value = "Description";
            }
            return ew;
        }

        public ExcelWorksheet GetColumnData(ExcelWorksheet ew, General general, int row)
        {
            if (general != null && ew != null)
            {
                ew.Cells[row, Offset + 4].Style.Numberformat.Format = "dd-MM-yyyy HH:mm";
                ew.Cells[row, Offset + 5].Style.Numberformat.Format = "dd-MM-yyyy HH:mm";

                ew.Cells[row, Offset+1].Value = general.Title;
                ew.Cells[row, Offset+2].Value = general.Purpose;
                ew.Cells[row, Offset+3].Value = general.Status;
                ew.Cells[row, Offset+4].Value = general.CreatioDate; 
                ew.Cells[row, Offset+5].Value = general.DateOfChange;
                ew.Cells[row, Offset+6].Value = general.Tag;
                ew.Cells[row, Offset+7].Value = general.Description;
            }

            return ew;
        }
    }
}
