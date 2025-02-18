using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextTransformerDemo.Interfacces;

namespace TextTransformerDemo.Transformers
{
    public class ReverseTextTransformer : ITextTransformer
    {
        public string TransformText(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}