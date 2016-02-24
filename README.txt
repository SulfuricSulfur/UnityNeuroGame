Rules:
A ball will appear on the screen. This ball is the target. After 2 seconds the ball will disappear.
 After that, a series of different balls will appear on the screen for 2 seconds and then disappear with 1 
second in between each. The goal is to try and match the ball on the screen with the target that was shown at the beginning.
There are 6 balls in a cycle (including the target). You can choose how many times you want to loop through the cycles. 
In some cycles there will not always be a target, so be sure to pay attention.  Your score is based on how fast you press 
SPACE on the object that matches the target. The faster you react, the more points you get. You also get points if you 
recognize a ball as not the target and do not press SPACE on it. The number of points you get for not choosing the wrong 
ball will increase the longer the game goes on. However, if you press space on the wrong ball, the point increase from not 
choosing the wrong ball will return back down to zero. If you miss the target, the point increase will also return to zero.
Every time you choose the wrong ball your score will be reduced. The more you choose the wrong ball, the more points will be deducted from your score.

Organization:
The game is broken into multiple scenes. The scenes are Main, Instructions, SelectTrial, Game, and FinishGame. 
Main is where the user starts. From there, the user can read instruction by clicking a button that will take them to the instruction screen.
 If the user clicks play, they will be taken to the SelectTrial scene. The user will be prompted to choose how many trials they wish to play. 
These trials correspond to how many trials that will be. Once the user presses a button, the TrialSetter object will read what button 
the user pressed, and send it over to the Game scene. The TrialSetter is kept awake so that the other scene can get that information from the
 SelectTrial scene. In the Game scene, this is where the game will start. The target Ball will be shown on the screen while also informing 
the user that that object is the target. On the corner of the screen will also be the score. Once the target has gone away, the balls will
 start showing up on screen. If the user presses SPACE on the wrong ball, text will show up telling the user that they have chosen the wrong ball. 
The score will also be reduced. If the user chooses the right ball, text will show up and inform the user that they have chosen the right ball.
 Their score will increase. Once the game has cycled through all the balls however many times, the user will be taken to the FinsihGame scene. 
On that screen, the user will be informed of their score. They will also be told how many targets there were in that game and their overall 
average amount of points they got from reacting to the target. From there, the user can choose to return to the menu to play again or quit the game.

Code Organization:
At the menu, there are scripts that change the scene by Application.LoadLevel(“[Scene name]”) attached to the buttons. In the SelectTrial scene, 
there is a gameobject that will always stay awake. Once the user presses a button, depending on what button they presses, an int will be passed to the 
TrialSetter to then pass the amount of trials the user wants over to the Game scene. In the Game scene. There is a GameObjManager which handles 
the game in the scene. This game object holds 6 ball object prefabs in an array. On starting the game, the manager will choose a random object from the 
array to make the target.  The target will be displayed on the screen for 2 seconds and then destroyed when the timer object becomes greater than 2. 
During that time text will appear on the screen informing the user. Then, a list of ball objects will be created based on the 6 ball objects. 
This list will be generated based on the number of trials, and if a ball object was already shown within the 6 ball object cycle. 
The target will not be in every trial’s cycle. There is a random int that depends on the number of trials the user wanted. From there, the int will be 
between 1 and the number of trials. This number is the number of targets there will be in total. While creating the list of balls, a statement will check 
to see if a ball was already in that certain cycle’s list. If it is, it will choose another random ball that is not in use.  If the random ball 
that the int chose is the target, a statement will check to see if there is already too many targets or if it is already in use in that cycle. 
If so, then a random ball will replace the target. Once the list of balls is created, a method will check to see if the timer is between 0 and 2 seconds.
 During that time, the method will go through the list and show the ball on the screen for 2 seconds. After, the ball will be destroyed. 
Once the 1 second delay ends, the timer will reset back down to 0. If the user presses the space bar, the method will check to see if that object the user 
pressed space on was the target. If not, the user will get a method from the ScoreTracker script that handles changing the scores. 
If the user presses space and it is the target, the ScoreTracker will handle a method for increasing the score. Inside the method, a statement will be 
active as long as the user has not pressed space bar on the target. The score will constantly go down the longer the user does not press space. 
Once the user presses space, the number of points resulting will be added to the score. Once the user presses space, a bool will become true that the user 
has already pressed space and so cannot press space again while that ball is active. A statement will then check to see if the user did not press space 
on the wrong ball. If this is true, the user will have some points added to their score the longer they do not press space on the wrong ball. 
If the user misses the target, the int that keeps track of how many times the user did not press space on the wrong ball will reset back down to 0. 
Once the method has gone through all the balls in the list, another method will be called that handles going to the next scene. 
This method takes the score that the user got from the target and gets the average based on the number of targets there were. This method then 
passes this information to a ScoreHandle object that is in charge of passing information onto the next scene. The Method than LoadsLevel of the FinishGame. 
In the scene, there is FinalScoreHandler that takes in the information that the ScoreHandle passed in from the previous scene. From there, the FinalScoreHandle,
 changes the text on the canvas to show the player’s score, their average amount of react time points, and the amount of targets that were in the Trials. 
From that scene, the user can then press a button to return back to the menu or quit the game. 

Scoring:
See rules for more details about scoring.
Once the target appears on the screen, a base score will start decrease the longer the user lets the target sit on the screen. 
The faster the user presses space, the more points they will get from it. If the user presses space on the wrong ball, an int will keep track of how many 
times they pressed space on the wrong target and reduce their score by a certain amount each time. If the user does not press space on the wrong target, 
a user will keep track of how many wrong targets have successfully gone by without the user pressing them. The user’s score will increase by a certain amount each time. 
If the user presses space on the wrong target or misses the correct target, the int that kept track of how many times the user did not press space on 
the wrong target will reset back down to zero.

Interesting Things:
The average amount of points that the user got from reacting to the target is calculated and shown on the screen. 

For playing the game, you must go File->Build Settings. Each scene will needed to be added to “scenes in build” starting with
 Main,Instructions, SelectTrial, Game, and then FinishGame. This can be done by doing to each scene then clicking “Add current”. Once this is done, 
highlight the scenes and then close the window. Once that is done, the game must be started from the Menu scene due to information that is passed in 
from different scenes that is required.


