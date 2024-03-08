<a href='https://postimages.org/' target='_blank'><img src='https://i.postimg.cc/V6CkbLbm/Logo-Nav-Bar.png' border='0' alt='Logo-Nav-Bar'/></a>

# BiteMap

BiteMap is an application that allows the user to search for restaurants, cafes, bars, and other establishments located near him.
The application was created for the needs of personal development and during its development, the skills of backend programming in .NET technologies and frontend programming in React were improved.

When the user starts the application, the system, based on his current location, gives him a view of all establishments located near him. 
By choosing one of them, the system gives him detailed information about the establishment itself and guides him to it by the shortest route.

In addition, the user is given the option of booking a place in a restaurant through the application itself

# Backend
The backend part of the application was created using .NET framework. PostgreSQL database is used for data storage.

Regarding security, the application uses the authorization, authentication and JWT service and generates a token for each logged-in user. The token is later used to display and enable the corresponding functionalities. 

In addition to users, for whom BiteMap is primarily intended, there are also System Administrator and Establishment manager roles. Each of these roles has an adequately adapted interface and available functionalities.

# Frontend
The frontend part of the application was developed using the React. During development, I team made sure that the design was consistent on every page. The style of the application is predefined and maintained throughout the development. A predefined color palette was also used, as well as the size and positioning of text and components on the pages.

The Leaflet library was used to display the establishment on the map and to display a path when an establishment is selected.

Overall, the goal for the design of this application is to be minimalistic and adapted to each type of user, while at the same time being modern. It is necessary to provide each type of user with all possible information and all possible functionalities without cluttering the pages with content that will only divert his attention from why he is there

# Functionality

### Login and Register

As with any other platform or application, in order to use the services that BiteMap offers, you must have an account. 

Logging in to the platform is done through the login form, which also offers options for logging in via Google or Twitter profiles, while a simple user-friendly registration form is provided for those who do not have an account on BiteMap.
During registration, it is necessary to confirm and activate the profile via the activation link sent to the email entered by the user in the registration form.

A new user who has just registered, after activating the profile, is assigned the role of *AUTHENTICATED USER*, and in accordance with that role, he is shown the appropriate links and is enabled to perform the appropriate activities on the application.

Each user logs in using their username, which must be unique, and a password that is hashed to maintain the security of the account.

<a href='https://postimg.cc/r0jLJrcY' target='_blank'><img src='https://i.postimg.cc/MH2Kz7Lx/Login.png' border='0' alt='Login'/></a>
<a href='https://postimg.cc/QVNDM0JL' target='_blank'><img src='https://i.postimg.cc/CMkxm2ZK/Register.png' border='0' alt='Register'/></a>

### Visit establishment

After searching for establishments, the user has the opportunity to view the profile of the establishment he likes the most. 

The establishment page shows basic information related to the establishment itself, a map with the exact location where the establishment is located and few different sections with different informations.

<a href='https://postimg.cc/WDsW7f3T' target='_blank'><img src='https://i.postimg.cc/DzX9n93J/Visit-Establishment.png' border='0' alt='Visit-Establishment'/></a>

#### 1. Home section

On the home section, the user is shown the most basic information related to the establishment itself. He was given the overall rating of the establishment by different sections, a description of the establishment as well as the exact location of the establishment on the map.

<a href='https://postimg.cc/Z903Zrs6' target='_blank'><img src='https://i.postimg.cc/g0HKVsvt/Home-Section.png' border='0' alt='Home-Section'/></a>

# Author
* <a href="https://github.com/Nemkac">Nemanja Todorović
