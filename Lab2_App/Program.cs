using Lab2_App;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        int variant = 2;

        Console.WriteLine($"Варіант: {variant}");
        Console.WriteLine($"C3 =  {variant % 3}, C17 = {variant % 17} \n");

        Console.Write("Введіть текст: ");
        string text = Console.ReadLine();
        StringBuilderClass sbObj = new StringBuilderClass(text);

        Console.WriteLine($"Унікальне слово першого речення: {sbObj.FindUniqueWord()}");
    }
}