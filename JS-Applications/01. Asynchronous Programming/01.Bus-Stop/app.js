async function getInfo() {
    const inputField = document.getElementById('stopId');
    const stopId = inputField.value;
    const stopName = document.getElementById('stopName');
    const ulElement = document.getElementById('buses');
    const url = `http://localhost:3030/jsonstore/bus/businfo/${stopId}`

    ulElement.innerHTML = '';
    stopName.textContent = 'Loading...';

    try {
        const response = await fetch(url);

        if (response.status != 200 || inputField.value == '') {
           throw new Error('Error'); 
        }

        const data = await response.json();
    
        stopName.textContent = data.name;
        
        Object.entries(data.buses).forEach(b => {
            const liElement = document.createElement('li');
            liElement.textContent = `Bus ${b[0]} arrives in ${b[1]} minutes`;
            ulElement.appendChild(liElement);
        })    
    } catch (error) {
      stopName.textContent = error.message;
    }   
}