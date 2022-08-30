// void method1()
// {
//     Console.WriteLine("Hello...");
// }

// method1();

// 2-nd type of function
// void method(string msg, int count)
// {
//     int i=0;
//     while (i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// method("hello!", 4);

// 3rd type of Finction:
// int Method()
// {
//     return DateTime.Now.Year;
// }

// int year = Method();
// Console.WriteLine(year);

//4th type of function
// string method(int count, string text)
// {
//     int i=0;
//     string result = String.Empty;
//     while(i<count)
//     {
//         result=result+text;
//         i++;
//     }
//     return result;
// }
// string res = method(4, "text, ");
// Console.WriteLine(res);

for (int i=2; i<10;i++)
{
    for(int j=0;j<=10;j++)
    {
        Console.WriteLine($"{i} x {j}={i*j}");
    }
    Console.WriteLine();
}