/*Написать программу, которая из имеющихся массива строк формируют массив из строк,
 длина которых меньше либо равна трём символам.
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
 выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами. 
 Примеры: 
["hello", "2", " world", ":-)"]-> ["2",":-)"]
["1234","1567","2","computer science"]->["2"]
["Russia","Denmark","Kazan"]->[]
*/
Console.WriteLine("Введите строки с произвольным содержанием через пробел: ");
string str = Console.ReadLine();
string[] arr;
arr = str.Split(' ');
void NewLine()
{
    var result = new string[arr.Length];
    var size = 0;
    foreach (var value in arr)
    {
        if (value.Length > 3)
        {
            size++;
        }
        else
        {
            Console.Write($" '{value}', ");
        }
    }
}
Console.Write("[");
NewLine();
Console.Write("]");