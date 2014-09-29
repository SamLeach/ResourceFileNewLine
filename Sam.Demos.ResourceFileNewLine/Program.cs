namespace Sam.Demos.ResourceFileNewLine
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Resources.OkMessage);
            Console.WriteLine(Resources.OkMessageWithBrokenNewLine);
            Console.WriteLine(Resources.OkMessageWithCorrectNewLine);

            Console.ReadKey();
        }
    }
}
