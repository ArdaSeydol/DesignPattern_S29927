
namespace DesignPattern.Observer
{
    public class ConcreteObserver(string userName) : IObserver
    {
        public string UserName { get; } = userName;
        
        public void AddSubscriber(Subject subject)
        {
            subject.RegisterObserver(this);
        }
        
        public void RemoveSubscriber(Subject subject)
        {
            subject.RemoveObserver(this);
        }
        
        public void Update(string availability)
        {
            Console.WriteLine($"Hello {UserName}, product is now {availability}");
        }
    }
}