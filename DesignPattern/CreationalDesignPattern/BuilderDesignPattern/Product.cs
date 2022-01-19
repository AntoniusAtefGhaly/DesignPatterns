using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    internal class Product
    {
        private System.Collections.Generic.LinkedList<string> parts;
        public Product()
        {
            parts=new System.Collections.Generic.LinkedList<string>(); 
        }
        public void Add(string part)
        {
            parts.AddLast(part);
        }
        public string show()
        {
            StringBuilder result=new StringBuilder();
            result.AppendLine("product components are");
            foreach (string part in parts) 
                result.AppendLine(part);
            return result.ToString();
        }
    }
}
