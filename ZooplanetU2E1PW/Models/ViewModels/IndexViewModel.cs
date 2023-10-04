namespace ZooplanetU2E1PW.Models.ViewModels
{
    public class IndexViewModel
    {
       public int Id { get; set; }

        public List<Animales> animales { get; set; }

    }
    public class Animales 
    {
        public int Id { get; set; }
        public string Nombre { get; set;} = null!;
        public string Descripcion { get;set; } = null!;
    }
}
