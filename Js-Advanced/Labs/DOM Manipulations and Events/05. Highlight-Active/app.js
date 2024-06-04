function focused() {
    [...document.getElementsByTagName('input')]
        .forEach(i => {
            i.addEventListener('focus', (ev) => ev.target.parentNode.classList.add('focused'));
            i.addEventListener('blur', (ev) => ev.target.parentNode.classList.remove('focused'));
        });
}   