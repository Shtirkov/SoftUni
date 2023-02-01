function checkIfWorkerIsThirsty(worker){
    if (worker.dizziness == true) {
        const waterToDrink = worker.weight * 0.1 * worker.experience;
        worker.levelOfHydrated += waterToDrink;
        worker.dizziness = false;
    }

    return worker;
}

console.checkIfWorkerIsThirsty(solve({ weight: 80,
    experience: 1,
    levelOfHydrated: 0,
    dizziness: true }
  ));