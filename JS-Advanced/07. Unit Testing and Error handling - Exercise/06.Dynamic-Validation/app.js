function validate() {
   const emailField = document.getElementById('email');
   const emailValidationRegex = /([a-z]+@[a-z]+\.[a-z]+)/;
   
   emailField.addEventListener('change', () => {
       if (!emailValidationRegex.test(emailField.value)) {
           emailField.classList.add('error');
       }else{
           emailField.classList.remove('error');
       }
   })
}