// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// {
//     if(a*a==b)
//         Console.WriteLine("kekis");
//     else
//     {
//         Console.WriteLine("kekislul");
//     }

// }





// Console.WriteLine("Вевдите номер дня недели");
// int dayNumber = Convert.ToInt32(Console.ReadLine());

// if(dayNumber <= 7 && dayNumber>=1)
// {
//     if(dayNumber == 1)
//     {
//         Console.WriteLine("Понедельник");
//     }
//     if(dayNumber == 2)
//     {
//         Console.WriteLine("Вторник");
//     }
//     if(dayNumber == 3)
//     {
//         Console.WriteLine("Среда");
//     }
// }
// else
// {
//     Console.WriteLine("Введите число от 1 до 7");
// }



// Console.WriteLine("N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int NegativeN = N*(-1);
// while(NegativeN<=N)
// {
//     Console.Write(NegativeN + " ");
//     NegativeN+=1;    
// }

Console.WriteLine("Введите трёхзначное число: ");
int f = Convert.ToInt32(Console.ReadLine());
int K = 0;
if(f>=100 && f<1000)
{
    K = f%10;
    Console.WriteLine(K);
}
else
{
    Console.WriteLine("Ошибка.Введите трёхзначное число");
}