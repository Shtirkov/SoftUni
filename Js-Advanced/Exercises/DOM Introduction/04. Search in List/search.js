function search() {
   const townsList = document.getElementById('towns').children;
   const searchText = document.getElementById('searchText').value.toLowerCase();
   const result = document.getElementById('result');
   let filteredTowns = [];

   [...townsList].forEach(town => {
      town.style.fontWeight = '';
      town.style.textDecoration = '';
   });

   if (searchText != '') {
      filteredTowns = [...townsList].filter(town => town.textContent.toLowerCase().includes(searchText));
      filteredTowns.forEach(town => {
         town.style.fontWeight = 'bold';
         town.style.textDecoration = 'underline';
      });
   }

   result.textContent = `${filteredTowns.length} matches found`;
}
