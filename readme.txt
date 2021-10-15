Name: Aarsal Masoodi - 0688474
First Created: October 13th, 2021

Last Modified October 15th, 2021


Created the project as an MVC Web Application. Check marked individual authentication and the usage of HTTPS.
My theme for the project is "Candles". Will start following the example tutorial to build the core of the project as I make my changes.

Created a git respositary linked to my school github account. The repositary is currently on "private".

Using Tutorial As Base
----------------------
As I build the project, I'm following the tutorial. I've added the "HelloWorldController" to the controllers folder.
Added the default code for the controller to have an index method.
Changed the index method in the controller to use the "View" method to generate an HTML output. Used a controller method, which are known as action methods.
Added the Index.cshtml view file in a new folder called HelloWorld.
This view I added will work as the default view for when the view method is called, as it's the Index. I added some text to this view file.
In the layout template I changed the title to "Flickr: Candles for Sale". Flickr is the name of my fictional company.
I added a new view file called Welcome. I also updated the HelloWorld controller to use the ViewData dictionary
Now moving on the the classes, or models.
I created the Candles.cs class in the "Models" folder. The class has 5 properties for candles as well as a rating property. 
I installed the EF Core package through NuGet Packages using the command "Install-Package Microsoft.EntityFrameworkCore.Design"
Now I need to scaffold to create the CRUD (Create, Read, Update and Delete) pages. 
I added a scaffold to the controllers folder. By doing so it created the CandlesController as well as the CRUD for the database. 
I still need to create the database. I use the Migrations feature in EF Core to do this.
I'm having trouble with the migration step. Getting this error:
	"More than one DbContext was found. Specify which one to use. Use the '-Context' parameter for PowerShell commands and the '--context' parameter for dotnet commands."

	Okay, was able to fix it. Instead if just running Add-Migration, I had to add a "-Context Candles_DatabaseContext" afterwords too. 
I tested the CRUD functionality. It works well.

Was having trouble adding a new about page. I added the view in the "Home" folder, and I set up the link in layout. But it wasn't working.
	Had to go and add the View method in the HomeController.cs file. 
I also added a link to the candle database on the navigation bar.

I created a new class called SeedData, and I have added just seed items for various candles so far. I will add the remaining 6 later.
I edited the program.cs file so that it seeds the database. To do so I also had to add the "using" command for the various directories in the project.
I tested the project and the seeded files worked.
I cleaned up some of the database headings so it looks better to read.
Added the ability to search through the database through the candle name.
Added a new class in the models folder to allow the ability to search the candles by type.

deleted the Hello World files and folders added for the tutorial. 
After adding the code to allow search by genre, I've hit an error:
"InvalidOperationException: The model item passed into the ViewDataDictionary is of type 'System.Collections.Generic.List`1[Candles_Database.Models.Candles]', but this ViewDataDictionary instance requires a model item of type 'Candles_Database.Models.CandleTypeViewModel'."
Troubleshooting now.
Okay, fixed it. I had an error on my return View in the CandlesController.cs file.

Now I need to add a user rating category. So instead of adding a new field, I'm editing the previous "rating" field I had to become a user rating instead. 
Updated the "About Us" page with all the relevent data, as well as putting the fields in respective divs. 
Now going to finish up the tutorial aspect with Validation, and will then focus on customizing the page.
I've added validation elements to the file, such as limiting the user rating to between 1 and 5. I also changed it from decimal, to int.
	changing it from decimal to int lead to a database error. I've changed it back to decimal for now. 

Added six more seed items to the database, making a total of 10. The application is now fully functional and needs to be visually changed.
Added text to the home page. Removed the "Home" from the navigation, as users can click on the website title instead. 

Customization
--------------
Created a small logo for my company, Flickr, on photoshop.
I'm having trouble adding pictures to the project. I have them in a seperate directory, but even though I navigate there correctly they're not loading in.
	to fix this I moved the images folder to the wwwroot directory.
I added images to the home page, the about page, and the catalogue page. The images are either too large or too small, and need to be resized. I will do so in the CSS file.
I'm having trouble manipulating the images through the css file.
	turns out I wasn't refreshing properly. ctrl+f5 and I can see the changes come into play. 
I changed the css of the page. I added a blue background, reduced the size of the container, added the logo, and changed the image sizes.
The page looks much better than the default. 
The project is almost complete for submission, just need to comment my CSS, upload to azure and create the external readme. 

Finished commenting the CSS. 
Created an external readme that has a brief description of the program.
Did a final test of the page, all the links are working.

Published the web app to Azure. 
Committed the final update to github.

Thank You,
Aarsal Masoodi
0688474
