using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }



    public interface IDatabaseManager
    {
        void Add();
        void Remove();
        void Update();
    }



    public interface IDatabaseRemoveAll : IDatabaseManager
    {
        void RemoveAll(int[] Ids);
    }




    public class MyClass : IDatabaseRemoveAll
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void RemoveAll(int[] Ids)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

}
