function toggle() {

    let buttonName = document.getElementsByClassName('button')[0].textContent;
    const element = document.getElementById('extra');

    if (buttonName == 'More') {
        element.style.display = 'block';
        buttonName = 'Less';
        document.getElementsByClassName('button')[0].textContent='Less';
    }else if(buttonName == 'Less'){
        element.style.display= 'none';
        buttonName = 'More';
        document.getElementsByClassName('button')[0].textContent='More';
    }
}