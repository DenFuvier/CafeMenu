using Xceed.Words.NET;
using System;
using System.Collections.Generic;
using System.IO;
using Xceed.Document.NET;

namespace CafeMenu.General
{
    public class KitchenOrderGenerator
    {
        public static void GenerateKitchenOrder(List<(string Name, int Quantity)> items, string tableNumber, int orderNumber)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm");
            string fileName = $"Кухонный_чек_№{orderNumber}_{timestamp}.docx";
            string path = Path.Combine(desktop, fileName);

            var doc = DocX.Create(path);

            doc.InsertParagraph($"Заказ на кухню — №{orderNumber}")
                .FontSize(16)
                .Bold()
                .Alignment = Alignment.center;

            doc.InsertParagraph($"Столик: {tableNumber}");
            doc.InsertParagraph($"Дата: {DateTime.Now:dd.MM.yyyy HH:mm:ss}");

            var table = doc.AddTable(items.Count + 1, 2);
            table.Design = TableDesign.LightShadingAccent1;
            table.Rows[0].Cells[0].Paragraphs[0].Append("Блюдо");
            table.Rows[0].Cells[1].Paragraphs[0].Append("Кол-во");

            for (int i = 0; i < items.Count; i++)
            {
                table.Rows[i + 1].Cells[0].Paragraphs[0].Append(items[i].Name);
                table.Rows[i + 1].Cells[1].Paragraphs[0].Append(items[i].Quantity.ToString());
            }

            doc.InsertTable(table);
            doc.Save();
        }
    }
}