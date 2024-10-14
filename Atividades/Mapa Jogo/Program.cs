using System;

namespace GameMap
{
    public enum TerrainEnum
    {
        SAND, GRASS, WALL, WATER
    }

    public static class TerrainEnumExtensions
    {
        public static ConsoleColor GetColor(this TerrainEnum terrain)
        {
            return terrain switch
            {
                TerrainEnum.SAND => ConsoleColor.Yellow,
                TerrainEnum.GRASS => ConsoleColor.Green,
                TerrainEnum.WALL => ConsoleColor.DarkGray,
                TerrainEnum.WATER => ConsoleColor.Blue,
                _ => ConsoleColor.White
            };
        }

        public static char GetChar(this TerrainEnum terrain)
        {
            return terrain switch
            {
                TerrainEnum.SAND => '.',
                TerrainEnum.GRASS => '#',
                TerrainEnum.WALL => '|',
                TerrainEnum.WATER => '~',
                _ => '?'
            };
        }
    }

    public class Program
    {
        public static void Main()
        {
            TerrainEnum[,] map =
            {
                {
                    TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.WALL,
                    TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS,TerrainEnum.GRASS, TerrainEnum.WALL,
                    TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS,TerrainEnum.GRASS, TerrainEnum.WALL,
                    TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL,
                    TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.WALL,
                    TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.WALL,
                    TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.WALL,
                    TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL,
                    TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL,
                    TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL,
                    TerrainEnum.WALL, TerrainEnum.WALL, TerrainEnum.WALL, TerrainEnum.WALL, TerrainEnum.WALL
                }
            };

            int numRows = 9;  
            int numColumns = 5;  

            
            for (int row = 0; row < numRows; row++)
            {
                for (int column = 0; column < numColumns; column++)
                {
                    Console.ForegroundColor = map[0, row * numColumns + column].GetColor();
                    Console.Write(map[0, row * numColumns + column].GetChar() + " ");
                }
                Console.WriteLine(" end...");  
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}