// See https://aka.ms/new-console-template for more information
//////////Console.WriteLine("Hello, World!");
///
/// 
/// 
//////////Task1
//int[] arr1 = { 4, 5, 2, 6, 4, 3 };
//int[] arr2 = { 7, 4, 2, 76, 45, 65 };
//for (int i = 0; i < arr1.Length; i++)
//{
//    bool eyni = false;
//    for (int j = 0; j < arr2.Length; j++)
//        if (arr1[i] == arr2[j])
//        {
//            eyni = true;
//        }
//    if (!eyni)
//    {
//        Console.WriteLine(arr1[i]);
//    }
//}




//////TASK2
//Product product1 = new Product("Product-1")
//{
//    Count = 2,
//    Price = 150,
//};

//product1.Sell();
//Console.WriteLine(product1.Total);
//product1.Sell();
//Console.WriteLine(product1.Total);
//product1.Sell();
//Console.WriteLine(product1.Total);


////////TASK4
//int[] arr = {50, 30, 40, 100 };

//int result = CalcAvg(arr);
//if (result >= 60) Console.WriteLine("Mezun olduz!");
//else Console.WriteLine("Mezun olmadiniz!");
//static int CalcAvg(int[] arr)
//{
//    int sum = 0;
//    foreach (int i in arr)
//    {
//        sum += i;
//    }
//    return sum / arr.Length;
//}


////////TASK5
//Console.WriteLine(CalcPrice(150, 100, 120));
//static double CalcPrice(double a, double b, double c)
//{
//    double minNumber = a;
//    if (minNumber > b)
//    {
//        minNumber = b;
//    }
//    if (minNumber > c)
//    {
//        minNumber = c;
//    }
//    double price = (a + b + c) - minNumber;
//    return price;
//}