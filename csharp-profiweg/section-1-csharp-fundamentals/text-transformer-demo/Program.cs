#nullable disable
using TextTransformerDemo.Interfacces;
using TextTransformerDemo.Transformers;

namespace TextTransformerDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter text to transform:");
      string inputText = Console.ReadLine();

      Console.WriteLine("\nChoose a transformation method:");
      Console.WriteLine("1. UpperCase");
      Console.WriteLine("2. Reverse Text");
      Console.WriteLine("Enter your choice:");

      string choice = Console.ReadLine();

      ITextTransformer transformer;

      switch (choice)
      {
        case "1":
          transformer = new UpperCaseTransformer();
          break;
        case "2":
          transformer = new ReverseTextTransformer();
          break;
        default:
          Console.WriteLine("❌ Invalid choice. Using default UpperCase transformation.");
          transformer = new UpperCaseTransformer();
          break;
      }

      var textTransformerManager = new TextTransformerManager(transformer);
      textTransformerManager.ExecuteTransformation(inputText);
    }
  }
}