const {expect} = require('chai');
const createCalculator = require('./addSubtract');

describe('Tests', () => {
    let instance = null;

    beforeEach(() => {
        instance = createCalculator();
    });

    it('Should have all required methods', () => { 
        expect(instance).to.haveOwnProperty('add');
        expect(instance).to.haveOwnProperty('subtract');
        expect(instance).to.haveOwnProperty('get');        
    });

    it('Should add positive number', () => { 
        instance.add(1);
        expect(instance.get()).to.be.equal(1);    
    });

    it('Should add negative number', () => { 
        instance.add(-1);
        expect(instance.get()).to.be.equal(-1);    
    });

    it('Should parse and add positive number', () => { 
        instance.add('1');
        expect(instance.get()).to.be.equal(1);    
    });

    it('Should parse and add negative number', () => { 
        instance.add('-1');
        expect(instance.get()).to.be.equal(-1);    
    });

    it('Should subtract positive number', () => { 
        instance.subtract(1);
        expect(instance.get()).to.be.equal(-1);    
    });

    it('Should parse and subtract positive number', () => { 
        instance.subtract('1');
        expect(instance.get()).to.be.equal(-1);    
    });

    it('Should subtract negative number', () => { 
        instance.subtract(-1);
        expect(instance.get()).to.be.equal(1);    
    });

    it('Should parse and subtract negative number', () => { 
        instance.subtract('-1');
        expect(instance.get()).to.be.equal(1);    
    });
});