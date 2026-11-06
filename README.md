# GED Bonus Assignment gitIgnore

# INFR 3110 Make Up Assignment
---
### Name : Christopher Evans
### Student Number : 100968759
---
# Object Oriented Programming
---
### Description
The 4 classes that exist are: GameManager, Snake,Food and Singleton. The singleton class is used to instantiate the GameManager class and keep it as a constant throughout the game. The GameManager inherits from the singleton which allows it to be created if it already doesn't exist and stay a constant throughout the game. The GameManager handles the respawning/restarting of the level. If the snake head hits a wall or itself, pressing R will return the snake back to its origin(0,0) and start it moving to the right. The Snake class handles segment growth and despawn, collision checks for food and obstacles (wall and segments), user input for movement, and snake head and segment movement. Finally the Food script is for the main food spawning. At the start of the level and when its collected by the snake, it'll teleport to a random location inside a specified range.
## UML Diagram
look in Build folder
---
# Singleton Pattern
---
### Purpose
Singleton is used for a game manager. The game manager handles restarting the game. This is done so that the game manager can be further expanded upon, keeping code related to objectives and simple restarts all in one place
### Implementation
Implemented by first creating a singleton script. This acts as a basis for the manager by checking if the manager already exists in the scene. if it does it doesn't make one, if not it creates the manager. Variables are private to encapsulate the singleton format stopping other scripts from messing with the process. A separate game manager script is then created, inheriting from the singleton script so that it isn't destroyed on load. Finally the game manager performs its functions when called upon.
---
# Factory Pattern
---
### Purpose
<!-- Explain why the Factory pattern is appropriate for this particular system. -->
### Implementation
<!-- Describe how the Factory pattern is implemented in your project. -->
---
# References
---
Singleton script was pulled from my In-Class project where I created the singleton for the in-class assignment
