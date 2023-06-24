
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

// 66
// int SumOfNum(int m,int n){

//     if(n == m){
//         return n;
//     }
//     else{
//         return m + SumOfNum(m + 1,n);
//     }
// }

// 68
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}


int n = Prompt("Введите n ");

// 64
// Console.WriteLine(PrintNumbers(n));

// 66
// int m = Prompt("Введите m ");
// Console.WriteLine(SumOfNum(n,m));

// 68
// int m = Prompt("Введите m ");
// AkkermanFunction(m,n);