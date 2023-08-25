using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ToDoApplication.AppData;

namespace ToDoApplication.Actions
{
    public class AddAction
    {
        public void Add()
        {
            Card newCard = new Card();

            Console.WriteLine("\tYeni Kart Ekle");
            Console.WriteLine("**************************************************\n");

            Console.WriteLine();


            TakeTitle(newCard);

            TakeContent(newCard);

            TakeNum(newCard);

            TakePersonId(newCard);

            TakeBoardType(newCard);

            if (newCard.Title != null && newCard.Content != null && newCard.Size != null && newCard.Member != null && newCard.BoardType != null)
            {
                Data.Cards.Add(newCard);
                Console.WriteLine($"Bu kart {newCard.Member} tarafından oluşturulmuştur.");
            }

            else
            {
                Console.WriteLine("Kart eklenemedi!");
            }

        }

        private bool CheckNullEmpty(string textInput)
        {
            if (String.IsNullOrEmpty(textInput))
            {
                return true;
            }
            return false;
        }

        private void TakeTitle(Card card)
        {
        againTitle:
            Console.Write("Başlık Giriniz                                  :");


            string text1 = Console.ReadLine();

            if (!CheckNullEmpty(text1))
            {
                card.Title = text1;
            }

            else
            {
                Console.WriteLine("Bu alan boş bırakılamaz!");
                goto againTitle;
            }
        }

        private void TakeContent(Card card)
        {
        againContent:
            Console.Write("İçerik Giriniz                                  :");


            string text2 = Console.ReadLine();
            if (!CheckNullEmpty(text2))
            {
                card.Content = text2;

            }

            else
            {
                Console.WriteLine("Bu alan boş bırakılamaz!");
                goto againContent;
            }
        }

        private void TakeNum(Card card)
        {
        againTakeNum:
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");

            string text = Console.ReadLine();


            if (!String.IsNullOrEmpty(text))
            {
                if (text == "1" || text == "2" || text == "3" || text == "4" || text == "5")
                {
                    int size = int.Parse(text);

                    string sizeValue = Enum.GetName(typeof(Sizes), size);
                    card.Size = sizeValue;

                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir giriş yapınız! Tekrar denemek için bir tuşa basınız...");
                    goto againTakeNum;
                }

            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir giriş yapınız! Tekrar denemek için bir tuşa basınız...");
                goto againTakeNum;
            }

        }

        private void TakePersonId(Card card)
        {
        againPerson:
            Console.Write("Seçtiğiniz kişi için Id giriniz                                    :");


            string personId = Console.ReadLine();

            if (!String.IsNullOrEmpty(personId))
            {
                if (personId == "1" || personId == "2" || personId == "3" || personId == "4" || personId == "5" || personId == "6" || personId == "7"
                    || personId == "8" || personId == "9" || personId == "10" || personId == "11" || personId == "12" || personId == "13")
                {
                    int id = int.Parse(personId);

                    var member = Data.Members.FirstOrDefault(x => x.Id == id);

                    if (member != null)
                    {
                        card.Member = member.Name;

                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş yaptınız!");
                    againTry:
                        Console.WriteLine("Tekrar denemek için 1'e basınız: ");

                        string choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            goto againPerson;
                        }

                        else
                        {
                            Console.WriteLine("Geçersiz giriş yaptınız.Tekrar deneyiniz.");
                            goto againTry;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş yaptınız.Tekrar denemek için bir tuşa basunuz...");
                    Console.ReadLine();
                    goto againPerson;

                }

                



            }
            else
            {
                Console.Write("Bu alan boş bırakılamaz!");
                goto againPerson;
            }
        }

        private void TakeBoardType(Card card)
        {
        againType:
            Console.WriteLine(

                "Kartı eklemek istediğinz bölümü seçiniz: " +
                "\n\t(1) TODO" +
                "\n\t(2) IN PROGRESS" +
                "\n\t(3) DONE"

                );

            string boardName = Console.ReadLine();
            if (!String.IsNullOrEmpty(boardName))
            {
                if (boardName == "1")
                {
                    card.BoardType = "TODO";
                }
                else if (boardName == "2")
                {
                    card.BoardType = "IN PROGRESS";
                }
                else if (boardName == "3")
                {
                    card.BoardType = "DONE";
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız. Tekrar denemek için bir tuşa basınız.");
                    Console.ReadLine();
                    goto againType;
                }
            }
            else
            {
                Console.WriteLine("Bu alan boş bırakılamaz. Tekrar denemek için bir tuşa basınız.");
                Console.ReadLine();
                goto againType;
            }
        }

        public enum Sizes
        {
            XS = 1,
            S,
            M,
            L,
            XL
        }
    }
}
