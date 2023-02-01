const library = require('./library');
const {expect} = require('chai');

describe('Tests', () => {

    describe('CalcPriceOfBook', () => {
        it('Should works with valid book and year', () => {
            expect(library.calcPriceOfBook('Harry Potter', 1979)).to.equal(`Price of Harry Potter is 10.00`);
            expect(library.calcPriceOfBook('Harry Potter', 1980)).to.equal(`Price of Harry Potter is 10.00`);
            expect(library.calcPriceOfBook('Game Of Thrones', 1981)).to.equal(`Price of Game Of Thrones is 20.00`);
        });
    
        it('Should throw error with invalid name', () => {
            expect(() => library.calcPriceOfBook(12, 1979)).to.throw();
            expect(() => library.calcPriceOfBook(null, 1979)).to.throw();
            expect(() => library.calcPriceOfBook(1979)).to.throw();
            expect(() => library.calcPriceOfBook([],1979)).to.throw();
            expect(() => library.calcPriceOfBook([],undefined)).to.throw();
        });
    
        it('Should throw error with year', () => {
            expect(() => library.calcPriceOfBook('Harry Potter')).to.throw();
            expect(() => library.calcPriceOfBook('Harry Potter', 2000.5)).to.throw();
            expect(() => library.calcPriceOfBook('Harry Potter', 'a')).to.throw();
            expect(() => library.calcPriceOfBook('Harry Potter', [])).to.throw();
            expect(() => library.calcPriceOfBook('Harry Potter',null)).to.throw();
            expect(() => library.calcPriceOfBook('Harry Potter',undefined)).to.throw();
        });
    });
   
    describe('FindBook', () => {
        it('Should return true if desired book is available', () => {
            expect(library.findBook(["Troy", "Life Style", "Torronto"], 'Troy')).to.equal('We found the book you want.');
        });
        
        it('Should return false if desired book is missing', () => {
            expect(library.findBook(["Troy", "Life Style", "Torronto"], 'Harry Potter')).to.equal('The book you are looking for is not here!');
        });

        it('Should throw error if no books available', () => {
            expect(() => library.findBook([], 'Harry Potter')).to.throw();
        });
    });

    describe('ArrangeTheBooks', () =>{
        it('Should return true if all books aranged', () => {
            expect(library.arrangeTheBooks(1)).to.equal('Great job, the books are arranged.');
            expect(library.arrangeTheBooks(40)).to.equal('Great job, the books are arranged.');
            expect(library.arrangeTheBooks(0)).to.equal('Great job, the books are arranged.');
        });

        it('Should return false if not all books aranged', () => {
            expect(library.arrangeTheBooks(41)).to.equal('Insufficient space, more shelves need to be purchased.');           
        });

        it('Should throw error with invalid input', () => {
            expect(() => library.arrangeTheBooks(-1)).to.throw();  
            expect(() => library.arrangeTheBooks()).to.throw();      
            expect(() => library.arrangeTheBooks('a')).to.throw();   
            expect(() => library.arrangeTheBooks([])).to.throw();
            expect(() => library.arrangeTheBooks(null)).to.throw();
            expect(() => library.arrangeTheBooks(undefined)).to.throw();
        });
    });
});