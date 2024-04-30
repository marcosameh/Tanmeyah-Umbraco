namespace UmbracoBlog.CustomModels
{
    public class NavBarNode
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public List<NavBarNode> Children { get; set; } = new List<NavBarNode>();
    }
}
