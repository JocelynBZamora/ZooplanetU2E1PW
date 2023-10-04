namespace ZooplanetU2E1PW.Models.ViewModels
{
    public class EspeciesViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public List<Espe> espes { get; set; } = null!;
    }
    public class Espe
    {
        public int Id { get; set; }
        public int IdClase { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
