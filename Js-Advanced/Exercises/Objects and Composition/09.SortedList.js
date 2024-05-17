function createSortedList() {
    const elements = [];

    const myList = {
        add: (el) => {
            elements.push(el);
            return elements.sort((a, b) => a - b);
        },
        remove: (index) => {
            if (index >= 0 && index < elements.length) {
                return elements.splice(index, 1);
            }
        },
        get: (index) => {
            if (index >= 0 && index < elements.length) {
                return elements[index];
            }
        },
        get size() {
            return elements.length;
        }
    };

    return myList;
}

let list = createSortedList();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1));
list.remove(1);
console.log(list.get(1));
console.log(list.size);
