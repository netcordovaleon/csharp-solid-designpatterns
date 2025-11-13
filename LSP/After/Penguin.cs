namespace LSP.After
{
    public class Penguin : Bird
    {
        //Las subclases se comportan correctamente dentro del contrato de la base.
        public override void Move() => Console.WriteLine("Nadando");
    }
}
