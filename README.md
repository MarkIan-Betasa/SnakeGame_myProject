**Welcome to the Console SNAKE GAME in c# language**

  This is a simple snake game in C# that implement variables, loop, conditional, methods, and class. This snake game project is composed of 6 total classes (including the main program.cs, and excluding the classes inside the main classes). 

**Program.cs**
  - Under the program.cs which is the primary or main class, only the MenuOptions.Selection was written. It essentially simply just calls for the Selection() function/class under the MenuOptions.cs. The game logic is hidden from the program.cs and instead begins at another class.

**MenuOptions.cs**
  - Under the MenuOptions.cs the first set of instructions are being derived from the Selection() method, from which then the game logic flows from one method to another method or to other classes. The function of the public method Selection() is to print the introductory message of the game. Then, the program will also validate if the user input is valid by cross checking if there is a valid reference from the private method Choices(). Overall, Console.WriteLine, if...else conditional, while and for loop, and TryParse are utilized in this part of the game. The TryParse is shorter way for converting the Console.ReadLine() into the desired variable type then outs the value to another variable of the same type. TryParse is utilized throughout the program for user input validity.
  - The Choices() method simply contains a list of menu choices that the user/player can choose from.
  - The next method is the ToNextSelection() method. This method is the continuation from the Selection() method. The function of this method is to check for user input and based from the input, directs the game to the desired path. Switch casing is implemented in this part of the program.
  - Next is a method for calling the main game logic. InitializeGame() method is the method that calls for the logic of the snake game itself. This method simply makes an instance of a method in another class. This method is also an not void and returns the currentScore, which is needed in other part of the program.
  - Following this method is the ExitTimeForQuit() and ExitTimeForStart() methods. This two methods function are to Tread.Sleep() the program for 1 second. This just means that the program will temporarily delay the next command execution. This is important to display an animation like effect before starting and quiting the game. This is also used to prevent random errors in the snake game itself, like not recognizing the ConsoleKeyInfo, which I have experienced before the implementation of these two methods. Lastly, the only difference between the two method is the time for Tread.Sleep().

**SnakeCons.cs**
  - This is where the the actual logic for the snake game is located, meaning this class is responsible for running the snake game itself. Under this class fields, properties, constructor, get and set method, and etc are implemented. Fields are simply variables declared directly inside a class. They are used for global declaration of variables inside the class. They can be accessed in and out the class by means of properties. Contructor sets the initial state of fields. Get and Set method simply retrieve and assign values to fields in a class. Get and Set method in this case is used for fluidity and access control.
  - Under the Movement() method is where the game's mechanism is located. Everything that happens in the Snake game, including how it interacts with the player, is mostly controlled by the Movement() method found inside the SnakeCons class. Starting with the main element start positions—the snake's start position and the cherry's original placement on the board—we can start implementing this method. When the snake's position, the location of the cherry, or the score update changes, this procedure enters an endless loop that updates the console screen. Players can move the snake left, right, up, or down while playing by interacting with the game using the keyboard. It adjusts the game's state throughout these motions by looking for collisions with the walls or with itself. More precisely, the strategy adds to the player's score and lengthens the snake after the snake eats a cherry, but it randomly moves the cherry's location on the board. By managing the game's time to make movements fluid and by switching between distinct game states, it guarantees optimal dynamics and player involvement. At this point, the game will prompt the user to choose between restarting it and going back to the main menu so they can continue playing or exploring the surroundings. Additionally, there is an added feature where the game speed increases as the snake length increases. Finally, the main interaction techniques and game loop of the Snake game are encoded in the Movement() class, which also defines the game's usability and enjoyment aspect.
  - The method GetScore() simply retrieve and return the value of score. This is important in handling this value for other purposes of the program.
  - SelectionAfterGame() method is simply the choices for the next action the player wants to make after the game is ended by a gameover.

**DummyAccounts.cs**
  - The private method userNames() contains the player accounts that the player can login to before the initialization of the game.
  - The printUsers() method provides a simply UI for promting the player to login into an account. Inside this method, the player selection is displayed and the player input is validated.
  - checkingUsers() method is responsible for directing the program to the next set of action based on user input.

**PlayerHistory.cs**
  - The ListScores() method is mainly responsible for setting the score of each account to their designated individual score. This method sets the score based on which account played the game and makes sure that the score of each player is distinct from each other.
  - The pringtingHistory() method is responsible for printing the gaming history and score of the players. The position of the player accounts are not changing based of recent plays, but only the score is being updated.

**BorderLineLimit.cs**
  - This class only contains one method named Borders(). The only function of this method is to draw the box where the snake is placed inside. Both the snake and the cherries cannot exceed this border.

**ADDITIONAL NOTES (added features)**
  - The loop for directly restarting the game after a gameover has been added.
  - Basic login system has been added.
  - Player history based on score has been added. The game now store scores and display the         recent scores in the player history.
  - Game difficulty has been inproved.



**THAT IS ALL. I HOPE YOU ENJOY YOUR CONSOLE SNAKE GAME EXPERIENCE!**




