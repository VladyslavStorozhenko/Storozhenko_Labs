Feature: EPAM testing

    Scenario:Go to About section
		Given user navigates to https://www.epam.com/
		And user maximize the window
		When the user clicks on "ABOUT" button
		Then https://www.epam.com/abou is opened

    Scenario: Go to Consult and Design section
		Given the user navigates to https://www.epam.com/
		When the user hovers over "OUR WORK"
		And the user clicks on "Financial Services"
		Then https://www.epam.com/our-work/financial-services is opened

    Scenario: Go to Financial Services section
		Given the user navigates to https://www.epam.com/
		When the user hovers over "SERVICES"
		And the user clicks on "Consult & Design"
		Then https://www.epam.com/services/consult-and-design is opened

    Scenario: Go to Newsroom section
		Given the user navigates to https://www.epam.com/
		When the user hovers over "ABOUT"
		And the user clicks on "NEWSROOM"
		Then https://www.epam.com/about/newsroom is opened

    Scenario: Go to EPAM without borders section
		Given the user navigates to https://www.epam.com/
		When the user hovers over "CAREERS"
		And the user clicks on "EPAM without borders"
		Then https://www.epam.com/careers/epam-without-borders is opened

    Scenario: Scroll down and go to privacy policy section
		Given the user navigates to https://www.epam.com/
		When the user scroll down to the end of page
		And the user clicks on "Privacy Policy"
		Then https://www.epam.com/cookie-policy is opened

    Scenario: Scroll down and go to cookie policy section
		Given the user navigates to https://www.epam.com/
		When the user scroll down to the end of page
		And the user clicks on "Cookie Policy"
		Then https://www.epam.com/cookie-policy is opened

    Scenario: Functionality of searching words option
		Given the user navigates to https://www.epam.com/
		And the user clicks on search
		When the user writes 'IASA' in seach bar
		Then results related to 'IASA' word are shown