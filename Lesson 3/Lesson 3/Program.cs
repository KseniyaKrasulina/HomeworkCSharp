using System.Linq.Expressions;

public class Program
{
    public static void Main(string[] args)
    {
        Patient patient = new Patient
        {
            name = "Иванов Иван Иванович",
            adress = "ул. Солнечная 48, д.6",
        };
        patient.Display();
        Neurologist neurologist = new Neurologist
        {
            name = "Васильев Василий Васильевич",
            adress = "ул. Южная 46",
        };
        neurologist.Display();
        Gastroenterologist gastroenterologist = new Gastroenterologist
        {
            name = "Андреева Ева Андреевна",
            adress = "ул. Северная 57, д.9",
        };
        gastroenterologist.Display();
        patient.Gotodoctor();
        int number = 0;
        try
        {
            number = GetReadInt();
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            if (number <= 0 || number > 2)
            {
                throw new ArgumentOutOfRangeException();
            }

        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Такого доктора нет в поликлинике");

        }
        if (number == 1)
        {
            Console.WriteLine($"Вы записаны к {neurologist}");
            neurologist.Cure();
        }
        else
        {
            Console.WriteLine($"Вы записаны к {gastroenterologist}");
            gastroenterologist.Cure();
        }


    }
    public class Person
    {
        public string name { get; set; }
        public string adress { get; set; }
        public virtual void Display()
        {
            Console.WriteLine($"{name} : {adress}");
        }

    }
    public class Patient : Person
    {
        public void Gotodoctor()
        {
            Console.WriteLine("К какому доктору вы хотите записаться? 1 - невролог, 2 - гастроэнтеролог");


        }
    }

    public class Neurologist : Person, IDoctor

    {
        private string cabinet = "303b";
        private string specialisation = "невролог";
        public override void Display()
        {
            Console.WriteLine($"{cabinet} : {name} : {specialisation}");
        }
        public void Cure()
        {
            Console.WriteLine("Вам необходимо пройти МРТ головного мозга и прийти ко мне в кабинет с результатами");
        }

    }
    public class Gastroenterologist : Person, IDoctor

    {
        private string cabinet = "125a";
        private string specialisation = "гастроэнтеролог";
        public override void Display()
        {
            Console.WriteLine($"{cabinet} : {name} : {specialisation}");
        }
        public void Cure()
        {
            Console.WriteLine("Вам необходимо пройти ФГДС и прийти ко мне в кабинет с результатами");
        }

    }

    interface IDoctor
    {
        void Cure()
        {

        }

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
