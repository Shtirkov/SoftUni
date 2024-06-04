function validate() {
    const inputEl = document.getElementById('email');
    inputEl.addEventListener('change', onChange);
    const emailRegex = /^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$/;

    function onChange(ev) {
        if (!emailRegex.exec(ev.target.value)) {
            inputEl.classList.add('error');
        }
        else {
            inputEl.classList.remove('error');
        }
    }
}