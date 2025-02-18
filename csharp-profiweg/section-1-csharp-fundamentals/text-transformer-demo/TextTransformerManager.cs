using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextTransformerDemo.Interfacces;

namespace TextTransformerDemo
{
    public class TextTransformerManager
    {
        private readonly ITextTransformer _textTransformer;

        public TextTransformerManager(ITextTransformer textTransformer)
        {
            _textTransformer = textTransformer;
        }

        public void ExecuteTransformation(string input)
        {
            string result = _textTransformer.TransformText(input);
            Console.WriteLine($"🔁 Transformed Text: {result}");
        }
    }
}