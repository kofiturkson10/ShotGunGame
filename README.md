# Shotgun Game 🎯  
_Assignment 1 – Programming with C# (Basic Course)_

## 📘 Description  
This is a console-based game where the player faces off against the computer in a classic "Shotgun" duel.  
The game is built using Object-Oriented Programming (OOP) principles in C# and meets all assignment requirements.

The player can choose between four actions:
1. **Load** – increases ammo by 1  
2. **Shoot** – fires at the opponent (requires at least 1 shot)  
3. **Block** – defends against an incoming shot for one round  
4. **Shotgun** – a special attack that can be used when the player has 3 or more shots  

The game continuously displays the status of both players and allows restarting after a win or loss.

---

## 🧠 Technical structure  
The project is divided into several classes following OOP principles:

- **Program.cs** – Entry point of the game  
- **Game.cs** – Handles gameplay flow and round logic  
- **Player.cs** – Base class for player attributes  
- **Computer.cs** – Inherits from `Player` and handles AI logic  
- **Info.cs** – Displays player and round information  
- **RestartGame.cs** – Manages restarting after each match  
- **ActionType.cs** and **InvalidType.cs** – Handle user input and invalid choices  

---

## ▶️ How to Run the Game
### Option 1 – Run the prebuilt version
1. Go to the `submission/` folder  
2. Double-click on `ShotgunGame.exe`

The game will launch in a console window.