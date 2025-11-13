namespace LSP.Before
{
    public class Penguin: Bird
    {
        public override void Fly()
        {
            throw new NotImplementedException("Los pingüinos no vuelan");
        }
    }
}
