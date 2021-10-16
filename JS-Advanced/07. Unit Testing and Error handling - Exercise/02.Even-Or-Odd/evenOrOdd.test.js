const {expect} = require('chai');
const isOddOrEven = require('./evenOrOdd');

describe('Tests', () => {

    it('Should return undefined with parameter which is not string', () => {
        expect(isOddOrEven(5)).to.be.undefined;
    });

    it('Should return even for string with even lenght', () => {
        expect(isOddOrEven("abcd")).to.be.equal('even');
    });

    it('Should return odd for string with odd lenght', () => {
        expect(isOddOrEven("abcde")).to.be.equal('odd');
    });
})