const {expect} = require('chai');
const mathEnforcer = require('./mathEnforcer');

describe('Tests', () => {

    it('Add should return number raised with 5 for positive number input', () => {
        expect(mathEnforcer.addFive(0)).to.be.equal(5);
    });

    it('Add should return number raised with 5 for negative number input', () => {
        expect(mathEnforcer.addFive(-5)).to.be.equal(0);
    });

    it('Add should return number raised with 5 for decimal number input', () => {
        expect(mathEnforcer.addFive(1.5)).to.be.equal(6.5);
    });

    it('Add should return undefined for incorrect input', () => {
        expect(mathEnforcer.addFive('0')).to.be.undefined;
    });

    it('Subtract should return number minus 10 for positive number input', () => {
        expect(mathEnforcer.subtractTen(0)).to.be.equal(-10);
    });

    it('Subtract should return number minus 10 for negative number input', () => {
        expect(mathEnforcer.subtractTen(-1)).to.be.equal(-11);
    });

    it('Subtract should return undefined for incorrect input', () => {
        expect(mathEnforcer.subtractTen('0')).to.be.undefined;
    });

    it('Subtract should return number minus 5 for decimal number input', () => {
        expect(mathEnforcer.subtractTen(0.5)).to.be.equal(-9.5);
    });

    it('Sum should return the sum of two numbers with correct input', () => {
        expect(mathEnforcer.sum(0,1)).to.be.equal(1);
    });

    it('Sum should return the sum of two numbers with correct input with negative numbers', () => {
        expect(mathEnforcer.sum(0, -1)).to.be.equal(-1);
    });

    it('Sum should return sum of decimal numbers', () => {
        expect(mathEnforcer.sum(0.5, 1.5)).to.be.equal(2);
    });

    it('Sum should return undefined with first invalid parameter', () => {
        expect(mathEnforcer.sum('0', -1)).to.be.undefined;
    });

    it('Sum should return undefined with second invalid parameter', () => {
        expect(mathEnforcer.sum(0, '-1')).to.be.undefined;
    });

    it('Sum should return undefined with both invalid parameter', () => {
        expect(mathEnforcer.sum('0', '-1')).to.be.undefined;
    });
});