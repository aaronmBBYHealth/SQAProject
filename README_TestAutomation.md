# Test Plan
Test Plan is located in the src/test/resources folder

# Postman
Postman collection and results are in the src/test/resources folder

# Test Automation 
I am using Open Source Framework called Karate (https://github.com/intuit/karate) for the following reasons:
* One framework for both UI and API Automation
* Easy to get started without any programming knowledge
* Uses BDD syntax and does not require coding to write step definitions
* Gherkin syntax makes it easy for Dev, QA and Business reiew test scenarios

# Execution Steps:
* Move to the directory where project is located, eg: cd %userprofile%/\IdeaProjects\SQAProject
* Command to execute automated tests : mvn clean test "-Dkarate.options=--tags ~@ignore"
* Command to open html report: start chrome .\target\surefire-reports\karate-summary.html

```
