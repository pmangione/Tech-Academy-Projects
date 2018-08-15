Using the ASP.NET MVC framework, I modified existing features and built new functionality for the job application tracking section of a software bootcamp web application.  Specifically, this section tracks the job search process for students in the software bootcamp including where they have applied, how long they have been looking for a job, and which companies they have applied to. 

PROJECT HIGHLITES 

<B>BACK END</B>

In the Models folder, I added a calculated property to three separate classes to determine if the class was instantiated within the past week. This was done to track if the following had occurred in the past 7 days: 1) A student had enrolled in the job placement service.   2) A student had applied for a specific job.  3) A student had been hired for a specific job. This property was not mapped to the database to avoid the performance cost of making unnecessary future calls to the database.   
<a href="https://github.com/pmangione/Tech-Academy-Projects/blob/master/LiveProject/CodeSnippets/AddCalulatedPropertyToJobApplicationClass.cs">CODE SNIPPET OF CALCULATED PROPERTY</a> 
<BR><a href="https://github.com/pmangione/Tech-Academy-Projects/blob/master/LiveProject/Code/JPApplication.cs">ENTIRE FILE OF CALCULATED PROPERTY</a> 
<BR><BR>
Because these three above mentioned classes used the same logic to for the calculated property, I created a helper method to perform the date calculation.<BR>
<a href="https://github.com/pmangione/Tech-Academy-Projects/blob/master/LiveProject/CodeSnippets/HelperMethodCalculateIfObjectInstantiatedWithinPastWeek.cs">CODE SNIPPET OF HELPER METHOD FOR CALCULATED PROPERTY</a>
<BR>
<a href="https://github.com/pmangione/Tech-Academy-Projects/blob/master/LiveProject/Code/Helpers.cs">ENTIRE FILE OF HELPER METHOD FOR CALCULATED PROPERTY</a>
<BR>
<BR>
In the Controllers folder, I added filtering functionality for searching the job application details for each student.  This includes searching by a student’s name or a student’s location which required the use of LINQ  WHERE clauses.  In addition, a regular expression was also required for the location search because the locations were stored as Enumeration properties.  Enumeration values do not store spaces between words, but users are likely to add spaces in a location has more than one word.<BR> <a href="https://github.com/pmangione/Tech-Academy-Projects/blob/master/LiveProject/CodeSnippets/ControllerLogicToSearchByStudentNameOrLocation.cs">CODE SNIPPET OF SEARCHING FUNCTIONALITY</a>
<BR>
 <a href="https://github.com/pmangione/Tech-Academy-Projects/blob/master/LiveProject/Code/JPStudentRundownController.cs">ENTIRE FILE OF SEARCHING FUNCTIONALITY</a>
<bR><bR><BR>


<B>FRONT END</B><BR><BR>
In the Views folder, I added a search textbox to the page which lists the job application details for each student.  The search box allows the user to search by student name or student location.   HTMLHelpers and model binding were used to pass the search information to the controller.  Details on the controller functionality are listed in the back end section.<BR> <a href="https://github.com/pmangione/Tech-Academy-Projects/blob/master/LiveProject/CodeSnippets/AddSearchBarForStudentJobApplicationDetails.cs">CODE SNIPPET OF SEARCH BAR</a>
<BR>
 <a href="https://github.com/pmangione/Tech-Academy-Projects/blob/master/LiveProject/Code/IndexJPStudentRundown.cshtml">ENTIRE FILE WITH SEARCH BAR</a>
<bR><bR>        

In the ViewModels folder, I created a class designed to display job application details for each student.  For the sake of code readability, I use “this” when assigning the class properties in the constructor.<BR>  <a href="https://github.com/pmangione/Tech-Academy-Projects/blob/master/LiveProject/CodeSnippets/CreateViewModelForStudentJobApplicationDetails.cs">CODE SNIPPET OF VIEW MODEL CLASS</a> <BR>
<a href="https://github.com/pmangione/Tech-Academy-Projects/blob/master/LiveProject/Code/JPStudentRundown.cs">ENTIRE FILE OF VIEW MODEL CLASS</a>

<bR>        

In Views folder for the home student listing page, I built a method which allows the current location of a bootcamp student to display on the website with spaces between separate words. This method is necessary because the current location is an Enumeration property with values that are stored with no spaces.<BR>  <a href="https://github.com/pmangione/Tech-Academy-Projects/blob/master/LiveProject/CodeSnippets/DisplayEnumLocationValueWithSpaces.cs">CODE SNIPPET OF METHOD TO DISPLAY LOCATION WITH SPACES</a> <BR>
<a href="https://github.com/pmangione/Tech-Academy-Projects/blob/master/LiveProject/Code/Index.cshtml">ENTIRE FILE WITH METHOD TO DISPLAY LOCATION WITH SPACES</a>
<bR><bR><br>        
 
<B><a id="Database">DATABASE</B></a> <BR><BR>
In the Models folder, I added a DateTime property called HiredDate to the class which tracked the hiring information for each student.<BR>  <a href="https://github.com/pmangione/Tech-Academy-Projects/blob/master/LiveProject/CodeSnippets/AddHireDateToStudentJobHiredRecords.cs">CODE SNIPPET OF ADDED DATETIME PROPERTY</a>  
<a href="https://github.com/pmangione/Tech-Academy-Projects/blob/master/LiveProject/Code/JPHire.cs">ENTIRE FILE WITH ADDED DATETIME PROPERTY</a> 
<br><br>
Because this application uses the Code First Entity Framework, the above mentioned change to this class also involved a change to the database structure.  Therefore, I also ran a database migration using an updated configuration file in which I added test hire dates.<BR>  <a href="https://github.com/pmangione/Tech-Academy-Projects/blob/master/LiveProject/CodeSnippets/AddDateTimeTestDataForDatabaseMigration.cs">CODE SNIPPET OF ADDED TEST DATA FOR DATETIME PROPERTY</a>
    
