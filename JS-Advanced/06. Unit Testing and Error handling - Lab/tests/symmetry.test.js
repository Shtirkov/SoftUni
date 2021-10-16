const {expect} = require('chai');
const isSymmetric = require('./symmetry');

describe('Tests', () => {
    it('Should return true for symetric array', () => {
        expect(isSymmetric([1,2,2,1])).to.be.true;
    });

    it('Should return false for non-symetric array', () => {
        expect(isSymmetric([1,2,2,3])).to.be.false;
    });

    it('Should return false for symetric array with different data types', () => {
        expect(isSymmetric([1,2,2,'1'])).to.be.false;
    });

    it('Should return false if the parameter is not an array', () => {
        expect(isSymmetric(1)).to.be.false;
    });

    it('Should return false if the parameter is not an array and from string type', () => {
        expect(isSymmetric('asdf')).to.be.false;
    });

    it('Should return true for symetric array of strings', () => {
        expect(isSymmetric(['a','b','b','a'])).to.be.true;
    });
});
