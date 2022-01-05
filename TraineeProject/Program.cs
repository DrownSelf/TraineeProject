static void PrintMatrix(int[,] outputed)
{
    for (int i = 0; i < outputed.GetLength(0); i++)
    {
        for (int j = 0; j < outputed.GetLength(1); j++)
        {
            Console.Write(string.Format("{0} ", outputed[i, j]));
        }
        Console.Write(Environment.NewLine + Environment.NewLine);
    }
}

int[,] numArr;
Console.WriteLine("Enter size of matrix: ");

Console.WriteLine("m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("n: ");
int n = int.Parse(Console.ReadLine());

numArr = new int[n, m];

TraineeProject.Algotighm.RandomFill(numArr);
PrintMatrix(numArr);
TraineeProject.Algotighm.Find(numArr);
TraineeProject.Algotighm.Find(numArr);

string output = TraineeProject.Translator.LatinConverter(numArr);
Console.WriteLine(output);