Feature: GreatCall UI and API Test Automation Demo

  Background:
  #  * configure driver = { type: 'chrome', showDriverLog: true }
  # * configure driverTarget = { docker: 'justinribeiro/chrome-headless', showDriverLog: true }
  # * configure driverTarget = { docker: 'ptrthomas/karate-chrome', showDriverLog: true }
  # * configure driver = { type: 'chromedriver', showDriverLog: true }
  # * configure driver = { type: 'geckodriver', showDriverLog: true }
  # * configure driver = { type: 'safaridriver', showDriverLog: true }
  # * configure driver = { type: 'iedriver', showDriverLog: true, httpConfig: { readTimeout: 120000 } }
  #  * url 'https://www.greatcall.com'

  Scenario: Goal: provide code or pseudocode to click the Lively flip "Learn More" button
    * configure driver = { type: 'chrome', showDriverLog: true }
    Given driver 'https://www.greatcall.com/'
    And waitFor("{^}The all-new flip phone")
    When submit().click("#Contentplaceholder1_C191_Col01 > div > div > a.btn.btn-primary.product-spotlight-btn.hidden-xxs.hidden-xs.hidden-md.hidden-lg.hidden-sticky")
    Then waitForUrl('https://www.greatcall.com/phones/lively-flip-cell-phone-for-seniors')

  Scenario: Click on "Learn More" for lively flipGoal: provide code or pseudocode to click the "Learn More" button that appears at the bottom of the page
    Given driver 'https://www.greatcall.com/'
    And waitFor("{^}The all-new flip phone")
    When submit().click("#Contentplaceholder1_C030_Col00 > a")
    # * delay(5000)
    Then waitForUrl('https://www.greatcall.com/support')



  Scenario: API Testing - get details of all products
    * url 'https://www.greatcall.com'
    Given path 'stores/Api/Products'
    When method get
    Then status 200
    And assert responseTime < 200