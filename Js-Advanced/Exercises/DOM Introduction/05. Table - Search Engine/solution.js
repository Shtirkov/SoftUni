function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      const tableRows = document.querySelectorAll('tbody tr');
      const searchText = document.getElementById('searchField').value.toLowerCase();
      tableRows.forEach(row => row.classList.remove('select'));

      [...tableRows].forEach(row => {
         const cells = row.children;
         const match = [...cells].some(cell => cell.textContent.toLowerCase().includes(searchText));
         if (match && searchText != '') {
            row.classList.add('select');
         }
      })
   }
}