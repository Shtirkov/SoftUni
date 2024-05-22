function subtract() {
    const firstNum = document.getElementById('firstNumber').value;
    const secondNum = document.getElementById('secondNumber').value;
    const result = document.getElementById('result');
    result.textContent = +firstNum - +secondNum;
}