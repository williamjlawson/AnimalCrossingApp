# AnimalCrossingApp
![.NET Core](https://github.com/williamjlawson/AnimalCrossingApp/workflows/.NET%20Core/badge.svg)
I'm a fan of the video game Animal Crossing for Nintendo Switch. The game has players move to an island after buying a deserted island getaway package from a businessman. Other characters (villagers) join the player. These villagers are based off of animals and are generally pretty cute and fun. 
This program allows users to input their birthday and see which villager shares their birthday. On a villager's birthday, they are thrown birthday party and the player can attend and celebrate with them. I thought it would be a cool idea to create a program where you can easily figure what villager's birthday as on each day, as well as which villager shares your birthday. 

The program works by taking an API call to an Animal Crossing API that contains the data of all the villagers that appear in the game (391 villagers). The program uses a more European style data format DAY/MONTH instead of the more American style MONTH/DAY, so keep that in mind when entering numbers. 

The project implements a master loop that takes the two numbers given by the user, and cycles through the list of villagers and finds a villager that has a birthday that matches the information given by the user 

The project uses a class (Villager) and a villager object (with data from the class) as part of how it parses user data to give the correct user back to the user. 
