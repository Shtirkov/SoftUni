function calculateWalkingTime(stepsCount, footprintLength, speedInKm) {
    const distanceInMeters = stepsCount * footprintLength;
    const speedInMeters = speedInKm * 1000 / 3600;
    const breaksInSeconds = Math.floor(distanceInMeters / 500) * 60;
    const timeSpentWalkingInSeconds = (distanceInMeters / speedInMeters) + breaksInSeconds;
    const hours = Math.floor(timeSpentWalkingInSeconds / 3600).toLocaleString('en-US', { minimumIntegerDigits: 2 });
    const minutes = Math.floor(timeSpentWalkingInSeconds % 3600 / 60).toLocaleString('en-US', { minimumIntegerDigits: 2 });
    const seconds = Math.round(timeSpentWalkingInSeconds % 3600 % 60).toLocaleString('en-US', { minimumIntegerDigits: 2 });

    console.log(`${hours}:${minutes}:${seconds}`);
}

calculateWalkingTime(4000, 0.60, 5);
calculateWalkingTime(2564, 0.70, 5.5);