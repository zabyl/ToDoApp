using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApplication.AppData;

namespace ToDoApplication.Actions
{
    public class ListAction
    {
        private static Board _board;

        public void FillBoard()
        {
            var toDo = Data.Cards.Where(p => p.BoardType == "TODO").ToList();
            var inProgress = Data.Cards.Where(p => p.BoardType == "IN PROGRESS").ToList();
            var done = Data.Cards.Where(p => p.BoardType == "DONE").ToList();

            _board = new Board();
            _board.ToDo = toDo;
            _board.InProgress = inProgress;
            _board.Done = done;
        }

        private void PrintCard(string boardType, List<Card> cards)
        {
            Console.WriteLine($"\t\t{boardType}");
            Console.WriteLine("**************************************************\n");

            int typeNumber = 1;

            foreach (var item in cards)
            {
                
                Console.WriteLine($"{boardType} {typeNumber}");

                Console.WriteLine(
                    $"\tBaşlık      : {item.Title}" +
                    $"\n\tİçerik      : {item.Content}" +
                    $"\n\tAtanan Kişi : {item.Member}" +
                    $"\n\tBüyüklük    : {item.Size}"
                    );
                Console.WriteLine();
                Console.WriteLine();

                typeNumber++;
            }

        }

        public void ListBoard()
        {
            FillBoard();
            PrintCard("TODO Line", _board.ToDo);
            PrintCard("IN PROGRESS Line", _board.InProgress);
            PrintCard("DONE Line", _board.Done);
        }
    }
}
