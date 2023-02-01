window.addEventListener('load', solve);

function solve() {
    const addBtn = document.getElementById('add-btn');
    addBtn.addEventListener('click', addSong);

    const allHitsContainer = document.querySelector('#all-hits div');
    const saveContainer = document.querySelector('#saved-hits div')

    function addSong(ev) {
        ev.preventDefault();
        const genre = document.getElementById('genre');
        const name = document.getElementById('name');
        const author = document.getElementById('author');
        const date = document.getElementById('date');

        if (genre.value == '' || name.value == '' || author.value == '' || date.value == '') {
            return;
        }

        allHitsContainer.innerHTML += `<div class='hits-info'>
        <img src = ./static/img/img.png>
        <h2> Genre: ${genre.value}</h2>
        <h2> Name: ${name.value}</h2>
        <h2> Author: ${author.value}</h2>
        <h3> Date: ${date.value}</h2>
        <button class ='save-btn'>Save song</button>
        <button class ='like-btn'>Like song</button>
        <button class ='delete-btn'>Delete</button>
        </div>`;

        genre.value = '';
        name.value = '';
        author.value = '';
        date.value = '';

        const likeBtns = Array.from(document.getElementsByClassName('like-btn'));
       
        likeBtns.forEach(b => b.addEventListener('click', likeSong.bind(null, b)));

        function likeSong(likeBtn){
            const totalLikes = document.querySelector('#total-likes p')
            const totalLikesNumber = Number(document.querySelector('#total-likes p').textContent.split(' ')[2]);
            
            totalLikes.textContent = `Total Likes: ${totalLikesNumber + 1}`;

            likeBtn.disabled = true;
        }

        const saveBtns = Array.from(document.getElementsByClassName('save-btn'));
        saveBtns.forEach(b => b.addEventListener('click', saveSong));

        function saveSong(ev){
            const song = ev.target.parentElement;
            const songProps = song.querySelectorAll('h2');
            const songGenre = songProps[0].textContent;
            const songName = songProps[1].textContent;
            const songAuthor = songProps[2].textContent;
            const songDate = song.querySelector('h3').textContent;

            song.innerHTML = `
            <img src = ./static/img/img.png>
            <h2> ${songGenre}</h2>
            <h2> ${songName}</h2>
            <h2> ${songAuthor}</h2>
            <h3> ${songDate}</h2>
            <button class ='delete-btn'>Delete</button>
            `;
            saveContainer.appendChild(song);

            const deleteBtns = Array.from(document.getElementsByClassName('delete-btn'));
            deleteBtns.forEach(b => b.addEventListener('click', deleteSong));

        }

        const deleteBtns = Array.from(document.getElementsByClassName('delete-btn'));
        deleteBtns.forEach(b => b.addEventListener('click', deleteSong));

        function deleteSong(ev){
            const song = ev.target.parentElement;
            song.remove();
        }
    }    
}