function solve() {
   document.getElementsByClassName('shopping-cart')[0].addEventListener('click', onClick);
   document.getElementsByClassName('checkout')[0].addEventListener('click', onCheckout);
   const resultEl = document.getElementsByTagName('textarea')[0];
   const productLables = new Set();
   let totalPrice = 0

   function onClick(ev) {
      if (ev.target.className == 'add-product') {
         const currentProduct = ev.target.parentNode.parentNode;
         const productName = currentProduct.getElementsByClassName('product-title')[0].textContent;
         const productPrice = +currentProduct.getElementsByClassName('product-line-price')[0].textContent;
         productLables.add(productName);
         totalPrice += productPrice;
         resultEl.textContent += `Added ${productName} for ${productPrice.toFixed(2)} to the cart.\n`;
      }
   }

   function onCheckout() {
      resultEl.textContent += `You bought ${[...productLables].join(', ')} for ${totalPrice.toFixed(2)}.`;
      [...document.getElementsByTagName('button')].forEach(b => b.disabled = true);
   }
}