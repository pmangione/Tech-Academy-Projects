<b>This is an MCV web application I completed as project for my Tech Academy coursework.</b>

A notable accomplishment was the creation of a method that calculates a person's current age based on the current date.  I started with research on Google, but found many suggestions that were too complex because of the leap year.  My method is fairly simple and avoids conditional logic involving leap years.  <a href="https://github.com/pmangione/Tech-Academy-Projects/blob/master/CarQuotesMVC/CarQuotesMVC/Models/AgeFromBirthdayCalculator.cs">Here is a link to this method.</a>

<br>
<b>The initial requirements are listed below:</b> 
<br>
MVC PRACTICAL EXERCISE
You've been tasked with building an application for generating quotes for car insurance.

REQUIREMENTS
You must get the following information from the user:
First Name

Last Name

Email Address

Date of Birth

Car Year

Car Make

Car Model

If they have ever had a DUI.

How many speeding tickets they have.

Would they like full coverage or liability?

Use the following rules to calculate a quote:
Start with a base of $50 / month.

If the user is under 25, add $25 to the monthly total.

If the user is under 18, add $100 to the monthly total.

If the user is over 100, add $25 to the monthly total.

If the car's year is before 2000, add $25 to the monthly total.

If the car's year is after 2015, add $25 to the monthly total.

If the car's Make is a Porsche, add $25 to the price.

If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.

Add $10 to the monthly total for every speeding ticket the user has.

If the user has ever had a DUI, add 25% to the total.

If it's full coverage, add 50% to the total.

There must also be an Admin view for a site administrator. This page must:
Show all quotes issued, along with the user's first name, last name, and email address.
