const {expect} = require('chai');
const lookupChar = require('./charLookup');

describe('Tests', () => {

    it('Should return char with correct parameters and correct index', () => {
        expect(lookupChar('str', 0)).to.be.equal('s');
        expect(lookupChar('str', 2)).to.be.equal('r');
    });
    
    it('Should return undefined with wrong first parameter', () => {
        expect(lookupChar(0, 0)).to.be.undefined;
    });

    it('Should return undefined with wrong second parameter', () => {
        expect(lookupChar('str', '0')).to.be.undefined;
    });

    it('Should return undefined with wrong first and second parameters', () => {
        expect(lookupChar(0, '0')).to.be.undefined;
    });

    it('Should return incorrect index error with correct parameter types but incorrect index', () => {
        expect(lookupChar('str', -1)).to.be.equal('Incorrect index');
        expect(lookupChar('str', 3)).to.be.equal('Incorrect index');
    });

    it('Should return undefined with decimal index', () => {
        expect(lookupChar('str', 1.5)).to.be.undefined;
        expect(lookupChar('str', '-1.5')).to.be.undefined;
    });

    it('Should return undefined with missing parameters', () => {
        expect(lookupChar('str')).to.be.undefined;
        expect(lookupChar(-1.5)).to.be.undefined;   
        expect(lookupChar()).to.be.undefined;
    });
})