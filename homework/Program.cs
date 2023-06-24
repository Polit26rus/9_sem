
int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

// 64
// string PrintNumbers(int finish)
// {
//     if (finish == 1)
//     {
//         return "1";
//     }
//     return finish + " " + PrintNumbers(finish - 1); 
// }


int n = Prompt("Введите n ");

// 64
// Console.WriteLine(PrintNumbers(n));