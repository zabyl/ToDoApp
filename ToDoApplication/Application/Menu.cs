using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApplication.Actions;

namespace ToDoApplication.Application
{
    static class Menu
    {

        public static void Run()
        {
            OptionMenu();

        }
        public static void OptionMenu()
        {

            Console.WriteLine(

                "Lütfen yapmak istediğiniz işlemi seçiniz :)" +
                "\n❆❆❆❆❆❆❆❆❆❆❆❆❆❆❆❆❆❆❆❆❆❆❆❆❆❆❆❆❆❆" +
                "\n(1) Board Listelemek " +
                "\n(2) Board'a Kart Eklemek " +
                "\n(3) Board'dan Kart Silmek " +
                "\n(4) Kart Taşımak"

                );

            GetChoice();
        }

        public static void GetChoice()
        {
        againChoice:
            string option = Console.ReadLine();

            if (!string.IsNullOrEmpty(option))
            {
                if (option == "1" || option == "2" || option == "3" || option == "4")
                {
                    switch (option)
                    {
                        case "1":
                            ListAction listAction = new ListAction();
                            listAction.ListBoard();
                            ClearScreen();
                            break;

                        case "2":
                            AddAction addAction = new AddAction();
                            addAction.Add();
                            ClearScreen();
                            break;

                        case "3":
                            DeleteAction deleteAction = new DeleteAction();
                            deleteAction.Delete();
                            ClearScreen();
                            break;

                        case "4":
                            MoveAction moveAction = new MoveAction();
                            moveAction.Move();
                            ClearScreen();
                            break;

                        default:
                            Console.WriteLine("Hatalı giriş yaptınız! Tekrar denemek için bir tuşa basınız...");
                            goto againChoice;


                    }
                    Console.Clear();
                    OptionMenu();

                }

            }
            else
            {
                Console.WriteLine("Bu alan boş bırakılamaz! Tekrar denemek için bir tuşa basınız...");
                goto againChoice;

            }

        }

        private static void ClearScreen()
        {
            Console.WriteLine("\nMenüye dönmek için bir tuşa basınız...");
            Console.ReadLine();
            Console.Clear();
        }
    }

}

