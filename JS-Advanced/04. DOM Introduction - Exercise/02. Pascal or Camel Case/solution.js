function solve() {
  const text = document.getElementById('text').value.toLowerCase();
  const namingConvention = document.getElementById('naming-convention').value;
  const splitted = text.split(' ');
  let result = 'Error!';
  

  if (namingConvention == 'Camel Case') {
    result = '';
    for (let i = 0; i < splitted.length; i++) {      
    
      if (i == 0) {
        result += splitted[i];
      }else{
        result += splitted[i][0].toUpperCase() + splitted[i].slice(1, splitted[i].length)
      }

    }
   

  } else if(namingConvention == 'Pascal Case'){
    result = '';

    for (let i = 0; i < splitted.length; i++) {     
      result += splitted[i][0].toUpperCase() + splitted[i].slice(1, splitted[i].length);
    }   
    
  }

  document.getElementById('result').textContent = result;
}