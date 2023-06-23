using BorderControl.Interfaces;

namespace BorderControl
{
    public class Robot : IIdentifiable
    {
        public string Model { get; set; }
        public string Id { get; set; }
    }
}
