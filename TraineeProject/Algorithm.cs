using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeProject
{
    internal static class Algotighm
    {
        public static void RandomFill(int[,] arr)
        {
            var rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = rnd.Next(0, 10);
        }

        public static void Find(int[,] translationed)
        {
            Dictionary<string, Func<int, int, bool>> compareMod = new Dictionary<string, Func<int, int, bool>>();
            InitDictionary(compareMod);

            Console.WriteLine("Enter Finding mode (min or max): ");
            try
            {
                Console.WriteLine("Your number: " + FindNum(compareMod[Console.ReadLine()], translationed));
            }
            catch(Exception)
            {
                Console.WriteLine("This mode which you enter are incorrect");
            }
        }

        private static void InitDictionary(Dictionary<string, Func<int, int, bool>> compareMod)
        {
            compareMod.Add("min", (compared, item) => compared > item);
            compareMod.Add("max", (compared, item) => compared < item);
        }

        private static int FindNum(Func<int, int, bool> compare, int[,] translationed)
        {
            int compared = translationed[0,0];
            foreach (var item in translationed)
                if (compare(compared, item))
                    compared = item;
            return compared;
        }
    }
}