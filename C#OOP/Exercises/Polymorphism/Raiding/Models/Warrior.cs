using Raiding.Common;

namespace Raiding.Models
{
    public class Warrior : Hero
    {
        public Warrior(string name)
            : base(name, Constants.WarriorPower)
        { }

        public override string CastAbility() => string.Format(Constants.CastAbilityMessageForRogueAndWarrior, GetType().Name, Name, Constants.WarriorPower);
    }
}
