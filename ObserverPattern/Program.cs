namespace ObserverPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();

            ConcreteObserver observer1 = new ConcreteObserver("Observer 1");
            ConcreteObserver observer2 = new ConcreteObserver("Observer 2");

            subject.Attach(observer1);
            subject.Attach(observer2);

            subject.State = 10;
            subject.State = 20;

            subject.Detach(observer2);
            subject.State = 30;
        }
    }
}