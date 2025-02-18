using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextTransformerDemo.Interfacces;


namespace TextTransformerDemo.Transformers
{
    public class UpperCaseTransformer : ITextTransformer
    {
        public string TransformText(string input)
        {
            return input.ToUpper();
        }
    }
}