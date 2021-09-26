function solve() {
 const text = document.getElementById('input').value;
 const splitted = text.split('.').filter(item => item);
 let result = '';
 let counter = 0;

for (let entry of splitted) {

  if (counter == 0) {
    result += '<p>'
  }

 entry = entry.trim();

 if (entry) {
  result += entry;
  result += '. ';
  counter++;
 }

 if (counter == 3) {
   result += '</p>';
     counter = 0;
 }
}

 document.getElementById('output').innerHTML = result.trim();
}


