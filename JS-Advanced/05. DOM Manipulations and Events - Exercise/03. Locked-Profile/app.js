function lockedProfile() {
   [...document.querySelectorAll('.profile button')].forEach(b => b.addEventListener('click', onClick));
   

   function onClick(ev){
      const expandCollapseButton = ev.target;
      const profile = ev.target.parentElement;
      const hiddenFieldsDiv = [...profile.querySelectorAll('div')].find(d => d.id.includes('HiddenFields'));
      const unlockButton = profile.querySelector('input[type="radio"][value="unlock"]');
      
      if (unlockButton.checked) {
        if (expandCollapseButton.textContent == 'Show more') {
            hiddenFieldsDiv.style.display = 'block';
            expandCollapseButton.textContent = 'Hide it';
        }else{
          hiddenFieldsDiv.style.display = 'none';
          expandCollapseButton.textContent = 'Show more';
        }
      }
   }
}