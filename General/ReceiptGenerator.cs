using CafeMenu.General;
using System;
using System.Collections.Generic;
using System.IO;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace CafeMenu
{
    public static class ReceiptGenerator
    {
        public static void GenerateClientReceipt(Order order, List<(string Name, int Quantity, decimal Price)> items)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string timestamp = order.OrderDate.ToString("yyyy-MM-dd_HH-mm");
            string fileName = $"Клиентский_чек_№{order.DailyNumber}_{timestamp}.docx";
            string path = Path.Combine(desktop, fileName);

            var doc = DocX.Create(path);

            doc.InsertParagraph($"Клиентский чек — Заказ №{order.DailyNumber}")
               .FontSize(16)
               .Bold()
               .Alignment = Alignment.center;

            doc.InsertParagraph($"Дата: {order.OrderDate:dd.MM.yyyy HH:mm:ss}");
            doc.InsertParagraph($"Метод оплаты: {order.PaymentMethod}");
            doc.InsertParagraph($"Столик: {order.TableNumber}");

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
                table.Rows[i + 1].Cells[2].Paragraphs[0].Append($"{item.Price:0.00}₽");
                table.Rows[i + 1].Cells[3].Paragraphs[0].Append($"{sum:0.00}₽");
            }

            decimal discountAmount = total * order.Discount / 100;
            decimal finalTotal = total - discountAmount;

            doc.InsertTable(table);
            doc.InsertParagraph($"Сумма без скидки: {total:0.00}₽").SpacingBefore(10);
            doc.InsertParagraph($"Скидка: {order.Discount}% (-{discountAmount:0.00}₽)");
            doc.InsertParagraph($"Итого к оплате: {finalTotal:0.00}₽").Bold();

            doc.Save();
        }
    }
}
