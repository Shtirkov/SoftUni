namespace Raiding.Models
{
    public class Druid : Hero
    {
        public Druid(string name)
            : base(name, Constants.DruidPower)
        { }

        public override string CastAbility() => string.Format(Constants.CastAbilityMessageForDruidAndPaladin, GetType().Name, Name, Constants.DruidPower);        
    }
}
