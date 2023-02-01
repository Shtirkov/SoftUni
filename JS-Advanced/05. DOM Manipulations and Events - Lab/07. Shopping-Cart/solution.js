function solve() {
 const shoppingCart = document.getElementsByClassName('shopping-cart')[0];
 shoppingCart.addEventListener('click', onClick);
 const checkoutButton = document.getElementsByClassName('checkout')[0];
 checkoutButton.addEventListener('click', onChekoutClick);
 
 const textArea = document.getElementsByTagName('textarea')[0];
 const result = [];

 function onClick(ev){
  if(ev.target.classList.contains('add-product') && ev.target.tagName == 'BUTTON'){
   const product = ev.target.parentNode.parentNode;
   const productName = product.querySelector('.product-title').textContent;
   const price = Number(product.querySelector('.product-line-price').textContent);  

   result.push({
      productName,
      price
    });
  
   textArea.value += `Added ${productName} for ${price.toFixed(2)} to the cart.\n`;
 }
}

function onChekoutClick(ev){
  const products = new Set();
  result.forEach(p => products.add(p.productName));
  const total = result.reduce((t,c) => t + c.price,0)
  textArea.value += `You bought ${[...products.keys()].join(', ')} for ${total.toFixed(2)}.`;
  
  const buttons = document.getElementsByTagName('button');
  for (let button of buttons) {
    button.disabled = true;
  }
}
}