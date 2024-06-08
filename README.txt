2024-05-15
Anjan Panta
1333 EDT

1340
Added a controller named HelloWorldController.cs from Contollers>Add>New File
Finish Time 1350

1351
Created a simple C# method that returns "This is my default action..."
in /HelloWorld/

1430
Added two parameters in /HelloWorld/Welcome/ as $"Hello {name},
NumTimes is: {numTimes}" and its works.
Finish time 1432

1432
Made sure the localhost runs and it runs.

1433
Added new file in Views>Add>newfile as Index.cshtml
and the localhost is not displaying the intended page.
And it finally worked after I corrected an error in index.cshtml file

1440
Took a break

1445
Again, I made it sure the localhost runs on Google Chrome and Firefox.

1455
Changed the MvcMovie to MovieApp form Views/Shared/_Layout.cshtml.
And it showed MvcMovie to MovieApp

1510
Examined the Views/_ViewStart.cshtml file.

1512
Changed to "Movie List" and "My Movie List" in Index.cshtml in Views/HelloWorld
and saved it.

End Time: 1515

Time taken 3 hours
===================================================

2024-05-23
Anjan Panta
1334 EDT

Start Time 1340
In HelloWorldController.cs, I changed the Welcome method to add a Message and
NumTimes value to the ViewData which is used to generally generate a greeting
messafe for the specified name.
Tested... all good.
End Time 1345


Start time 1347
Tested again.. to make it sure if it works perfectly.
End time 1348

Start time 1348
Took a break for 10 minutes...
End time 1358

Moving to the part 4...

Start time 1358
Added> New Class> Empty Class in Models folder.
End time 0200

Start time 1400
The `Movie` class here I added, includes nullable string properties (`Title`, `Genre`), a
`ReleaseDate` with `DataType.Date`, and a `Price` of type decimal for better
precision in representing monetary values.
End time 1410

Took a break...

Start time 1420
There was an error downloading the package due to old .net version
and it supported 7.0.2 version.After troubleshooting, successfully installed
Microsoft.EntityFrameworkCore.SQLite package, Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Design.
End time 1428

Start time 1440
Opened the CLI terminal and entered the command and ran into the issue.

Time taken: 3 hours

==========================================================================

2024-05-30
Anjan Panta
1334 EDT

1330 -Updated the Index method found inside Controllers/MovieController.cs with the
code.

1335 - https://localhost:7031/Movies/Index?searchString=C, Confirmed if the movies could be searched using the string.
And it works perfectly fine....

1337 - https://localhost:7031/Movies/index/one. After updating the index method with id, I confirmed that I can now pass the
search title as route data instead of as a query string value.

1340 - To filter the 'movies' based on the 'searchString' and returning the filtered results asynchronously
in the 'Index' action method.

1345 - In Views/Movies/Index.chtml file added the <form> which allows users to input a string and submit
it to the 'Index' action of the 'Movies' controller. This triggers the filtering
logic in the 'Index' method to display only movies that match the search criteria.

1356 - Successfully run the project and I can see the Title, Movie Search box and filter button.
I entered a Movie name thats in the db, and it succesfully displayed it.

1359 - Added Httppost index method to the MovieController.cs file and tested the method in the web
browser.

1403 - Added HTTP GET in Views/Movies/Index.cshtml file which would fix capturing the search i
information to the bookmark to share with others.

1407 - Created new MovieGenreViewModel class to the Models folder which contains list of mocies,
SelectList, MovieGenre, SearchString.

1415 - Replaced the Index method in MovieController.cs with the code.
Then tested the code running the web application...
and it works.....

1420 - Took a break....

1429 -Added search by genre feature to the index view to update Index.cshtml file found in
Views.Movies/. The form adds a dropdown by filtering movies by genre and a textbox filtering
by title, enabling combined filtering when submitting the form to the 'Index' action.

1435 - Tested the app by searching by genrem by movie title, and by both in web browser..
and It works........

1436 - Added rating property in the movie mode and editing Models/movie.cs
Also, added Rating property in MovieController.cs. Edited Index.cshtml and added the new rating field.

1440 - Updated the Seed data class with Rating = "R" in each movie details so that the change can be seen.

1445 - When running the App, Movies URL wont work as it showed: SqlException: Invalid column name 'Rating'.
This error occourred because the updated Movie model class is different than the schema of the Movie table of the
existing database table.

1446 - To solve the issue, Tools>NuGet Package Manage> package manager console> added one command at time
Added - Migration Rating
Then, Update-Database
Finally Launced the app in the brower, Yes! it works and now I can create, edit, and display the Rating field.

1448 - Added the validation rules to the movie model with attributes Required, StringLength, RegularExpression, Range and
DataType.

1455 - Checked the Validation Error UI is correct or not,
And the good news is, as the requirement is not fulfilled of the input data, it displays the error message.

Time: 2 hours



