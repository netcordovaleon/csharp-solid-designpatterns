namespace LSP.After
{
    public class Eagle : Bird
    {
        //Las subclases se comportan correctamente dentro del contrato de la base.
        public override void Move() => Console.WriteLine("Volando alto");
    }
}
