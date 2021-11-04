async function lockedProfile() {
    const profileSection = document.getElementById('main');
    profileSection.innerHTML = '';
    const usersData = await getData();
    visualizeData(usersData);
    const profileButtons = document.querySelectorAll('.profile button');
    profileButtons.forEach(b => b.addEventListener('click', showMore));
    const lockedButtons = document.querySelectorAll('input[value="lock"');
    lockedButtons.forEach(b => b.addEventListener('click', hideAll));
}

async function getData(){
    const url = `http://localhost:3030/jsonstore/advanced/profiles`;
    const response = await fetch(url);
    const data = await response.json();

    return data;
}

function visualizeData(data){
    const profileSection = document.getElementById('main');
    let iterator = 1;

    for (const key in data) {
        const profileCard = document.createElement('div');
        profileCard.className = 'profile';
        profileCard.innerHTML = `<img src="./iconProfile2.png" class="userIcon" />
        <label>Lock</label>
        <input type="radio" name="user${iterator}Locked" value="lock" checked>
        <label>Unlock</label>
        <input type="radio" name="user${iterator}Locked" value="unlock"><br>
        <hr>
        <label>Username</label>
        <input type="text" name="user${iterator}Username" value="${data[key].username}" disabled readonly />
        <div class="hiddenInfo">
            <hr>
            <label>Email:</label>
            <input type="email" name="user${iterator}Email" value="${data[key].email}" disabled readonly />
            <label>Age:</label>
            <input type="email" name="user${iterator}Age" value="${data[key].age}" disabled readonly />
        </div>
        
        <button>Show more</button>`;

        profileSection.appendChild(profileCard);
        iterator++;        
    }
}

function showMore(ev){
    const expandCollapseButton = ev.target;
    const profile  = ev.target.parentNode;
    const hiddenFieldsInput = profile.querySelectorAll('.hiddenInfo input');
    const hiddenFieldsLabels = profile.querySelectorAll('.hiddenInfo label');
    const unlockButton = profile.querySelector('input[type="radio"][value="unlock"]');
      
      if (unlockButton.checked) {
        if (expandCollapseButton.textContent == 'Show more') {
            hiddenFieldsInput.forEach(x => x.style.display = 'inline');
            hiddenFieldsLabels.forEach(x => x.style.display = 'inline');            
            expandCollapseButton.textContent = 'Hide it';

        }else{
          hiddenFieldsInput.forEach(x => x.style.display = 'none');
          hiddenFieldsLabels.forEach(x => x.style.display = 'none');
          expandCollapseButton.textContent = 'Show more';
        }
    }
}

function hideAll(ev){
    const expandCollapseButton = document.querySelector('.profile button');
    const profile  = ev.target.parentNode;
    const hiddenFieldsInput = profile.querySelectorAll('.hiddenInfo input');
    const hiddenFieldsLabels = profile.querySelectorAll('.hiddenInfo label');

    hiddenFieldsInput.forEach(x => x.style.display = 'none');
    hiddenFieldsLabels.forEach(x => x.style.display = 'none');
    expandCollapseButton.textContent = 'Show more';
}

