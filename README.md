# Unity singleton pattern
## what is singleton pattern ?
Singleton is a design pattern that is used as a container which holds values that can be globally accessible across the whole project 
also they can transfer game data from scene to scene without the need to save and load data in the background.

the idea is some of object you only wants to exist once such as ambient audio.
## Advantages 
#### ( it basically global state but a little better than it)
+ Provide encapsulation
+ Connect parts of your game more easily
+ Call a  function on a singleton from any script in the game
+ Access the variable or function without you needing to set up a reference to it first
## Disadvantages
+ Can lead to that spaghetti cod situation
+ Break the - only do one thing - rule
+ Make difficult for extand project
+ It could be very bad for performance
### You should not have more than two singleton pattern object in your project. 
### for more information you can check this links :
https://gamedevbeginner.com/singletons-in-unity-the-right-way/
## How to implement and use
It usually done in language like c#  or even java or sometimes c++ like this :
```ruby
public class AudioPlayers {
  public static AudioPlayers instance

  public static AudioPlayers _instance()
      {
          if (instance == null)
          {
              instance = new AudioPlayers();
          }
          return instance;
      }
}
```
But on MonoBehaviour you can impelemint other ways.

You can check the AudioPlayers.cs file in project for see other ways too
also project have one simple example for this.

### way to go ..


