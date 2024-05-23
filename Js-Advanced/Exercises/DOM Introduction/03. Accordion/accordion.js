function toggle() {
    const toggleButton = document.querySelector('.button');
    const hiddenText = document.getElementById('extra');

    if (toggleButton.textContent == 'More') {
        hiddenText.style.display = 'block';
        toggleButton.textContent = 'Less';
    } else if (toggleButton.textContent == 'Less') {
        hiddenText.style.display = 'none';
        toggleButton.textContent = 'More';
    }
}