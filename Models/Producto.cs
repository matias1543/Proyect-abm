namespace Alta.Models
{
    public class Producto
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string TipoAlimento { get; set; }
        public string TipoMascota { get; set; }
        public string EdadMascota { get; set; }
        public string TamanioMascota { get; set; }
        public double Kilogramos { get; set; }
        public double Precio { get; set; }
    }
}