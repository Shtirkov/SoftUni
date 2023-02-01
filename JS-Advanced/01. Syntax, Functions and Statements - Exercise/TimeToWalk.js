function timeToWalk(stepsCount, stepLengthInMeters, speed){
let distanceToUniversityInMeters = stepsCount * stepLengthInMeters;
let restsTime = Math.floor(distanceToUniversityInMeters / 500);
let metersPerSecond = speed / 3.6;
let timeToWalkInSeconds = distanceToUniversityInMeters / metersPerSecond;

let minutes = Math.floor(timeToWalkInSeconds / 60);
let seconds = Math.round(timeToWalkInSeconds - (minutes * 60));
let hours = Math.floor(timeToWalkInSeconds / 3600);

console.log(`${hours < 10 ? "0" : ""}${hours}:${minutes + restsTime < 10 ? "0" : ""}${minutes + restsTime}:${seconds < 10 ? "0" : ""}${seconds}`)
}

timeToWalk(2564, 0.70, 5.5);