function addAndRemove(commands) {
    const output = [];
    let elementToAdd = 1;
    for (const command of commands) {
        if (command == 'add') {
            output.push(elementToAdd);
            elementToAdd++;
        } else if (command == 'remove') {
            output.pop(elementToAdd);
            elementToAdd++;
        }
    }

    output.length > 0 ? console.log(output.join('\n')) : console.log('Empty');
}

addAndRemove(['add',
    'add',
    'add',
    'add']
)

addAndRemove(['add',
    'add',
    'remove',
    'add',
    'add']
);

addAndRemove(['remove',
    'remove',
    'remove']
);