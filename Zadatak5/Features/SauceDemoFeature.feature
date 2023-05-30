Feature: SauceDemoFeature

In order to test SauceDemo application
As a developer
I want to validate different operations of the application

@tag1
Scenario: [LogInScreen Is Displayed When App is started]
	Given [I have stable internet connection]
	When [I enter the page saucedemo.com]
	Then [It should open the page with LogInScreen]

Scenario: [LogInScreen shall have empty textbox "Korisnicko ime"]
	Given [I have stable internet connection]
	When  [I entered the page saucedemo.com]
	Then  [Textbox "Korisnicko ime" should be visible and empty]

Scenario: [Click on button "Prijava" opens error message when both of textboxes are empty]
	Given [I entered the page saucedemo.com]
	When  [I clicked on button "Prijava" while both textboxes were empty]
	Then  [It shows error message "Korisnicko ime je obvezno. Lozinka je obvezna."]
	