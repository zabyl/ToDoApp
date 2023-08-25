using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication.AppData
{
    static class Data
    {
        private static List<Card> _cards;
        private static List<Member> _members;

        static Data()
        {

            _cards = new List<Card>()
            {
                new Card() {Title="New Project", Content="Drafting the project and assigning the groups", Member="Mahir", Size="L", BoardType="TODO"},
                new Card() {Title="Research", Content="Data Science", Member="Arda", Size="L", BoardType="IN PROGRESS"},
                new Card() {Title="Meeting", Content="Increasing the productivity of group members", Member="Sima", Size="Xl", BoardType="DONE"}
            };


            _members = new List<Member>()
            {
                new Member(){ Id=1, Name="Semiha", Team="A"},
                new Member(){ Id=2, Name="İlayda", Team="A"},
                new Member(){ Id=3, Name="Ender", Team="A"},
                new Member(){ Id=4, Name="Filiz", Team="B"},
                new Member(){ Id=5, Name="Nedim", Team="B"},
                new Member(){ Id=6, Name="Uğur", Team="B"},
                new Member(){ Id=7, Name="Cihan", Team="C"},
                new Member(){ Id=8, Name="Ezgi", Team="C"},
                new Member(){ Id=9, Name="Vural", Team="C"},
                new Member(){ Id=10, Name="Kubilay", Team="C"},
                new Member(){ Id=11, Name="Banu", Team="D"},
                new Member(){ Id=12, Name="Tugay", Team="D"},
                new Member(){ Id=13, Name="Beste", Team="D"}
            };

        }

        public static List<Card> Cards => _cards;

        public static List<Member> Members => _members;


    }
}
