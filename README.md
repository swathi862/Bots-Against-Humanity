# <p align="center"> <img src="https://github.com/swathi862/Bots-Against-Humanity/blob/master/Screenshots/black-text-logo.png" alt="BotsAgainstHumanity logo"> </p>

Bots Against Humanity is a card game application that closely resembles the game 'Cards Against Humanity', except that instead of human players, this app uses three automated players or little robots to submit answer cards in response to a randomly generated question card.

I designed this game to be a fun way to entertain yourself while maintaining the unique brand of humor when you can't visit your friends and have a game night together.

I created this app using C#/.NET and Entity Framework and styled the app using Bootstrap and custom CSS.


## How to Start the App

1. Either fork this repository to create your own local repository or clone it down to run it. 

1. In your terminal, make sure you are in the 'BotsAgainstHumanity' repository (check by making sure typing `ls` brings up a list of files that include `CardGame.sln`) and typing `start CardGame.sln`, which should open up the project in Microsoft Visual Studio.

3. Using the search bar, open up "Package Manager Console" and run `Add-Migration initialSetUp`. Then, run `Update-Database` in your Package Manager Console in order to add the CardGame database.

4. To start the application, select the green play button towards the top of the window labeled "II Express" or press CTRL + F5. This should open up the application in a new window or tab in Chrome.


## Login/Register

![alt text](https://github.com/swathi862/Bots-Against-Humanity/blob/master/Screenshots/LoginRegister.png "Login/Register page")

When the user starts the app, the first page they will see is the page above prompting the user to login/register using the links in the navigation bar.

+ If the user has already registered for an account and is returning to the app, they can select the login button, which will take them to a page where they will prompted for their username and password.

+ If they are a first time user, they should register for an account, which will direct them to a page prompting them to create an account by filling out various form fields.


## Home

![alt text](https://github.com/swathi862/Bots-Against-Humanity/blob/master/Screenshots/HomePage.PNG "Home page")

As a card game application, the navigation for this app is kept simplistic. 
+ After logging in, the user will be directed to the home page where they will be presented with the options _**Collect Points!**_- to go play a game- and _**Visit the Store!**_- to go to a store view to purchase a card deck.
+ The home page can be accessed at any point by selecting the "Bots Against Humanity" logo on the top left side of the page in the navigation bar. 
+ Also, in the navigation bar, there is a "Total Score: " component that refers to the user's overall score or the number of points that they have earned so far and a dropdown menu from "Hello, [username]" that contains links to helpful resources, especially the "Help" page, which included detailed instructions and answers to questions users might have.

#### Collect Points
In order to start playing the game, you have to click on the _**'Collect Points'**_ button on the home page.
+ After creating an account, a new user will be provided with a starter deck of cards with each card being worth 1 point each.
+ Users will be able to collect points after completing games and with enough points, they will be able to visit the store to purchase a new card deck with their points.

#### Visit the Store
_**'Visit the Store'**_ to purchase more card decks!
+ By purchasing more decks, a user will be able to add more diverse cards to their answer card collection that the automated players will be choosing from. 
+ Also, the more points a deck costs to purchase, the higher the point value of the 5 cards in the deck.

## How to Play
![alt text](https://github.com/swathi862/Bots-Against-Humanity/blob/master/Screenshots/PlayGame.png "Play Game page")

+ I have a game made up of 5 rounds, and in each round, 3 automated players will be submiting an answer card (white card), which is selected from the answer card selection the user has in their possession, in response to a randomly generated question card (black card). 
+ In order to play, the user must select the blue _**Vote!**_ button under one of the three answer cards submitted by the players in each round, and points earned per round will be dependent on the point value of the card selected.
+ In this application, some cards have different point values depending on what deck they are from and the value of the deck.

![alt text](https://github.com/swathi862/Bots-Against-Humanity/blob/master/Screenshots/EndGame.png "End Game page")

+ At the end of the game, the user will receive a notification letting them know of how many points they've earned and the game total will be added to their overall score, which can be seen in the navigation bar.

## How to Purchase Decks

![alt text](https://github.com/swathi862/Bots-Against-Humanity/blob/master/Screenshots/StoreView.png "Store View page")

+ When the user has enough points to purchase a deck, a blue button with _**"Purchase!"**_ will be displayed under each deck that the user has enough points to purchase. 
+ If there is no "Purchase!" button under a deck, the user does not have enough points to purchase that deck. 
+ After purchasing a deck, the deck will disappear from the store view because being able to re-purchase a deck would cause duplicate answer cards in the user's card collection, which may dampen the fun of the game.

The purchased deck will now be shuffled into the user's answer card collection that the automated players will be able to randomly select from while playing the card game.

# Other Notes
+ [Bootstrap](https://getbootstrap.com/docs/4.5/getting-started/introduction/)