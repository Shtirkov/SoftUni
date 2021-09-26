function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      const selected = Array.from(document.getElementsByClassName('select'));

      if (selected.length > 0) {
         selected.forEach(el => {
            el.className = '';
            el.style.backgroundColor = '';
         });
      }

     const searchText = document.getElementById('searchField').value.toLowerCase();
     const elements = Array.from(document.querySelectorAll('table tr'));
     for (let i = 1; i < elements.length; i++) {
        
      if (elements[i].textContent.toLowerCase().includes(searchText)) {
         elements[i].style.backgroundColor = 'yellow';
         elements[i].className = 'select';
      }        
     }


     document.getElementById('searchField').value = '';
   }
}