function solve() {
  const text = document.getElementById('text').value.toLowerCase();
  const casing = document.getElementById('naming-convention').value;
  const result = document.getElementById('result');
  const words = text.split(' ');
  let output = '';

  if (casing != 'Camel Case' && casing != 'Pascal Case') {
    output += 'Error!';
  } else {
    words.forEach(word => output += word[0].toUpperCase() + word.slice(1));
  }

  casing == 'Camel Case' ? output = output[0].toLowerCase() + output.slice(1) : output;
  result.textContent = output;
}