namespace PizzaRestaurant.Models
{
    public class Dough
    {
        private const string InvalidFlourTypeExceptionMessage = "Invalid type of dough.";
        private const string InvalidWeightExceptionMessage = "Dough weight should be in the range [1..200].";
        private const int BaseCaloriesPerGram = 2;

        private string _flourType;
        private string _bakingTechnique;
        private int _weight;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string FlourType
        {
            get => _flourType;
            private set
            {
                if (!IngridientsHelper.FlourTypes.ContainsKey(value))
                {
                    throw new ArgumentException(InvalidFlourTypeExceptionMessage);
                }

                _flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => _bakingTechnique;
            private set
            {
                if (!IngridientsHelper.BakingTechniques.ContainsKey(value))
                {
                    throw new ArgumentException(InvalidFlourTypeExceptionMessage);
                }

                _bakingTechnique = value;
            }
        }

        public int Weight
        {
            get => _weight;
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException(InvalidWeightExceptionMessage);
                }

                _weight = value;
            }
        }

        public double CalculateCalories() => BaseCaloriesPerGram * _weight * IngridientsHelper.FlourTypes[_flourType] * IngridientsHelper.BakingTechniques[_bakingTechnique];

    }
}