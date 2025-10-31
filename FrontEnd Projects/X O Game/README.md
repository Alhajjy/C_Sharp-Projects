# Tic-Tac-Toe Game – Windows Forms Application

![XO Game UI](https://github.com/Alhajjy/C_Sharp-Projects/blob/main/FrontEnd%20Projects/XO.PNG)

## Overview

This project is a clean, responsive, and visually polished implementation of the classic **Tic-Tac-Toe (X/O)** game, built using **C#** and **Windows Forms**. Designed with user experience and code maintainability in mind, it demonstrates solid software engineering practices, including separation of concerns, event-driven programming, and intuitive UI design.

Perfect as a portfolio piece or a foundation for more complex game logic, this application showcases attention to detail—from dynamic turn indicators and win detection to custom-drawn grid lines and a professional restart mechanism.

---

## ✨ Key Features

- **Real-time gameplay** with alternating turns between "X" and "O".
- **Win detection** across all 8 possible winning combinations (rows, columns, and diagonals).
- **Visual feedback**:
  - Custom-drawn red grid lines using GDI+ for a sleek, modern look.
  - Clear indicators for current player turn and game winner.
- **Responsive controls**:
  - All game buttons disable automatically upon game completion.
  - "RESTART" button resets the board and state instantly.
- **Error prevention**: Attempts to click an already-filled cell trigger a friendly warning.
- **Professional UI**:
  - Consistent typography (Tahoma font).
  - Color-coded labels (blue for status, green for turn indicator).
  - Flat, non-intrusive button styling with hover-aware cursor feedback.

---

## 🛠️ Technical Highlights

- **Language**: C# (.NET Framework)
- **Framework**: Windows Forms
- **Architecture**: Event-driven with clear separation between UI logic and game rules.
- **Graphics**: Custom rendering via `Paint` event using `System.Drawing` for dynamic grid lines.
- **Code Quality**:
  - Modular methods (`RestartGame`, `CheckWinner`, `PlayTurn`) for readability and reuse.
  - No magic strings or hardcoded logic—easy to extend or refactor.
  - Full adherence to C# naming and structural conventions.

---

## 🚀 Getting Started

### Prerequisites
- Visual Studio (2019 or later recommended)
- .NET Framework (4.7.2 or higher)

### Installation
1. Clone or download this repository.
2. Open the solution file (`Tic_Tac_Toe.sln`) in Visual Studio.
3. Build and run the project (`Ctrl + F5`).

The game launches immediately with a fresh board and "X" as the starting player.

---

## 💡 Why This Stands Out

While Tic-Tac-Toe is a common beginner project, this implementation goes beyond the basics:

- **Production-ready polish**: Thoughtful UI/UX choices (e.g., rounded line caps, disabled states, clear typography) reflect professional standards.
- **Maintainable structure**: Logic is decoupled from event handlers, making it easy to add features like score tracking, AI opponents, or networked multiplayer.
- **Demonstrates core competencies**: Event handling, state management, GDI+ graphics, and defensive programming—all critical in real-world desktop applications.

---

## 📬 Let’s Connect

This project reflects my commitment to writing **clean, efficient, and user-centric code**. I’m always eager to contribute to innovative teams that value craftsmanship and attention to detail.

**GitHub**: [@Alhajjy](https://github.com/Alhajjy)  
*Open to collaboration, feedback, and new opportunities.*

---

> **"Great software isn’t just functional—it’s delightful to use."**
