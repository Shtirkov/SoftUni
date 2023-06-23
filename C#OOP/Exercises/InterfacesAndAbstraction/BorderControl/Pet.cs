using BorderControl.Interfaces;

namespace BorderControl
{
    public class Pet : IBirthable
    {
        public string Name { get; set; }
        public string Birthdate { get; set; }
    }
}
