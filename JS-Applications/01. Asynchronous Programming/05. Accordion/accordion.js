async function solution() {
   const data = await getArticles();
   visualizeData(data);   
}

function attachListeners(){
    const moreButtons = document.querySelectorAll('#main button');
    moreButtons.forEach(b => b.addEventListener('click', toggleArticle));
}

async function getArticles(){
    const url = `http://localhost:3030/jsonstore/advanced/articles/list`;
    const response = await fetch(url);
    const data = await response.json();
    return data;
}

async function getArticleContent(articleId){
    const url = `http://localhost:3030/jsonstore/advanced/articles/details/${articleId}`;
    const response = await fetch(url);
    const data = await response.json();
    return data.content;
}

function visualizeData(data){
    const mainDiv = document.getElementById('main');
    
    data.forEach(async a => {
        const article = document.createElement('div');
        const articleContent = await getArticleContent(a._id);
        article.className = 'accordion';
        article.innerHTML = `<div class="head">
                             <span>${a.title}</span>
                             <button class="button" onclick="attachListeners()" id="${a._id}">More</button>
                             </div>
                             <div class="extra">
                             <p>${articleContent}</p>
                             </div>`;

        mainDiv.appendChild(article);
        attachListeners();
    });

}

function toggleArticle(ev){
    const button = ev.target;
    const parent = ev.target.parentElement.parentElement;
    const hiddenDiv = parent.querySelector('.extra');

    if (button.textContent == 'MORE' || button.textContent == 'More') {
        hiddenDiv.style.display = 'inline';
        button.textContent = 'LESS';
    }else{
        hiddenDiv.style.display = 'none';
        button.textContent = 'MORE';
    }   
}

solution();