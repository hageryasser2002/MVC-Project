namespace MVC_Projec2.Models
{
    public class Hall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; internal set; }
    }
}
