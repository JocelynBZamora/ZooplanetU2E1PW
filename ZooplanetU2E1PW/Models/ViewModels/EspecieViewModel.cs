namespace ZooplanetU2E1PW.Models.ViewModels
{
    public class EspecieViewModel
    {
        List<Especie> especie { get; set; } = null!;
    }
    public class Especie 
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public double? Peso { get; set; }
        public int? Tamaño { get; set; }
        public string Habitad { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoEspecie { get; set; } = null!;
    }

}
