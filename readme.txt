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