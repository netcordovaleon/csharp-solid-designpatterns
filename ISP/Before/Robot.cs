namespace ISP.Before
{
    internal class Robot : IWorker
    {
        public void Work() => Console.WriteLine("Robot trabajando..."); 
        public void Eat() => throw new NotImplementedException(); // Robots no comen
    }
}
