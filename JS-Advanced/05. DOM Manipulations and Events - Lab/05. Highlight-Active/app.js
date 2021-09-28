function focused() {
   
    const elements = Array.from(document.getElementsByTagName('input'));
    for (const element of elements) {
        element.addEventListener('focus', onFocus);
        element.addEventListener('blur', outOfFocus);
    }

    function onFocus(ev){
       ev.target.parentNode.className = 'focused';
    }

    function outOfFocus(ev){
        ev.target.parentNode.className = '';
    }
}