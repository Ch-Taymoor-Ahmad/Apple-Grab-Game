# Apple-Grab-Game
Apple Grab Game
To create a **2D game in Unity** where the **hand moves with the mouse** to grab apples and coins, follow this documentation.

### **Game Overview**
- **Objective**: Move a 2D hand sprite with the mouse to grab stationary apples and coins.
- **Player (Hand)**: A 2D sprite of a hand controlled by the mouse position.
- **Collectibles**: Apples and coins that disappear when grabbed, awarding points.

## **Step 1: Unity Setup**

### **1.1 Create a New 2D Project**
1. Open Unity and create a new 2D project.
2. Save your scene (e.g., `AppleGrabGame`).

### **1.2 Add a Hand**
1. Import or create a hand sprite.
2. Drag the hand sprite into the **Hierarchy** and rename it `Hand`.
3. Add the following components to the hand:
   - **BoxCollider2D**: For collision detection.
   - **Rigidbody2D**:
     - Set **Body Type** to `Kinematic` to allow precise movement.

### **1.3 Add Collectibles**
1. Import or create sprites for apples and coins.
2. Drag the apple and coin sprites into the **Hierarchy** and rename them `Apple` and `Coin`.
3. Add the following components to each:
   - **CircleCollider2D**: For collision detection.
4. Tag these objects as `Apple` and `Coin` respectively.
5. Create prefabs for the apple and coin by dragging them into the **Project** panel.

### **1.4 UI for Score**
1. Add a **Canvas** to the scene.
2. Add a **Text** object to the canvas to display the score.
   - Rename it `ScoreText`.
   - Position it at the top of the screen.

## **Step 2: Hand Controller Script**

Create a script to move the hand with the mouse and handle collision with collectibles.

## **Step 3: Game Manager Script**

Create a script to manage the score and update the UI.

## **Step 4: Spawning Collectibles**

To randomly spawn apples and coins, create a script to spawn them at random positions.

## **Step 5: Final Setup**

### **5.1 Prefabs**
1. Drag the apple and coin GameObjects into the **Project** panel to create prefabs.
2. Assign the prefabs to the `Spawner` script.

### **5.2 Testing**
1. Press **Play** and move the mouse around. The hand should follow the cursor.
2. Move the hand over apples and coins to collect them.
3. Verify the score updates correctly in the UI.


## **Optional Features**
1. **Sound Effects**: Add a grab sound when the hand collects an item.
   - Add an `AudioSource` component to the hand.
   - Play the sound in the `GrabItem` method.
   
2. **Timed Challenge**: Add a countdown timer to increase difficulty.
   - Display the timer in the UI.
   - End the game when the timer reaches 0.

3. **Hand Animation**: Add an animation for grabbing items (e.g., scaling or changing the sprite).

Would you like help implementing any of these optional features or further tweaking the design? Let me know!
