function extract(content) {
    const el = document.getElementById(content);
    const text = el.textContent;
    const regex = /\(([^)]+)\)/g;
    const matches = [];

    let match;
    while ((match = regex.exec(text)) != null) {
        matches.push(match[1]);
    }

    return matches.join(';' + '\n');
}