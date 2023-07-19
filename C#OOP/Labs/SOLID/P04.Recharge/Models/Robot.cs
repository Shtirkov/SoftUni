using P04.Recharge.Interfaces;

namespace P04.Recharge.Models
{
    public class Robot : Worker, IRechargeable
    {
        private int _capacity;
        private int _currentPower;

        public Robot(string id, int capacity) 
            : base(id)
        {
          _capacity = capacity;
        }

        public int Capacity => _capacity;

        public int CurrentPower => _currentPower;

        public override void Work(int hours)
        {
            if (hours > _currentPower)
            {
                hours = _currentPower;
            }

            base.Work(hours);
            _currentPower -= hours;
        }

        public void Recharge() => _currentPower = _capacity;
    }
}