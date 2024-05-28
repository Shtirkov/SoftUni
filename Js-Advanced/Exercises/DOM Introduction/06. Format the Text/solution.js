function solve() {
  const tokens = document.getElementById('input').value.split('.').filter(el => el != '');
  const outputElement = document.getElementById('output');
  let outputText = '';
  let counter = 0;

  for (const token of tokens) {

    if (counter == 3) {
      outputText += '</p>';
      counter = 0;
    }

    if (counter == 0) {
      outputText += `<p>${token}.`
    } else {
      outputText += ` ${token}.`;
    }
    counter++;
  }

  outputElement.innerHTML = outputText;
}