namespace MVC_Projec2.Models
{
    public class Decor
    {
        public int Id { get; set; }
        public string Style { get; set; }
        public int Price { get; set; }
        public bool IsAvailable { get; internal set; }
    }
}
