namespace WebApiZapateria.Entidades
{
    public class Zapato
    {
        public int Id {get;set;}
        //datos: id, color, material, talla 
        public int Codigo { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public int Talla { get; set; }
    }
}
