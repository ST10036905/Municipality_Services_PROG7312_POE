***Mayra Selemane
***ST10036905
***Municipality services application
***Read-Me file
***15/10/2024

GitHub repository : https://github.com/ST10036905/Municipality_Services_PROG7321_POE

The following C# application is being designed to allow for citizens to report any issues related to their municipality/location. The main feature which is being implemented is the "Local events and announcements " which is a form extensively focused on input about a specific event or any announcement to be made for the community. The application also has as a focal point the provision of a user friendly interface to encourage for the active user engagement through the implementation of interactive features.

Code Structure
1 - Main Form: Contains the navigation menu and redirects to various functionalities.
2 - Report issues: Implements functionality for users to report an issue within the community.
3 - Add Event Form: Implements the functionality for adding and displaying local events.
4 - Event Data Class: Represents the structure of an event, including properties like name, category, description, time, media, and location.

Steps on how to run and compile the application :
1 - Opening the folder on visual studio - The user should first have visual studio installed. The following folder should be extracted and visual studio opened. Once you open visual studio, select open a project or solution from the start screen and proceed to opening the folder by navigating to the .sln fine, which is the solution file. 
2 - Building the project - Once the project is loaded, there is a menu on the top with the Build option which should be selected, as follows, Build > Build solution. With this process, visual studio will compile the application which means that if there are any errors or warning, they will be displayed and hints for their resolutions provided, as to ensure a smooth running process.
3 - Run the application - Once the project is successfully built, any warning and errors resolved, the user can then run the application by clicking on Debug > Start without debugging , which will run the application.
4 - Testing and making use of the application - The application is now launched and a main menu is displayed with the options :
a. Report Issues
b. Local Events
c. Announcements
d. Service request (to be implemented soon)
Optionally, there is a menu strip with the same options **File, Help, About** and an exit that will close the whole application.
 
## For "report issues" or "apply now" on the menu strip, they will be redirected to a municipality form to fill and report any issues. 
It is mandatory that all fields are filled, the location, category, description of the issues, except the media which is optional. Which then a personalized message is displayed based on the category and estimated resolution time (user engagement feature). If not filled, an error box will be displayed, prompting the user that all fields are populated. 
Once the user has entered the data, they can proceed to the submit button which will store the data on a list for future use. If the user then wishes to view issues, "view applications" button redirects to a form that shows all the issues that have been populated in a grid view. Back button is responsible to redirect user back to the initial page, but it is only achieved if the user confirms with a confirm box. 

## For Local events and announcements, that is the main feature of part 2 in municipality application, user will click on one of the two buttons(announcements/local events) and they will be redirected to the "Add Events" form where they can view existing events on the "Events User Control" or add an event/announcement.

## To add an event/announcement, all fields should be field in regards to the name of event, category, description, time, media and location. Once the events are entered, user clicks on SUBMIT and the data is held on the 'event List' which is then called and displayed below the page on a layout panel. A sorted dictionary sorts all the events based on date, from the earliest to latest. 

## Search - the feature is also implemented on the "Add Events". Data is filtered for user to search on a specific event based on the category they select or date and only the specific ones are displayed and captured from the list. 

## Should the user click on my recommendation button, a search engine is used to display the most-searched categories, providing personalized suggestions for the user. If the app finds events that match your top searched categories, they will be displayed in a message box notifying or displaying.

Additionally, user engagement feature of the progress bar was added to this form for an interactive use.

Now the project is successfully compiled and run as an application. 
***Further implementation - As a wholesome, the following were the features implemented in the following part of the application. Service request features are still to be implemented with additional functionalities. 


