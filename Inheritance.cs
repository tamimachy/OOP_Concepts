using System;

namespace Program
{
    public class Inheritance
    {
        public class PresentationObject
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public void Copy()
            {
                Console.WriteLine("Object copied to clipboard.");
            }
            public void Duplicate()
            {
                Console.WriteLine("Object was duplicated.");
            }
        }
        public class Text : PresentationObject
        {
            public int FontSize { get; set; }
            public string FontName { get; set; }
            public void AddHyperlink(string url)
            {
                Console.WriteLine("We added a link to " + url);
            }
        }
    }
}
