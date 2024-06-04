function attachGradientEvents() {
    const gradient = document.getElementById('gradient-box');
    const result = document.getElementById('result');

    gradient.addEventListener('mousemove', (ev) => result.textContent = `${Math.floor(+ev.offsetX / 3)}%`);
}