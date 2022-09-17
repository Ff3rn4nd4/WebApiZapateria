namespace WebApiZapateria.Entidades
{
    public class DatosExtra
    {
        //esta entidad guardará datos temporales tales como la temporada de los zapatos y su precio
        public int Id { get; set; }
        public string Temporada { get; set; }
        public int Precio { get; set; }
    }
}
