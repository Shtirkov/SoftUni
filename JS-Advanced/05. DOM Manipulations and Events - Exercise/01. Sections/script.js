function create(words) {
   const content = document.getElementById('content');
  
  for (const word of words) {
    const div =  document.createElement('div');
    const paragraph = document.createElement('p');
    paragraph.style.display = 'none';
    paragraph.textContent = word;
    div.appendChild(paragraph);
    div.addEventListener('click', onClick);
    content.appendChild(div);
  }

  function onClick(ev){
   const div = ev.currentTarget;
   const paragraph = div.children[0];
   paragraph.style.display = '';
  }
}