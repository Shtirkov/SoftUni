namespace Raiding.Models
{
    public class Paladin : Hero
    {
        public Paladin(string name)
            : base(name, Constants.PaladinPower)
        { }

        public override string CastAbility() => string.Format(Constants.CastAbilityMessageForDruidAndPaladin, GetType().Name, Name, Constants.PaladinPower);
    }
}
