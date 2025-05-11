using System;
using System.Collections.Generic;
using System.IO;
using Xceed.Words.NET;
using Xceed.Document.NET;

namespace CafeMenu
{
    public class ReceiptGenerator
    {
        public static void GenerateClientReceipt(
            List<(string Name, int Quantity, decimal Price)> items,
            string paymentMethod,
            string tableNumber,
            int discountPercent)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = $"Чек_{DateTime.Now:yyyyMMdd_HHmmss}.docx";
            string path = Path.Combine(desktop, fileName);

            var doc = DocX.Create(path);

            var paragraph = doc.InsertParagraph("Чек клиента").FontSize(16).Bold();
            paragraph.Alignment = Xceed.Document.NET.Alignment.center;

            doc.InsertParagraph($"Дата: {DateTime.Now:dd.MM.yyyy HH:mm:ss}");
            doc.InsertParagraph($"Метод оплаты: {paymentMethod}");
            doc.InsertParagraph($"Столик: {tableNumber}");

            var table = doc.AddTable(items.Count + 1, 4);
            table.Design = TableDesign.TableGrid;

            table.Rows[0].Cells[0].Paragraphs[0].Append("Блюдо");
            table.Rows[0].Cells[1].Paragraphs[0].Append("Кол-во");
            table.Rows[0].Cells[2].Paragraphs[0].Append("Цена");
            table.Rows[0].Cells[3].Paragraphs[0].Append("Сумма");

            decimal total = 0;

            for (int i = 0; i < items.Count; i++)
            {
                var item = items[i];
                decimal sum = item.Quantity * item.Price;
                total += sum;

                table.Rows[i + 1].Cells[0].Paragraphs[0].Append(item.Name);
                table.Rows[i + 1].Cells[1].Paragraphs[0].Append(item.Quantity.ToString());
                table.Rows[i + 1].Cells[2].Paragraphs[0].Append($"{item.Price}₽");
                table.Rows[i + 1].Cells[3].Paragraphs[0].Append($"{sum}₽");
            }

            decimal discountAmount = total * discountPercent / 100;
            decimal finalTotal = total - discountAmount;

            doc.InsertTable(table);
            doc.InsertParagraph($"Сумма без скидки: {total}₽").SpacingBefore(10);
            doc.InsertParagraph($"Скидка: {discountPercent}% (-{discountAmount:0.00}₽)");
            doc.InsertParagraph($"Итого к оплате: {finalTotal:0.00}₽").Bold();

            doc.Save();
        }
    }
}
