using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionBase array = new Array();
            IList list = new List();

            list.Add(3);

        }
    }

    public class CollectionBase
    {
        public int Count { get; set; }

    }


    public interface IList
    {
        void Add(object item);
    }


    public class Array : CollectionBase
    {
    
    }


    public class List : CollectionBase ,IList
    {
        public void Add(object item)
        {
        
        }
    }
}
