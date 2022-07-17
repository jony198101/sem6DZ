//Задача 41
Console.Write("Введите элементы: ");
            int [] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Кол-во элементов > 0: {count}");
           
// Задача 43 
void FindCross()
{
    Console.Clear();
    Console.Write("Введите координаты первой точки первой примой: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты второй точки первой примой: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты первой точки второй примой: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты второй точки второй примой: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    FindXY(b1, k1, b2, k2);
}

void FindXY(double x1, double y1, double x2, double y2)
{
    double x = (x2 - x1)/(y1 - y2);
    double y = (y1 * x) + x1;

    Console.WriteLine();
    Console.WriteLine($"Точка пересечения y = {y}");
    Console.WriteLine($"Точка пересечения x = {x}");
}


    
    Console.WriteLine();


FindCross();


