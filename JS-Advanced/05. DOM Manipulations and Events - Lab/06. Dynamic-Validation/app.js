function validate() {
  const field = document.getElementById('email');

  field.addEventListener('change', onChange);

  function onChange(ev){
      let email = ev.target.value;
      let isValid = true;
      const regex = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
      regex.test(email) ? isValid = true : isValid = false;

      if (isValid == true) {
         email = email.replace('@', '');
         email =  email.replace('.', '');

          for (let i = 0; i < email.length; i++) {
            if (email[i] == email[i].toUpperCase()) {
                isValid = false;
            }
          }
      }
      

        if (isValid == false) {
            ev.target.classList.add('error');
        }else{
            ev.target.classList.remove('error');
        }
  }
}