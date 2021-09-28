function deleteByEmail() {
 const inputField = document.getElementsByName('email')[0];
 const emailToDelete = inputField.value;    
 const elements = document.querySelectorAll('tbody tr');
 const result = document.getElementById('result');
 let deleted = false;

 for (const element of elements) {
     const email = element.children[1].textContent;
     if (email == emailToDelete) {
         element.remove();
         deleted = true;
         }
 }

 if (deleted == true) {
     result.textContent = 'Deleted.'
 }else{
    result.textContent = 'Not found.'
 }

 inputField.value = '';
}