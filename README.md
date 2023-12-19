# Memory Cards Game

## Overview
Memory Cards Game is developed using Unity. In this game, the user plays a memory card game where they click on a card to find another matching card. If the cards match, they remain open; otherwise, the unmatched card is flipped back again. The game continues until the user finds all the matching cards, and all cards are flipped over to the cartoon face side.

## Method

### Card.cs
The `Card.cs` script file manages the card and its main functions. The `Start` function checks if the card is flipped and handles other functionalities.

### GameManager.cs
The `GameManager.cs` is responsible for game controls and rules. It creates main card instances, handles visible card functions, and checks if the cards are matching.

### GameOverController.cs
The `GameOverController.cs` manages the game over screen and functionality. It handles the display of the game over screen and other game functionalities.


## GamePlay

<img width="231" alt="default game screen" src="https://github.com/dronv/memory-game-unity/assets/41694884/e361e5ec-19ba-4d22-b6a1-1895936c4d26">

*Fig1.1: Game starting screen*

<img width="234" alt="playing game state" src="https://github.com/dronv/memory-game-unity/assets/41694884/d303f6ad-1f6f-4e19-ba5b-791bd9feff8f">

*Fig1.2: Game State: Playing*

<img width="230" alt="Game complete" src="https://github.com/dronv/memory-game-unity/assets/41694884/71839e8c-2476-47d8-a680-9cc6544e94ad">

*Fig1.3: Game completed, all cards matching*

