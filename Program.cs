// 41. Пользователь вводит с клавиатуры M чисел.
// Посчитать, сколько чисел больше 0 ввел пользователь.
Console.Clear();
void FillArr(int [] array)                              // заполнение массива             
{
    int index = 0;
    while (index < array.Length)                        
    {                                                   
        Console.Write($"Введите число с индексом {index}: ");
        int M = Convert.ToInt32(Console.ReadLine());
        array[index] = M;
        index++;                                          
    }
}
void PrintArr(int [] array1)                        // вывод массива на экран                
{
    int count = array1.Length;                           
    int pos = 0;                                         
    while (pos < count)                                  
    {                                                    
        Console.Write($"{array1[pos]} ");  
        pos++;                                          
    }
}

void Count (int[]array)                                  
{
    int index = 0;                                   
    int sum = 0;                                                                       
    while (index < array.Length)                        
    {
        if (array[index] > 0)                           
        {
            sum++;                 
        }
        index++;
    }
    Console.WriteLine($"Количество положительных числе = {sum}");
}

Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine()); 
int [] arr = new int [M];
FillArr(arr);
PrintArr(arr);
Console.WriteLine();
Count(arr);

// 43. Программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y=k1*x+b1, y=k2*x+b2, значения b1, k1, b2, k2 задаются пользователем.

Console.Write("Введите число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите число b2: ");
double b2 = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine()); 

if (k1-k2 == 0)
{
    Console.WriteLine("Прямые параллельные - они не пересекутся");
}

else
{
    double x= (b2-b1) / (k1-k2);
    Console.WriteLine($"Координата  x = {Math.Round(x, 1)}");

    double y1 = k1*x+b1;
    Console.WriteLine($"Координата  y1 = {Math.Round(y1, 1)}");
    double y2 = k2*x+b2;
    Console.WriteLine($"Координата  y2 = {Math.Round(y2, 1)}");
    if (y1 == y2)
    {
        Console.Write($"Точка пересечения с координатами x = {Math.Round(x, 1)} и y1 = {Math.Round(y1, 1)}");

    }
}



