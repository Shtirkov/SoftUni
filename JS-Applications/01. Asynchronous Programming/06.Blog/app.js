function attachEvents() {
    const loadPostsButton = document.getElementById('btnLoadPosts');
    loadPostsButton.addEventListener('click', loadPosts);
    const viewButton = document.getElementById('btnViewPost');
    viewButton.addEventListener('click', visualizePost);
}

async function getPosts(){
    const url = `http://localhost:3030/jsonstore/blog/posts`;
    const response = await fetch(url);
    const data = await response.json();
    return data;
}

async function getComments(){
    const url = `http://localhost:3030/jsonstore/blog/comments`;
    const response = await fetch(url);
    const data = await response.json();
    return data;
}

async function loadPosts(){
    const postsSection = document.getElementById('posts');
    const posts = await getPosts();
  
    Object.entries(posts).forEach(p => {
    const postElement = document.createElement('option');
    postElement.value = `${p[0]}`;
    postElement.textContent = `${p[1].title}`;
    postsSection.appendChild(postElement);
    })
}

async function visualizePost(){   
   const postId = document.getElementById('posts').value;
   const url = 'http://localhost:3030/jsonstore/blog/posts/' + postId;

   const response = await fetch(url);
   const data = await response.json();

   const postTitle = document.getElementById('post-title');
   postTitle.textContent = data.title;

   const postBody = document.getElementById('post-body');
   postBody.textContent = data.body;
   visualizeComments(postId);
}

async function visualizeComments(postId){
    const url = 'http://localhost:3030/jsonstore/blog/comments';
    const response = await fetch(url);
    const data = await response.json();
    const postComments = document.getElementById('post-comments');

    const comments = [];

    for (const pId in data) {
       const comment = data[pId];
       if (comment.postId == postId) {
        comments.push(comment);
       }
    }

    postComments.innerHTML = '';
    comments.forEach(c =>{
        const liElement = document.createElement('li');
        liElement.textContent = c.text;
        postComments.appendChild(liElement);
    })

}
attachEvents();