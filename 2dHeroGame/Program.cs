using Json.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
//using System.Text.Json;
//using System.Text.Json.Serialization;

namespace _2dHeroGame
{
    class Program
    {
        static void Main(string[] args)
        {



            Enemy enemy = new Enemy() { Weapon = 50 };
            GoldBox goldBox = new GoldBox();
            GoldKey goldKey = new GoldKey();
            SilverKey silverKey = new SilverKey();
            BronzKey bronzKey = new BronzKey();


            Cell cell1 = new Cell(enemy);
            Cell cell2 = new Cell(goldKey);
            Cell cell3 = new Cell(goldBox);
            Cell cell4 = new Cell();
            Cell[,] cells = new Cell[,] {
                { cell4, cell1, cell3 },
                { cell2, cell4, cell2 },

            };


            Player player = new Player();
            player.Keys.Add(silverKey);
            player.Keys.Add(goldKey);
            player.Keys.Add(bronzKey);

            GameDirectorBuilder directorBuilder;
            GameDirector gameDirector = new GameDirector();
            directorBuilder = new GameDirectorBuilder()
                                .newBoard()
                                .AddCellToBoard(cells)
                                .AddPlayerToBoard(player);


            //Board board = new Board(cells);
            //board.Player = player;
            //GameDirector gameDirector = new GameDirector(board);
            //Console.WriteLine("hhhhhhhhhhh");


            //JsonSerializer serializer = new JsonSerializer();

            //var petJson = JsonNet.Serialize(gameDirector);
            //Console.WriteLine(petJson);
            //File.WriteAllText(@"C:\Users\sameh.hamza\source\repos\2dHeroGame\2dHeroGame\json.txt", petJson);
            //var jsonString = File.ReadAllText(@"C:\Users\sameh.hamza\source\repos\2dHeroGame\2dHeroGame\json.txt");

            //var pet = JsonNet.Deserialize<Board>(jsonString);

            Console.WriteLine("Hello World!");
        }

    }


}
