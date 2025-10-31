# Elites Pizza – Windows Desktop Ordering System

![Elites Pizza UI](https://github.com/Alhajjy/C_Sharp-Projects/raw/main/FrontEnd%20Projects/Pizza.PNG)  

## Overview

**Elites Pizza** is a sleek, user-friendly Windows desktop application built with **C# and Windows Forms** that simulates a real-world pizza ordering experience. Designed with a clean, intuitive interface and robust logic, this project demonstrates strong software engineering practices, attention to detail, and a commitment to delivering polished, production-ready solutions.

Whether you're evaluating talent for a desktop development role or seeking a foundation for a scalable point-of-sale (POS) system, **Elites Pizza** showcases professional-grade coding standards, maintainable architecture, and user-centric design.

---

## ✨ Key Features

- **Interactive Order Configuration**  
  Users can customize their pizza by selecting:
  - **Size**: Small ($20), Medium ($30), Large ($40)
  - **Crust Type**: Thin (free) or Thick (+$5)
  - **Toppings**: 6 options (each +$5): Extra Cheese, Mushrooms, Tomatoes, Onion, Olives, Green Peppers
  - **Dining Preference**: Eat-in or Take-out

- **Real-Time Price Calculation**  
  The total price updates instantly as selections change—no manual “Calculate” button needed. This provides immediate feedback and enhances user experience.

- **Order Summary Panel**  
  A dedicated section displays all user choices and the final price in a clear, professional layout—ideal for order confirmation or receipt generation.

- **Order Finalization & Form Reset**  
  - **Order Pizza**: Locks input controls to prevent changes after order confirmation (simulating checkout).
  - **Reset Form**: Restores all selections to defaults for a new order.

---

## 🛠 Technical Highlights

- **Clean, Maintainable Codebase**  
  - Logical separation of concerns: UI events trigger well-defined helper methods (`GetSizeCost()`, `GetToppingsCost()`, etc.).
  - Avoids code duplication through reusable functions.
  - Uses `Tag` properties for embedded pricing data—enabling easy future updates without hardcoding values.

- **Event-Driven Architecture**  
  Every user interaction (radio button, checkbox) triggers immediate UI and price updates—ensuring responsiveness and consistency.

- **Professional UI/UX Design**  
  - Consistent color scheme (gold on black) with clear visual hierarchy.
  - Grouped controls with descriptive labels.
  - Responsive layout that scales well across standard resolutions.

- **Extensible Structure**  
  The modular design makes it easy to:
  - Add new toppings or sizes
  - Integrate with a database (e.g., SQL Server)
  - Export orders to PDF or print receipts
  - Connect to a backend API for real ordering

---

## 💡 Why This Project Stands Out

This isn’t just a classroom exercise—it’s a **production-minded prototype** that reflects real-world software principles:

- **User-first thinking**: Every interaction is smooth, predictable, and informative.
- **Code professionalism**: Readable, commented, and logically organized—ready for team collaboration.
- **Attention to edge cases**: Handles empty toppings gracefully (“No Toppings” → dynamic list).
- **Scalability mindset**: Built with future enhancements in mind (e.g., localization, payment integration, user accounts).

---

## 🚀 Getting Started

### Prerequisites
- Windows OS
- .NET Framework (compatible with .NET Framework 4.x)
- Visual Studio (2019 or later recommended)

### Installation
1. Clone this repository:
   ```bash
   git clone https://github.com/Alhajjy/Elites-Pizza.git
   ```
2. Open `Pizza_Project.sln` in Visual Studio.
3. Build and run the application.

---

## 📬 Let’s Connect

This project represents my passion for building intuitive, reliable software that solves real problems. I’m always eager to bring this level of craftsmanship to enterprise applications, desktop tools, or customer-facing systems.

**GitHub**: [@Alhajjy](https://github.com/Alhajjy)  
**Available for**: Full-time roles, contract projects, or collaborative opportunities in C#/.NET development.

---

> **Elites Pizza** – Where great code meets great pizza. 🍕
