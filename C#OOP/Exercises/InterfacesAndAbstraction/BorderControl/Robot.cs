using BorderControl.Interfaces;

namespace BorderControl
{
    public class Robot : IIdentifiable
    {
        public string Id { get; set; }
        public string Model { get; set; }
    }
}
