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
    Given configure driver = { type: 'chrome', showDriverLog: true }
    And driver 'https://www.greatcall.com/'
    And waitFor("{^}The all-new flip phone")
    And maximize()
    #Below is delay just to view the page when it is running
    And delay(2000)
    And screenshot()
    # Couple of examples below on how elements can be identified
    #When submit().click("#Contentplaceholder1_C191_Col01 > div > div > a.btn.btn-primary.product-spotlight-btn.hidden-xxs.hidden-xs.hidden-md.hidden-lg.hidden-sticky")
    When submit().click("div[data-product-name='Lively Flip'] a[role='button']")
    Then waitForUrl('https://www.greatcall.com/phones/lively-flip-cell-phone-for-seniors')
    And screenshot()

  Scenario: Click on "Learn More" for lively flipGoal: provide code or pseudocode to click the "Learn More" button that appears at the bottom of the page
    Given driver 'https://www.greatcall.com/'
    And waitFor("{^}The all-new flip phone")
     # Couple of examples below on how elements can be identified
    #When submit().click("#Contentplaceholder1_C030_Col00 > a")
    * def elements = locateAll('{a}Learn More')
    * elements[karate.sizeOf(elements) - 1].click()
    # * delay(5000)
    Then waitForUrl('https://www.greatcall.com/support')



  Scenario: API Testing - get details of all products
    * url 'https://www.greatcall.com'
    Given path 'stores/Api/Products'
    When method get
    Then status 200
    And assert responseTime < 200