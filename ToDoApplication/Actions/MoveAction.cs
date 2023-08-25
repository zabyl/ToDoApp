using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApplication.AppData;

namespace ToDoApplication.Actions
{
    public class MoveAction
    {
        public void Move()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");

            string cardTitle = Console.ReadLine();

            Card card = Data.Cards.FirstOrDefault(x => x.Title == cardTitle);
            Card deleteOld = card;

            if (card != null)
            {
                Console.WriteLine("Bulunan Kart Bilgileri :" +
                    "\n**************************************");

                Console.WriteLine(
                    
                    $"Başlık : {card.Title}" +
                    $" İçerik : {card.Content}" +
                    $"Atanan Kişi : {card.Member}" +
                    $"Büyüklük : {card.Size}" +
                    $"Line : {card.BoardType}"
                    
                    );

                Console.WriteLine();
            againMove:
                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: " +
                    "\n(1) TODO " +
                    "\n(2) IN PROGRESS " +
                    "\n(3) DONE");

                Console.WriteLine();

                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    card.BoardType = "TODO";
                    Data.Cards.Add(card);
                    Data.Cards.Remove(deleteOld);
                    Console.WriteLine($"{card.Title} başlıklı kart {card.BoardType} kısmına taşındı.");

                    Console.WriteLine("\nDevam etmek için bir tuşa basınız...");
                    Console.ReadLine();

                }
                else if (choice == "2")
                {
                    card.BoardType = "IN PROGRESS";
                    Data.Cards.Add(card);
                    Data.Cards.Remove(deleteOld);
                    Console.WriteLine($"{card.Title} başlıklı kart {card.BoardType} kısmına taşındı.");
                    Console.WriteLine("\nDevam etmek için bir tuşa basınız...");
                    Console.ReadLine();
                }
                else if (choice == "3")
                {
                    card.BoardType = "DONE";
                    Data.Cards.Add(card);
                    Data.Cards.Remove(deleteOld);
                    Console.WriteLine($"{card.Title} başlıklı kart {card.BoardType} kısmına taşındı.");
                    Console.WriteLine("\nDevam etmek için bir tuşa basınız...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Hatalı bir seçim yaptınız! Tekrar denemek için bir tuşa basınız...");
                    Console.ReadLine();
                    goto againMove;

                }
            }
        }
    }
}
