//Cypress code 

const BASE_URL = Cypress.env('BASE_URL')

describe('BestBuy', function(){
      it('lively Flip - Learn More',function(){
        cy.visit(BASE_URL);
        cy.wait(2000);
        cy.get('#Contentplaceholder1_C191_Col01 > .product-spotlight > div.gtm-product-impression > .btn-lg').click();
		cy.wait(2000);
    })  

    it('Learn More - Learn More',function(){
        cy.visit(BASE_URL);
        cy.wait(2000);
        cy.get('#Contentplaceholder1_C030_Col00 > .btn').click();
        cy.wait(2000);
    })  
})
