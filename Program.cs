//Task 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(Math.Pow(a,b));


//Task 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//int N = Convert.ToInt32(Console.ReadLine());

 // int SumNumber(int N){
    
 //   int counter = Convert.ToString(N).Length;
 //   int advance = 0;
 //   int result = 0;

 //   for (int i = 0; i < counter; i++){
 //     advance = N - N % 10;
 //     result = result + (N - advance);
 //     N = N / 10;
 //   }
 //  return result;
 // }

//int sumNumber = SumNumber(N);
//Console.WriteLine(sumNumber);

//Task 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] array = new int [8];
for (int i = 0; i < array.Length; i++)
array[i] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("["+ string.Join(", ", array)+ "]");
