async function attachEvents() {
  const button = document.getElementById('submit');
  button.addEventListener('click', visualizeForecasts);
}

async function getLocations(){
    const url = `http://localhost:3030/jsonstore/forecaster/locations`;
   
    try {
        const response = await fetch(url);

        if (response.status != 200) {
            throw new Error('Error');
        }
        
        const data = await response.json();
        return data;
    } catch (error) {
        throw(error);
    }
   
}

function filterLocations(locationName,locations){
    try {
        locations.forEach(x =>x.name = x.name.toLowerCase());
        const location = locations.filter(x => x.name==locationName.toLowerCase())[0];

        if (location == undefined) {
            throw new Error('Invalid location');
        }

        return location;
    } catch (error) {
        throw(error);
    }
}

async function getCurrentDayForecast(location){
 const url = `http://localhost:3030/jsonstore/forecaster/today/${location.code}`;
 const response = await fetch(url);
 const data = await response.json();
 return data;
}

async function getFutureDaysForecast(location){
 const url = `http://localhost:3030/jsonstore/forecaster/upcoming/${location.code}`;
 const response = await fetch(url);
 const data = await response.json();
 return data;
}

async function visualizeForecasts(){
    const button = document.getElementById('submit');
    button.disabled = true;
    const forecastsDiv = document.getElementById('forecast');
    const currentForecastSection = document.getElementById('current');
    const futureForecastSection = document.getElementById('upcoming');
    const locationName = document.getElementById('location').value;

    const conditions = {
        Sunny: '&#x2600;',
        'Partly sunny': '&#x26C5;',
        Overcast: '&#x2601;',
        Rain: '&#x2614;'        
    }

  try {
   
    forecastsDiv.style = 'display:none';
    const locations = await getLocations();
    const location = filterLocations(locationName,locations);
    const currentDayForecast = await getCurrentDayForecast(location);
    const todayCondition = currentDayForecast.forecast.condition;
    const todayForecastElement = document.createElement('div');
    todayForecastElement.className = 'forecasts';
    currentForecastSection.innerHTML = '';
    todayForecastElement.innerHTML = `<span class="condition symbol">${conditions[todayCondition]}</span>
                                <span class="forecast-data">${currentDayForecast.name}</span>
                                <span class="forecast-data">${currentDayForecast.forecast.low}°/${currentDayForecast.forecast.high}°</span>
                                <span class="forecast-data">${todayCondition}</span>
                                </span>`;

    currentForecastSection.innerHTML = '<div class="label">Current conditions</div>';
    currentForecastSection.appendChild(todayForecastElement);

    const futureForecast = await getFutureDaysForecast(location);
    const futureForecastElement = document.createElement('div');
    futureForecastElement.className = 'forecast-info';
    futureForecastSection.innerHTML = '';
    futureForecastElement.innerHTML = `<span class=upcoming>
                               <span class="symbol">${conditions[futureForecast.forecast[0].condition]}</span>
                               <span class="forecast-data">${futureForecast.forecast[0].low}°/${futureForecast.forecast[0].high}°</span>
                               <span class="forecast-data">${futureForecast.forecast[0].condition}</span>
                               </span>
                               <span class=upcoming>
                               <span class="symbol">${conditions[futureForecast.forecast[1].condition]}</span>
                               <span class="forecast-data">${futureForecast.forecast[1].low}°/${futureForecast.forecast[1].high}°</span>
                               <span class="forecast-data">${futureForecast.forecast[1].condition}</span>
                               </span>
                               <span class=upcoming>
                               <span class="symbol">${conditions[futureForecast.forecast[2].condition]}</span>
                               <span class="forecast-data">${futureForecast.forecast[2].low}°/${futureForecast.forecast[2].high}°</span>
                               <span class="forecast-data">${futureForecast.forecast[2].condition}</span>
                               </span>`;

    futureForecastSection.innerHTML = '<div class="label">Three-day forecast</div>';                          
    futureForecastSection.appendChild(futureForecastElement);
    forecastsDiv.style = 'inline';
    button.disabled = false;
  } catch (error) {   
      button.disabled = true;
      currentForecastSection.innerHTML = `${error}`;
      futureForecastSection.innerHTML = '';
      forecastsDiv.style = 'inline';
      button.disabled = false;
  }
}

attachEvents();