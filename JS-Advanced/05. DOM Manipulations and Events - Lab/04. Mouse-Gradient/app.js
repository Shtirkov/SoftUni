function attachGradientEvents() {
    
    const element = document.getElementById('gradient-box');
    element.addEventListener('mousemove', onMove);
    const result = document.getElementById('result');

    function onMove(ev){     
      result.textContent = `${Math.floor(ev.offsetX / ev.target.clientWidth * 100)}%`;
    }
}