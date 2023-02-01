function editElement(element, match, replacer) {
   const text =  element.textContent;
   const replaced = text.split(match).join(replacer);
   element.textContent = replaced;
}