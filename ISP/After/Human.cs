namespace ISP.After
{
    public class Human : IWorkable, IFeedable
    {
        //Ahora cada clase implementa solo lo que necesita.
        public void Work() => Console.WriteLine("Persona trabajando...");
        public void Eat() => Console.WriteLine("Persona comiendo...");
    }
}
