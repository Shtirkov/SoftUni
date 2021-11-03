class SummerCamp{
    constructor(organizer, location){
        this.organizer = organizer;
        this.location = location;
        this.priceForCamp = {"child": 150, "student": 300, "collegian": 500};
        this.listOfParticipants = [];
    };

    registerParticipant(name, condition, money){
        if (!this.priceForCamp[condition]) {
            throw new Error('Unsuccessful registration at the camp.');
        };

        if (this.listOfParticipants.some(p => p.name == name)) {
            return `The ${name} is already registered at the camp.`
        };

        if (money < this.priceForCamp[condition]) {
            return `The money is not enough to pay the stay at the camp.`;
        };

        const participant = {
            name: name,
            condition: condition,
            power: 100,
            wins: 0
        };

        this.listOfParticipants.push(participant);
        return `The ${name} was successfully registered.`;
    };

    unregisterParticipant(name){
        if (!this.listOfParticipants.some(p => p.name == name)) {
            throw new Error(`The ${name} is not registered in the camp.`);
        };

        const participant = this.listOfParticipants.find(p => p.name == name);
        const index = this.listOfParticipants.indexOf(participant);
        this.listOfParticipants.splice(index,1);
        return `The ${name} removed successfully.`;
    };

    timeToPlay(typeOfGame, participant1, participant2){
       
        if (typeOfGame == 'WaterBalloonFights') {
            if (!this.listOfParticipants.some(p => p.name == participant1) || !this.listOfParticipants.some(p => p.name == participant2)) {
                throw new Error(`Invalid entered name/s.`);
            };
    
            const firstPlayer = this.listOfParticipants.find(p => p.name == participant1);
            const secondPlayer = this.listOfParticipants.find(p => p.name == participant2);
    
            if (firstPlayer.condition != secondPlayer.condition) {
                throw new Error(`Choose players with equal condition.`);
            };    

            if (firstPlayer.power == secondPlayer.power) {
                return `There is no winner.`
            };

            if (firstPlayer.power > secondPlayer.power) {
                firstPlayer.wins +=1;
                return `The ${firstPlayer.name} is winner in the game ${typeOfGame}.`
            }else{
                secondPlayer.wins +=1;
                return `The ${secondPlayer.name} is winner in the game ${typeOfGame}.`
            }
            
        }else if(typeOfGame == 'Battleship'){
            if (!this.listOfParticipants.some(p => p.name == participant1)) {
                throw new Error(`Invalid entered name/s.`);
            };

            const player = this.listOfParticipants.find(p => p.name == participant1);
            player.power += 20;

            return `The ${player.name} successfully completed the game ${typeOfGame}.`
        }
    };

    toString(){
        let result = [`${this.organizer} will take ${this.listOfParticipants.length} participants on camping to ${this.location}`];
        this.listOfParticipants = this.listOfParticipants.sort((a,b) => b.wins - a.wins);
        this.listOfParticipants.forEach(p => result.push(`${p.name} - ${p.condition} - ${p.power} - ${p.wins}`));

        return result.join('\n');
    }
}


