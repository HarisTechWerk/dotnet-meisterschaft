using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextTransformerDemo.Interfacces
{
    public interface ITextTransformer
    {
        string TransformText(string input);
    }
}