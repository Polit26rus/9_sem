
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



int n = Prompt("Введите n ");

// 64
// Console.WriteLine(PrintNumbers(n));

// 66
// int m = Prompt("Введите m ");
// Console.WriteLine(SumOfNum(n,m));