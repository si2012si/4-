using System;
using System;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace convert_access_to_exel
{
    internal class Program
    {
     
            static void Main(string[] args)
            {
                // подключение к БД Access
                string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\database.mdb;";
                OleDbConnection conn = new OleDbConnection(connString);
                conn.Open();
                // выборка данных из таблицы Товары
                string query = "SELECT Наименование, количество, цена, стоимость FROM Товары";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                // создание документа Word и заполнение таблицы данными
                Application wordApp = new Application();
                Document doc = wordApp.Documents.Add();
                Table table = doc.Tables.Add(doc.Range(), reader.FieldCount, reader.RecordsAffected + 1);
                // заголовки столбцов
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    table.Cell(1, i + 1).Range.Text = reader.GetName(i);
                }
                // данные таблицы
                int row = 2;
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        table.Cell(row, i + 1).Range.Text = reader[i].ToString();
                    }
                    row++;
                }
                // сохранение документа Word
                doc.SaveAs2("C:\\table.docx");
                doc.Close();
                // создание документа Excel и заполнение таблицы данными
                Application excelApp = new Application();
                Workbook workbook = excelApp.Workbooks.Add();
                Worksheet worksheet = workbook.Sheets[1];
                // заголовки столбцов
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    worksheet.Cells[1, i + 1] = reader.GetName(i);
                }
                // данные таблицы
                row = 2;
                reader.Close(); // необходимо закрыть ридер и выполнить запрос еще раз
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        worksheet.Cells[row, i + 1] = reader[i].ToString();
                    }
                    row++;
                }
                // сохранение документа Excel
                workbook.SaveAs("C:\\table.xlsx");
                excelApp.Quit();
                // закрытие подключения БД
                conn.Close();
            }
        }
    }
}
}
