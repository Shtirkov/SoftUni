function editElement(el, match, replacer) {
    const elementText = el.textContent;
    const newText = elementText.split(match).join(replacer);
    // const newText = elementText.replace(match, replacer);
    el.textContent = newText;
}