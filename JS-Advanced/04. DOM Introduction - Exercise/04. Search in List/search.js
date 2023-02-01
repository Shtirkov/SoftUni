function search() {
  const searchBoxText = document.getElementById('searchText').value.toLowerCase();
  const towns = document.getElementById('towns').children;
  let matches = 0;

  for (const town of Array.from(towns)) {
     if (town.textContent.toLowerCase().includes(searchBoxText)) {
        town.style.fontWeight = 'bold';
        town.style.textDecoration  = 'underline';
        matches++;
     }else{
        town.style.fontWeight = 'normal';
        town.style.textDecoration = '';
     }
  }

  document.getElementById('result').textContent = `${matches} matches found`
}
