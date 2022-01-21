using System;
/*Числовые значения символов нижнего регистра в коде ASCII
отличаются от значений символов верхнего регистра на постоянную       //немного не понятно что тут имеется ввиду
величину. Как её узнать?
Написать программу, которая считывает с клавиатуры и конвертирует 
все символы нижнего регистра в символы верхнего регистра и наоборот.*/
namespace символы_регистров
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka;
            Console.WriteLine("ведите количество символом ");        
            stroka = Console.ReadLine();
            char[] arr = stroka.ToCharArray();
             for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 'a' && arr[i] <= 'z'|| arr[i] >= 'а' && arr[i] <= 'я') //все работает и с русским алфавитом
                {
                    arr[i] = char.ToUpper(arr[i]);
                    
                }
                else 
                {
                    arr[i] = char.ToLower(arr[i]);
                    
                }
               
                Console.Write(arr[i]);
            }
        }
    }
}
