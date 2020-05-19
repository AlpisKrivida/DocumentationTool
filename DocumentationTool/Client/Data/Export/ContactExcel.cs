using DocumentationTool.Client.Data.Export;
using DocumentationTool.Shared.Entities.Contacts;
using Microsoft.JSInterop;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DocumentationTool.Client.Excel
{
    public class ContactExcel
    {
        private int Columns { get; set; } = 7;

        public void GenerateExcel(IJSRuntime ijsRuntime, List<Person> people, bool template)
        {
            byte[] fileContents;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            GeneralExcel ge = new GeneralExcel(Columns +1);

            using (var package = new ExcelPackage())
            {
                var workSheet = package.Workbook.Worksheets.Add("Sheet1");
                var currentRow = 1;

                workSheet.Cells[currentRow, 1].Value = "First Name";
                workSheet.Cells[currentRow, 2].Value = "Last Name";
                workSheet.Cells[currentRow, 3].Value = "Organization";
                workSheet.Cells[currentRow, 4].Value = "Personal number";
                workSheet.Cells[currentRow, 5].Value = "Telephone number";
                workSheet.Cells[currentRow, 6].Value = "E-mail address";
                workSheet.Cells[currentRow, 7].Value = "City";

                ge.GetColumnName(ref workSheet, currentRow);

                if (!template)
                {
                    foreach (var person in people)
                    {
                        currentRow++;
                        workSheet.Cells[currentRow, 1].Value = person.FirstName;
                        workSheet.Cells[currentRow, 2].Value = person.LastName;
                        workSheet.Cells[currentRow, 3].Value = person.Organization;
                        workSheet.Cells[currentRow, 4].Value = person.PersonalNumber;
                        workSheet.Cells[currentRow, 5].Value = person.TelephoneCompany;
                        workSheet.Cells[currentRow, 6].Value = person.EMailAdress;
                        workSheet.Cells[currentRow, 7].Value = person.Description;
                        workSheet.Cells[currentRow, 8].Value = person.City;

                        workSheet = ge.GetColumnData(workSheet, person.General, currentRow);
                    }
                }

                fileContents = package.GetAsByteArray();

            }

            ijsRuntime.InvokeAsync<ContactExcel>(
                    "saveAsFile",
                    "ContactList.xlsx",
                    Convert.ToBase64String(fileContents)
                );
        }
    }
}
