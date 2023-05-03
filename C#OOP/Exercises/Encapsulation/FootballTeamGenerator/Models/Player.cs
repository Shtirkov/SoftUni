namespace FootballTeamGenerator.Models
{
    public class Player
    {
        private const string InvalidStatExceptionMessage = "{0} should be between 0 and 100.";
        private const int StatMinValue = 0;
        private const int StatMaxValue = 100;

        private string _name;
        private int _endurance;
        private int _sprint;
        private int _dribble;
        private int _passing;
        private int _shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public string Name
        {
            get => _name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidNameExceptionMessage);
                }

                _name = value;
            }
        }

        public int Endurance
        {
            get => _endurance;
            private set
            {
                if (value < StatMinValue || value > StatMaxValue)
                {
                    throw new ArgumentException(string.Format(InvalidStatExceptionMessage, "Endurance"));
                }

                _endurance = value;
            }
        }

        public int Sprint
        {
            get => _sprint;
            private set
            {
                if (value < StatMinValue || value > StatMaxValue)
                {
                    throw new ArgumentException(string.Format(InvalidStatExceptionMessage, "Sprint"));
                }

                _sprint = value;
            }
        }

        public int Dribble
        {
            get => _dribble;
            private set
            {
                if (value < StatMinValue || value > StatMaxValue)
                {
                    throw new ArgumentException(string.Format(InvalidStatExceptionMessage, "Dribble"));
                }

                _dribble = value;
            }
        }

        public int Passing
        {
            get => _passing;
            private set
            {
                if (value < StatMinValue || value > StatMaxValue)
                {
                    throw new ArgumentException(string.Format(InvalidStatExceptionMessage, "Passing"));
                }

                _passing = value;
            }
        }

        public int Shooting
        {
            get => _shooting;
            private set
            {
                if (value < StatMinValue || value > StatMaxValue)
                {
                    throw new ArgumentException(string.Format(InvalidStatExceptionMessage, "Shooting"));
                }

                _shooting = value;
            }
        }

        //public double OveralSkillLevel => (double)(_endurance + _sprint + _dribble + _passing + _shooting) / 5;
    }
}
