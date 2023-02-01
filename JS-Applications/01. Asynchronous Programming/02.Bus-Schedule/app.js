function solve() {
    let url = `http://localhost:3030/jsonstore/bus/schedule/depot`;
    const departBtn = document.getElementById('depart');
    const arriveBtn = document.getElementById('arrive');
    const infoBox = document.getElementById('info');
    let currentStop = 'depot';

    async function depart() {
        infoBox.textContent = 'Fetching data...';
        departBtn.disabled = true;
        const data = await getStopData();
        currentStop = data.name;
        infoBox.textContent = `Next stop ${currentStop}`;
        url = `http://localhost:3030/jsonstore/bus/schedule/${data.next}`;
        arriveBtn.disabled = false;
    }

    async function arrive() {
        infoBox.textContent = 'Fetching data...';
        arriveBtn.disabled = true;
        const data = await getStopData();
        infoBox.textContent = `Arriving at ${currentStop}`;
        departBtn.disabled = false;
    }

    async function getStopData(){
        try {
            const response = await fetch(url);

            if (response.status != 200) {
                throw new Error('Error');
            }

            const data = await response.json();
            return data;
        } catch (error) {
            infoBox.textContent = error;
        }      
    }

    return {
        depart,
        arrive
    };
}

let result = solve();