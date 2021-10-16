const {expect} = require('chai');
const rgbToHexColor = require('./rgbToHex');

describe('Tests', () => {

    it('Should return undefined for invalid red color input', () => {
        expect(rgbToHexColor(256,0,0)).to.be.undefined;
    });

    it('Should return undefined for invalid blue color input', () => {
        expect(rgbToHexColor(0,-1,255)).to.be.undefined;
    });

    it('Should return undefined for invalid green color input', () => {
        expect(rgbToHexColor(-5,255,0)).to.be.undefined;
    });

    it('Should return undefined with invalid first parameter', () => {
        expect(rgbToHexColor('invalid',255,254)).to.be.undefined;
    });

    it('Should return undefined with invalid second parameter', () => {
        expect(rgbToHexColor(0,'invalid',254)).to.be.undefined;
    });

    it('Should return undefined with invalid third parameter', () => {
        expect(rgbToHexColor(0,255,'invalid')).to.be.undefined;
    });
    
    it('Should return red as string for valid red color input', () => {
        expect(rgbToHexColor(255,0,0)).to.be.equal('#FF0000');
    });

    it('Should return blue as string for valid blue color input', () => {
        expect(rgbToHexColor(0,0,255)).to.be.equal('#0000FF');
    });

    it('Should return green as string for valid green color input', () => {
        expect(rgbToHexColor(0,255,0)).to.be.equal('#00FF00');
    });
});