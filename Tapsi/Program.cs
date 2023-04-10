
var array = new int[] { 7, 3, 8, 2 };

var score = new int[array.Length, array.Length];

for (int i = 0; i < array.Length; i++)
{
    score[i,i] = array[i];
}

for (int j = 1; j < array.Length; j++)
{
    for (int i = 0; i < array.Length - j; i++)
    {
        if (j % 2 == 1)
            score[i,i + j] = Math.Max(score[i + 1, i + j], score[i, i + j - 1] );
        else
            score[i,i + j] = Math.Min(score[i + 1,i + j] + array[i], score[i,i + j - 1] + array[i + j]);
    }
}

Console.WriteLine($"best score is: {score[0, array.Length - 1]}");
for (int j = 0; j < array.Length; j++)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{score[i,j]}, ");
    }
    Console.WriteLine();
}