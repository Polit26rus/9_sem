// 65: Задайте значения М и Н,напишите программу,которая выведет все натуральные
// числа в промежутке от M до N

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


// 65
// string PrintNumbers(int start, int finish)
// {
//     if (start == finish)
//     {
//         return start.ToString();
//     }
//     return start + " " + PrintNumbers(start + 1,finish); 
// }
// Console.WriteLine(PrintNumbers(m, n));

int SumOfNum(int n){
    int sum = 0;
    if(n == 0){
        return sum;
    }
    else{
        return sum += n % 10;
        n /= n / 10;
    }
}


int m = Prompt("Введите m ");
int n = Prompt("Введите n ");