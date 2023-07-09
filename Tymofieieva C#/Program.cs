class Program
{
    static void Main(string[] args)
    {
        //Составить алгоритм: если введенное число больше 7, то вывести “Привет”

        Console.WriteLine("Введите пожалуйста число:");
        string number = Console.ReadLine();
        int n = Convert.ToInt32(number);
        if (n > 7)
        {
            Console.WriteLine("Привет");
        }



        //Составить алгоритм: если введенное имя совпадает с Вячеслав, то вывести “Привет, Вячеслав”,
        //если нет, то вывести "Нет такого имени"

        Console.WriteLine("Введите имя:");
        string name = Console.ReadLine();
        if (name == "Вячеслав")
        {
            Console.WriteLine("Привет, Вячеслав");
        }
        else
        {
            Console.WriteLine("Нет такого имени");
        }

        //Составить алгоритм: на входе есть числовой массив, необходимо вывести элементы массива кратные 3


        int[] mas = {-3, 1, 2, 3, 4, 5, 6,  7, 8, 9, 10};
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] % 3 == 0)
            {
                Console.WriteLine(mas[i]);
            }
        }





    }
}