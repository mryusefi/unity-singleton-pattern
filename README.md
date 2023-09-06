# Unity singleton pattern
## what is singleton pattern ?
Singleton is a design pattern that is used as a container which holds values that can be globally accessible across the whole project 
also they can transfer game data from scene to scene without the need to save and load data in the background.

the idea is some of object you only wants to exist once such as ambient audio
## Advantages 
#### ( it basically global state but a little better than it)
+ Provide encapsulation
+ Connect parts of your game more easily.
+ Call a  function on a singleton from any script in the game.
+ Access the variable or function without you needing to set up a reference to it first.
## Disadvantages
+ Can lead to that spaghetti cod situation
+ Break the - only do one thing - rule
+ Make difficult for extand project
+ It could be very bad for performance
### You should not have more than two singleton pattern object in your project 
### for more information you can check this links 
https://gamedevbeginner.com/singletons-in-unity-the-right-way/
## How to implement and use
in project you can check the .cs file for how to implement 

