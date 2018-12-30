using System;

namespace GenericExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Result<int> { Success = true, Data = 5 };
            var result2 = new Result<string> { Success = false, Data = "John" };

            var helper = new ResultPrinter();

            helper.Print(result);
            Console.ReadLine();
        }
    }

    public class Result<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
    }

    public class ResultPrinter
    {
        public void Print<T>(Result<T> result)
        {
            Console.WriteLine(result.Success);
            Console.WriteLine(result.Data);
        }
    }
}
