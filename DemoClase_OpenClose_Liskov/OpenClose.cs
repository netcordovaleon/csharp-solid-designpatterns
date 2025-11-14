using System.Runtime.CompilerServices;

namespace DemoClase_OpenClose_Liskov
{
    public class OpenClose
    {

        public void Ejemplo() { 
            String cadena = string.Empty;
            cadena = "Esto es una oracion";
            cadena.FinalizarOracion();

            var objetoHija = new Hija();
        }
    }


    public static class UtilitariosString { 
        public static string FinalizarOracion(this string cadena) { //Extension
             return cadena + ".";
        }    
    }



    public abstract class ClasePadre {
        public int Id { get; set; }
    }

    public class Hija : ClasePadre {
        public string? Name { get; set; }
    }

}
