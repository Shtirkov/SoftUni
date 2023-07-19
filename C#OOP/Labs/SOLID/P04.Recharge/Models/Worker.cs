using P04.Recharge.Interfaces;

namespace P04.Recharge.Models
{
    public abstract class Worker : IWorker
    {
        private string _id;
        private int _workingHours;

        public Worker(string id)
        {
            _id = id;
        }

        public virtual void Work(int hours) => _workingHours += hours;
    }
}