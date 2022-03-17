using System;
using System.Collections.Generic;
using System.Text;
using gameEngine.Entities;
namespace gameEngine.Util
{
    public class initializeGame
    {
        game game = new game();
        public game iniGame(List<character> listCharacter,string name,int creationAge,dificulty dificulty,List<hability> listHabilities)
        {
            game=new game();
            game.name=name;
            game.dificulty=dificulty;
            game.CreationAge=creationAge;
            game.characters=listCharacter;
            game.habilities = listHabilities;
            return game;
        }
        public void listIniGame(game obGame)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Bienvenidos al Juego "+obGame.name);
            Console.WriteLine("==============================");
            Console.WriteLine("El año de creación del juego es "+obGame.CreationAge);
            Console.WriteLine("La dificultad seleccionada es "+obGame.dificulty);
            Console.WriteLine("==============================");
            Console.WriteLine("los personajes creados son los siguientes: ");
            foreach (character chara in obGame.characters)
            {
                Console.WriteLine(chara.name);
            }
            Console.WriteLine("==============================");
        }
        public void writeTitle(string title)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("El tipo de dato es: " + title);
            Console.WriteLine("==============================");
        }
    }
}
