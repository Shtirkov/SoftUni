function createHero() {
    return {
        mage: (name) => createMage(name),
        fighter: (name) => createFighter(name)
    }

    function createMage(name) {
        const mage = {
            name,
            health: 100,
            mana: 100,
            cast: (spell) => {
                mage.mana--;
                console.log(`${name} cast ${spell}`);
            }
        }

        return mage;
    }

    function createFighter(name) {
        const fighter = {
            name,
            health: 100,
            stamina: 100,
            fight: () => {
                fighter.stamina--;
                console.log(`${name} slashes at the foe!`);
            }
        }
        return fighter;

    }
}

let create = createHero();
const scorcher = create.mage("Scorcher");
scorcher.cast("fireball")
scorcher.cast("thunder")
scorcher.cast("light")

const scorcher2 = create.fighter("Scorcher 2");
scorcher2.fight()

console.log(scorcher2.stamina);
console.log(scorcher.mana);
