const {expect} = require('chai');
const sum = require('./sum');

describe('Tests', () => {
    it('Should have sum equal to 6', () => {
        expect(sum([1,2,3])).to.equal(6);
    });
   
});