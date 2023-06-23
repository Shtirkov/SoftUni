using BorderControl.Interfaces;

namespace BorderControl
{
    public class Citizen : IIdentifiable
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
