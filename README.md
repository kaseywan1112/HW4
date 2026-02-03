# HW4
## Devlog
Yaokun Wan, He/him


### Bug Fixed:
One issue I ran into was that the score UI and sound effects sometimes caused a NullReferenceException at runtime. This happened because UI and audio scripts were trying to subscribe to score events before the ScoreManager was initialized. I fixed this by making sure ScoreManager was initialized first and adding null checks when subscribing to events. After that, the score updates and sound effects worked consistently without errors.

### Model-View Controller Pattern

I used a simplified model–view–controller to keep my Player logic separated from UI and audio systems. The control side of the game is mainly handled by the Player class. In Player.Update(), the script checks for space bar input and applies upward force to the Rigidbody2D to create the flap movement. The Player class also handles collisions in OnCollisionEnter2D(), where hitting a pipe triggers the game over logic.

The view side is handled by separate scripts. The ScoreUI class is responsible only for displaying the score on screen, and it updates the text based on score changes. Audio feedback is handled by AudioManager and ScoreSFX, which play flap, score, and death sounds. These view-related scripts do not handle player input or physics, which helps keep the Player code focused only on control logic.

### EVents and Singleton

To decouple the control logic from UI and audio, I used events and the Singleton pattern in the score system. The ScoreManager class is implemented as a Singleton using the ScoreManager.instance variable. It stores the score in the score variable and updates it through the IncreaseScore() method.

When the player passes through a pipe, the CheckBox script calls ScoreManager.instance.IncreaseScore(). This method triggers the OnScoreChanged event. Both ScoreUI and ScoreSFX subscribe to this event using OnEnable() and unsubscribe in OnDisable(). When the event is raised, ScoreUI updates the on-screen text and ScoreSFX plays the score sound effect. Because of this event-based structure, the Player and CheckBox scripts do not directly reference UI or audio logic.

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites

- [Free sound effect](https://mixkit.co/free-sound-effects/)