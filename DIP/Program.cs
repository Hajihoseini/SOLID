using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {

            DataBaseManager data = new DataBaseManager(new EmailNotification());
            DataBaseManager data2 = new DataBaseManager(new SmsNotification());

            Console.WriteLine("Hello World!");
        }
    }



    public interface INotification
    {
        void Send(string message);
    }



    public class EmailNotification :INotification
    {
        public void Send(string message)
        { 
        }
    }


    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
        }
    }


    public class DataBaseManager
    {
        private INotification _notification;
        public DataBaseManager(INotification notification)
        {
            _notification = notification;
        }
        public void Add()
        {
            _notification.Send("Add new Record");
        }
        public void Remove()
        {
            _notification.Send("Remove Record");
        }
        public void Update()
        {
            _notification.Send("Update Record");
        }
    }




}
