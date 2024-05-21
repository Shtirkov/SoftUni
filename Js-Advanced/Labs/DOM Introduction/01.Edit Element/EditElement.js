function editElement(el, match, replacer) {
    const elementText = el.textContent;
    const newText = elementText.split(match).join(replacer);
    el.textContent = newText;
}