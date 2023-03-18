using System.ComponentModel.DataAnnotations;
using System.Globalization;
internal class Program
{
    public static void Main(string[] args)
    {
            Console.WriteLine("Введите размер массива");
            int sizeofmassive = 1;
            try
            {
                sizeofmassive = GetReadInt();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                if(sizeofmassive<= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
              
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Введен некорректный размер массива. Размер должен быть > 0");
            
            }
            int[] numbers = new int[sizeofmassive];
            int h = 1;
            string strvalue;
            for (int i = 0; i < sizeofmassive; i++)
            {
                Console.WriteLine($"Введите значение {h}");
                strvalue = Console.ReadLine();
                int value = Convert.ToInt32(strvalue);
                numbers[i] = value;
                h++;
            }
        int maxvalue = 0;
        for (int i = 0; i < sizeofmassive; i++)
        {
            if (numbers[i] > maxvalue)
            {
                maxvalue = numbers[i];
            }
        }
        int thirdmaxvalue = numbers[2];
        int secondmaxvalue = 0;
            for (int i = 0; i < sizeofmassive; i++)
            {
                if (numbers[i] > thirdmaxvalue && numbers[i] < maxvalue)
                {
                    secondmaxvalue = numbers[i];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"Второе максимальное число: {secondmaxvalue}");
            }
        

    public static int GetReadInt()
    {
        if (int.TryParse(Console.ReadLine(), out var value))
        {
            return value;
        }
        else
        {
            throw new Exception("Вы ввели не число. Введите число.");
          
        }
      
    }
}