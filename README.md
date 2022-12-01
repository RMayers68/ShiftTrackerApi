# ShiftTrackerApi
Function: API that connects to a SQL Server Database that holds worker shift information (ID, start and end times, pay, duration, and location).

Tested with Swagger and Postman

How Making It Went: This C# Academy tutorial threw me for a loop as I learned a lot of things about how APIs are created and function with a SQL database. 
I had no problem until the API tried to access the database and it stated I had no ConnectionString initialized. I had previously used App.config files and 
did not even know the existence of an appsettings.json file that my program was actually looking at. After I figured that out, it was smooth sailing though.
The testing with Postman was new and I had to research it a little but after I understood the process the testing was done quickly. This helped me when I went to 
create the UI program since I knew everything on the APIs side worked properly.
