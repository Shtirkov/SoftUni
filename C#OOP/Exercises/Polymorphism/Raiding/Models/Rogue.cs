using Raiding.Common;

namespace Raiding.Models
{
    public class Rogue : Hero
    {
        public Rogue(string name)
            : base(name, Constants.RoguePower)
        { }

        public override string CastAbility() => string.Format(Constants.CastAbilityMessageForRogueAndWarrior, GetType().Name, Name, Constants.RoguePower);
    }
}
