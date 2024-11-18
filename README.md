## Author : Mayra Selemane
## Student : ST10036905
## Project : Municipality services application
## Course : PROG7312
## Read-Me file
## 18/11/2024

GitHub repository : https://github.com/ST10036905/Municipality_Services_PROG7312_POE.git

The following C# application is being designed to allow for citizens to report any issues , view local events and track the status of any related service request in their municipality/location. The main feature which is being implemented is the final part of the POE is the "Service requests status " where users can view, search, and filter service requests by request ID, category, status, and submission date. This feature leverages efficient data structures and algorithms to ensure quick and responsive searches, making it an essential part of the application.

Code Structure
1 - Main Form: Contains the navigation menu and redirects to various functionalities.
2 - Report issues: Implements functionality for users to report an issue within the community.
3 - Local events and announcements Form: Implements the functionality for displaying local events and announcements.
4 - Service request status: Allows for users to track on a specific service request that is made available in the community application.
5 - Dashboard - To get the user started with the application.

Pre-requisites : 
Before compiling and running the program, ensure the following are installed on your machine:
## .NET Framework (if using C#/.NET environment)
## Visual Studio or any other IDE that supports C# development
## Windows OS (For running the application locally on your machine)

Clone the GitHub Repository:
To clone the repository, open a terminal (Command Prompt, PowerShell, or Git Bash), navigate to the directory where you want to store the project, and run the following command:

git clone https://github.com/ST10036905/Municipality_Services_PROG7312_POE.git

This command will download the entire project to your local machine.

## Steps on how to run and compile the application :
1 - Opening the folder on visual studio - The user should first have visual studio installed. The following folder should be extracted and visual studio opened. Once you open visual studio, select open a project or solution from the start screen and proceed to opening the folder by navigating to the .sln fine, which is the solution file. 
2 - Building the project - Once the project is loaded, there is a menu on the top with the Build option which should be selected, as follows, Build > Build solution. With this process, visual studio will compile the application which means that if there are any errors or warning, they will be displayed and hints for their resolutions provided, as to ensure a smooth running process.
3 - Run the application - Once the project is successfully built, any warning and errors resolved, the user can then run the application by clicking on Debug > Start without debugging , which will run the application.
4 - Testing and making use of the application - The application is now launched and a main menu is displayed with the options :
a. Dashboard
b. Report issues
c. Local events and announcements
d. Service requests
e. Exit

Optionally, there is a menu strip with the same options **File, Help, About** and an exit that will close the whole application.
 
## For "report issues" or "report an issue" on the menu strip, they will be redirected to a municipality form to fill and report any issues. 
It is mandatory that all fields are filled, the location, category, description of the issues, except the media which is optional. Which then a personalized message is displayed based on the category and estimated resolution time (user engagement feature). If not filled, an error box will be displayed, prompting the user that all fields are populated. 
Once the user has entered the data, they can proceed to the submit button which will store the data on a list for future use. Back button is responsible to redirect user back to the initial page, but it is only achieved if the user confirms with a confirm box. 

## For Local events and announcements, that is the main feature of part 2 in municipality application, user will click on one of the local events and announcements and they will be redirected to the "AddEventForm" form where they can view existing events on the "Events User Control".
 - Search - the feature is also implemented on the "Add Events". Data is filtered for user to search on a specific event based on the category they select or date and only the specific ones are displayed and captured from the list. 
- Should the user click on my recommendation button, a search engine is used to display the most-searched categories , depends on CATEGORY SEARCH, providing personalized suggestions for the user. If the app finds events that match your top searched categories, they will be displayed in a message box notifying or displaying.
- Reset is responsible for clearing the search engines from the stack and clearing any filters.

## For service request status - using the service request status allows for specific issues and their statuses to be displayed in the application. Additional features were implemented using binary search trees and trees to allow for the user to perform searches in the application, namely :
Request ID: Enter a specific request ID to search for a particular service request.
Category: Use the dropdown to filter by service category (e.g., Sanitation, Utilities).
Status: Filter service requests by their current status (e.g., Pending, In Progress).
Start Date / End Date: Set a date range to filter requests by their submission date.
The results will be displayed in a grid, showing each service request’s ID, category, status, and submission date.

Data Structures & Efficiency
1. Binary Search Tree (BST)
The Binary Search Tree (BST) is was used for storing service requests in sorted order. This ensures that search operations (such as filtering by request ID or submission date) are fast and efficient. The time complexity for searching in a BST is much quicker compared to other methods.

2. LINQ (Language Integrated Query)
LINQ is used to filter and query the data stored in the BST. With LINQ, complex queries can be written in a concise, readable manner. The filtering operations, such as filtering by category, status, or date, are all executed using LINQ queries.

3. BindingList<T>
The BindingList<T> is used to bind filtered data to the UI controls (e.g., DataGridView). This ensures that any updates to the underlying data are automatically reflected in the UI, providing an interactive and responsive user experience.

Thank you for using the Municipality Services Application!
Feel free to explore, report any issues, and contribute to making your community a better place!


