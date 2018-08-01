Using the ASP.NET MVC framework, modified existing features and built new functionality for the job application tracking section of a software bootcamp web application.  Specifically, this section tracks the job search process for students in the software bootcamp including where they have applied, how long they have been looking for a job, and which companies they have applied to. 

PROJECT HIGHLITES 

BACK END

In the Models folder, I added a calculated property to three separate classes to determine if the class was instantiated within the past week. This was done to track if the following had occurred in the past 7 days: 1) A student had enrolled in the job placement service.   2) A student had applied for a specific job.  3) A student had been hired for a specific job. This property was not mapped to the database to avoid the performance cost of making unnecessary future calls to the database.    
<a href="https://github.com/pmangione/Tech-Academy-Projects/blob/master/LiveProject/ScreenShotExamples/AddCalculatedPropertyToJobApplicationClass.PNG">SCREEN SHOT EXAMPLE OF CALCULATED PROPERTY</a> 

Because these three classes used the same logic to for the calculated property, I created a helper method to perform the date calculation.
SCREEN SHOT OF HELPER METHOD
