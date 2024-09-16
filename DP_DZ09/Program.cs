using DP_DZ09;

internal class Program
{
    private static void Main(string[] args)
    {
        Map map = new Map();       

        while (true) 
        {
            Console.WriteLine("[1] - генерация равнины");
            Console.WriteLine("[2] - генерация горного региона");
            Console.WriteLine("[3] - генерация архипелага");
            Console.WriteLine("[4] - генерация равнины с рекой");
            Console.WriteLine("[5] - выход");
            Console.Write("Ваш выбор: ");            
            Int32.TryParse(Console.ReadLine(), out int choise);
            Console.Clear();
            switch (choise) 
            {
                case 1:
                    map.GenerateMap(Generator.PlainGenerate);
                    map.Print();                    
                    break;
                case 2:
                    map.GenerateMap(Generator.MountainousGenerate);
                    map.Print();
                    break;
                case 3:
                    map.GenerateMap(Generator.ArchipelagoGenerate);
                    map.Print();
                    break;
                case 4:
                    map.GenerateMap(Generator.PlainWithRiverGenerate);
                    map.Print();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }
        }
    }
}