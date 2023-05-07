# DODGEBALL-LEGEND-

## Student:
Muhammad Sarahni - 207662958

## The project Directed by - **Dr. Roi poranne**
## Working Progress:

## Week 1:
I have discussed the game idea and decided whether to proceed with it. I am now waiting for approval to begin working on the pitch, which is a description of the game. I have also created a repository for the project and made a private channel on Slack for us to collaborate on..

## Week 2:
1.	I downloaded and installed Unity on my computer, and then learned the basics of Unity by watching tutorials and YouTube videos.  
2.	I created a battlefield map in Unity, using a terrain for the ground and adding obstacles and walls using boxes.

3.	I created a player object using a Capsule and added a camera to it for a first-person shooter (FPS) game. Then, I controlled the player's movement using the Unity input system. To implement the dash feature, I increased the movement speed using 'controller.Move(moveInput * Time.deltaTime);'. For crouching, I adjusted the player's speed and height in the same way.

4.	I created an enemy object by using a Capsule and created a new tag 'Enemy' and applied it to the object. Then, I added a collider and rigidbody to both the enemy and player objects. Next, I created a new script that makes the enemy chase the player when they are within a certain distance, and attached the script to the enemy object. In the 'Update' function, I checked per frame whether the player is close to the enemy, and if so, moved the enemy towards the player's position.


5.	I imported a ball asset from Unity assets and attached a new script to it to enable picking up and throwing. In the script, I programmed the 'F' key to set the ball's position to that of the player's parent object when it is picked up, and the 'G' key to make the ball move in the direction of the camera when it is thrown.

Total hours: 8.5
![Week 2](https://github.com/muhammadser1/DODGEBALL-LEGEND/blob/main/week2.gif)


## Week 3:
1.	I added a 'Character Controller' component to the enemy game object and increased its mass to fix the bug where the enemy would fall down when chasing the player during movement.
2.	I created a UI canvas and used the "slider" element to create health bars for both the enemy and player characters. Then, I adjusted the position and scale of the sliders by clicking on the 2D button and using the transform tools. After that, I created a script and attached it to each slider, which updates the value of the slider to reflect the current health of each character.

3.	I used the collider function to check if the player hit the ball, and then I made the slider value decrease by 10 (Using Collider.CompareTag"Ball").
4.	I imported a healing item from Unity assets. When the player approaches the position of the item, I use a script to update the slider value of the player's health by +10

Total hours: 11.5
![Week 3](https://github.com/muhammadser1/DODGEBALL-LEGEND/blob/main/week3.gif)

## week 4:
Unable to make any progress due to other commitments.

## Week 5:

![](https://github.com/muhammadser1/DODGEBALL-LEGEND/blob/main/BUG.png)


Unfortunately, I encountered a bug while pushing some files to the repository. Despite my efforts, I was unable to fix it, possibly due to importing some files from Unity assets. As a result, I decided to create a new project and start from scratch by copying my previous work without using any imported files from the Unity asset store.
During this week:
I created a new scene and added a canvas UI to create a menu with 3 buttons: play, quit, and link. Then, I created a new script for the main menu and connected each button to its corresponding function. If the player presses the 'play' button, the play() function will be called to load the first scene (samplescene), which is the game. If the player clicks the 'link' button, the openURL function is used to direct the player to a GitHub link.

I also added two text prompts to the canvas, "Press F to pick up the ball" and "Press G to throw". These texts are initially set to inactive. In the player's script, I added code to check if the player is close enough to the ball. If the player is close, the first text prompt will become active. When the player picks up the ball by pressing 'F', the second text prompt will become active.

Total hours: 8.5

![](https://github.com/muhammadser1/DODGEBALL-LEGEND/blob/main/Week%205.gif)


## Week 6:
I created two different rooms: Room 0 is the practice room, which has three targets that the player must hit with the balls to continue. There is a door that will open if the player hits all the targets. Room 1 has an enemy that can chase the player. If the player kills the enemy, they have to go to a specific zone and press 'E' to jump higher to continue to Room 2. I have two different types of balls - both spheres but with different parameters such as scale, speed, and power. If a ball hits the player, their health points (HP) will decrease. I also added a new scene called "Win Game". If the player kills all the enemies, this new scene will be loaded.

In the "Win Game" scene, I created a canvas UI that has a menu with three buttons: "Play Again", "Quit", and "Link to Github".

Total hour: 7.5 

https://github.com/muhammadser1/DODGEBALL-LEGEND/blob/main/week%201-6%20(summary).mp4                                                                      
