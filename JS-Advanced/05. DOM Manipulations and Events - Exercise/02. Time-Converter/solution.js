function attachEventsListeners() {

    const elements = document.getElementsByTagName('div');

    for (const element of elements) {
        element.addEventListener('click', onClick);
    }

    function onClick(ev){
        if (ev.target.value == 'Convert') {
           const buttonId = ev.target.id;

            if (buttonId == 'daysBtn') {
                const days = document.getElementById('days').value;
                const hours = days * 24;
                const minutes = hours * 60;
                const seconds = minutes * 60;

                document.getElementById('hours').value = hours;
                document.getElementById('minutes').value = minutes;
                document.getElementById('seconds').value = seconds;
                
            }else if(buttonId == 'hoursBtn'){
                const hours = document.getElementById('hours').value;
                const days = hours / 24;
                const minutes = hours * 60;
                const seconds = minutes * 60;

                document.getElementById('days').value = days;
                document.getElementById('minutes').value = minutes;
                document.getElementById('seconds').value = seconds;
                
            }else if(buttonId == 'minutesBtn'){
                const minutes = document.getElementById('minutes').value;
                const hours = minutes / 60;
                const days = hours / 24;
                const seconds = minutes * 60;

                document.getElementById('hours').value = hours;
                document.getElementById('days').value = days;
                document.getElementById('seconds').value = seconds;

            }else if(buttonId == 'secondsBtn'){
                const seconds = document.getElementById('seconds').value;
                const minutes = seconds / 60;
                const hours = minutes / 60;
                const days = hours / 24;

                document.getElementById('hours').value = hours;
                document.getElementById('days').value = days;
                document.getElementById('minutes').value = minutes;
            }
            
        }
    }
}