function ticTacToe(playerMoves) {
    let playerToMove = 'X';

    let dashboard = [
        ['false', 'false', 'false'],
        ['false', 'false', 'false'],
        ['false', 'false', 'false']];

    for (const move of playerMoves) {
        const splitted = move.split(' ');
        const row = Number(splitted[0]);
        const col = Number(splitted[1]);

        if (dashboard[row][col] != 'false') {
            console.log('This place is already taken. Please choose another!');
            continue;
        }
        else {
            dashboard[row][col] = playerToMove;
        }

        if (dashboard.every(row => row.every(value => value != 'false'))) {
            console.log('The game ended! Nobody wins :(');
            dashboard.forEach((row) => console.log(row.join('\t')));
            return;
        }

        if (dashboard[0][0] == playerToMove && dashboard[0][1] == playerToMove && dashboard[0][2] == playerToMove ||
            dashboard[1][0] == playerToMove && dashboard[1][1] == playerToMove && dashboard[1][2] == playerToMove ||
            dashboard[2][0] == playerToMove && dashboard[2][1] == playerToMove && dashboard[2][2] == playerToMove ||
            dashboard[0][0] == playerToMove && dashboard[1][1] == playerToMove && dashboard[2][2] == playerToMove ||
            dashboard[0][2] == playerToMove && dashboard[1][1] == playerToMove && dashboard[2][0] == playerToMove ||
            dashboard[0][0] == playerToMove && dashboard[1][0] == playerToMove && dashboard[2][0] == playerToMove ||
            dashboard[0][1] == playerToMove && dashboard[1][1] == playerToMove && dashboard[2][1] == playerToMove ||
            dashboard[0][2] == playerToMove && dashboard[1][2] == playerToMove && dashboard[2][2] == playerToMove) {
            console.log(`Player ${playerToMove} wins!`);
            dashboard.forEach((row) => console.log(row.join('\t')));
            return;
        }
        playerToMove == 'X' ? playerToMove = 'O' : playerToMove = 'X';
    }
}

ticTacToe(["0 1",
    "0 0",
    "0 2",
    "2 0",
    "1 0",
    "1 1",
    "1 2",
    "2 2",
    "2 1",
    "0 0"]
);