using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ToDoApplication.AppData;

namespace ToDoApplication.Actions
{
    public class DeleteAction
    {
        public void Delete()
        {
        againDelete:
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");

            string cardTitle = Console.ReadLine();

            Card card = Data.Cards.FirstOrDefault(x => x.Title == cardTitle);
            if (card != null)
            {
                Data.Cards.Remove(card);

                Console.WriteLine($"{card.Title} başlıklı kart {card.BoardType} listesinden silindi.");
                Console.WriteLine("Silme işlemi tamamlandı.");
            }

            else
            {
            againChoice:
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)" +
                    "\n* Yeniden denemek için : (2)");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Silme işleminden çıkılıyor...");
                }
                else if (choice == 2)
                {
                    goto againDelete;
                }
                else
                {
                    Console.WriteLine("Gecersiz bir karakter girdiniz.Tekrar deneyiniz ");
                    goto againChoice;
                }
            }

        }

    }
}
