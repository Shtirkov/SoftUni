function objectFactory(library, orders) {
    const result = [];

    for (const order of orders) {
        const template = order['template'];
        const parts = order['parts'];
        const composedObj = Object.assign({}, template);
        parts.forEach(part => composedObj[part] = library[part]);
        result.push(composedObj);
    }

    return result;
}