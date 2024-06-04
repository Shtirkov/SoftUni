function deleteByEmail() {
    const emailToDelete = document.getElementsByTagName('input')[0].value;
    const email = [...document.querySelectorAll('tbody td:nth-child(2)')].find(e => e.textContent == emailToDelete);
    const result = document.getElementById('result');

    if (email) {
        email.parentElement.remove();
        result.textContent = 'Deleted.'
    } else {
        result.textContent = 'Not found.'
    }
}