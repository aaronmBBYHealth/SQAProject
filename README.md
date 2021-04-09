# Quality Assurance Exercise

## Overview

Here at BBY Health, we prefer to have a good idea of a candidate's technical
experience and analysis skills before proceeding with portions of our recruiting
process.  We believe that the exercises below will illustrate a candidate's
approach to working with technologies and methodologies commonly used in our
QA team here at BBY Health.

## Guidelines

The exercise consists of several different parts designed to showcase your
problem-solving and solution-implementation talents. There is not a single
correct answer; this is *not* an exam. We simply want to see how you approach a
business problem and the steps you take to solve it.

* This exercise should not take you more than two hours to complete. If
  your solution is taking longer, that's okay—be honest and let us know how long
  it took and why you think it took that long.
* Be as thorough as you wish.
* All exercises are to be performed as if you were on the job.
* You may submit your response in one of the following ways:
  * Package an archive (ZIP, tarball, etc.) of your files and deliver it to
    your contact.
    * If working with a recruiter, deliver it to them.
  * Fork our repository and open a pull request.

## Exercise 1: Test plan

Below you will find two key inputs for this exercise:

* A screenshot of the greatcall.com new customer page, which a customer
  would use when purchasing a new device
* Some user stories and acceptance criteria for the new customer

These materials are representative of what you would be working with in our QA
team.

You may first see the acceptance criteria and a visual comp in a
grooming meeting. With the rest of the team, you would be responsible for making
sure the team collectively understands what work needs to be delivered.

In particular, as a member of our QA team, you would be responsible for
determining what testing is appropriate.

**Given these inputs, draft a test plan.**

* You may use any format and structure; whatever is familiar and representative
of your work style.
* Include some questions you'd ask if you were in the grooming meeting.
* Include any testing concerns the team should consider before taking on this work.
* Don't write a lot of test cases as part of this exercise. You may include particular test cases that stand out to you as important and non-obvious.

### Implementation screenshot

![new customer edit screenshot](new-customer-screenshot.PNG "New user screenshot")

### User story 1:

As a customer service representative, I want to track new customers so that I can provide greater customer experience and grow my client base.

#### Acceptance criteria:

* Add a section to billing address for phone number 
* The billing address section:
  * Phone Number
    * A customer phone number can be used by our customer representative
  * Tracking these new customers
    * A new customer could be called to confirm an order
* Only numeric characters will be accepted
* When a new customer billing address is added, a phone number verification will occur for a valid area code.
* Phone number will be required

### User story 2:

As a customer, I would like my address information previously entered available to be entered in my address, city, name, phone number, zipcode.

#### Acceptance criteria:

* A customer must be created with the following fields:
  * first name
  * last name
  * address
  * city
  * state
  * zipcode
  * phone number
  * email address
* A customer that does not contain required information will display an error message underneath the field
* A customer that has a country of United States of America will see a different field
  * A customer will have a zip code vs postal code
  * A customer will be able to select a “STATE” from a dropdown list
* A customer that has a country other than United States of America will see different fields
  * A customer will have a postal code vs zip code
  * A customer will need to type in a “STATE"
* A customer that has a country of Canada will see different fields
  * A customer will have a postal code vs zip code
  * A customer will be able to select a “STATE” from a dropdown list
* A customer may have a tag added to it consisting of at least two alphanumeric characters
  * A contact will only have tags saved if the contact is saved

### Additional user stories in this epic:

* As a customer service representative, I want to see the devices that my customer has purchased and if it has been delivered.
* As a customer service representative, I want to see the services that my customer is associated with to access them quickly for my business.
* As a customer service representative, I want to see the invoices that my customer is associated with to access them quickly for my business.
* As a customer service representative, I want to see recent activity associated with the customer to allow me to understand how they engage my services.

## Exercise 2: Test automation

You’ve been tasked with writing automated tests that check the behavior of the greatcall.com
ecommerce site home page. There’s a "Learn More" button on
<https://www.greatcall.com/> that you’ll need to click.

### Part 1: Locating the "Learn More" button

**Goal:** provide code or pseudocode to click the Lively flip "Learn More" button

Provide code for an automated test that clicks Lively flip "Learn More"
button on <https://www.greatcall.com>.  The code provided can be for an
automated test using the tool and language of your choice (Selenium, etc.).

A complete submission will:

* Locate the lively Flip "Learn More" button on the page
* Click the button
* Explain why you chose the language and framework that you did
* If the code and approach is not obvious, describe the approach and decisions
  made

In the event that you cannot provide working code, please provide a written
description of how you would locate and click this button.  Pseudocode is acceptable,
but working code is preferred.

### Part 2: Locating the support Learn More "Learn More" button

**Goal:** provide code or pseudocode to click the "Learn More" button that
appears at the bottom of the page

Similarly, provide code for an automated test that clicks the bottommost "Learn More" button on <https://www.greatcall.com/>.  As in the exercise above,
the code provided can be for an automated test using the took and language of
your choice (Selenium, etc.).

A complete submission will:

* Assert that a "Learn More" button exists at the bottom of the page
* Click the button
* Explain why you chose the language and framework that you did (if different
  from part one)
* If the code and approach is not obvious, describe the approach and decisions
  made

## (Optional) Exercise 3: API Testing

**Goal:** write API tests

Greatcall uses Swagger/Open API/Postman for API testing. Part of this work is writing
API tests. For this section we woudld like you to use (https://www.greatcall.com/stores/Api/Products). The concept should be familiar if you’ve written API tests.

1. Write a test that will verify the repsonse is under 200ms.
2. Write a test to verify status 200 is recieved.
3. Please add your recommended test here? 

A complete submission will:

* Include test that can be executed can be executed in Postman.

```
