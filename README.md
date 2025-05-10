# Valorant Player Performance Analyzer

This project is a desktop application developed in C# that allows users to retrieve and analyze Valorant player performance statistics using the public [Henrik API](https://docs.henrikdev.xyz/). It calculates custom performance scores based on in-game metrics and presents the results in a clear and interactive UI.

## Features

- 🔎 Search for a Valorant player by username and tag.
- 📊 Retrieve detailed statistics such as:
  - Kills, deaths, assists
  - Accuracy (headshots, bodyshots, legshots)
  - Utility usage (ability casts)
  - Damage made and received
  - First kills and first deaths
  - AFK and friendly fire behavior
- 🧮 Custom performance score system including:
  - KDA Score
  - Accuracy Score
  - Damage Score
  - Utility Score
  - Behavior Score
  - First Kill vs. First Death Score
- 🎨 Visual user interface built using WPF (Windows Presentation Foundation)
- 🔁 Dynamic data updates via API integration

## Architecture

- **Backend Logic**: Written in C#, it handles API communication, data parsing, and performance calculation.
- **Frontend (UI)**: Built with WPF, using XAML for layout and binding for dynamic updates.
- **Model Layer**: Represents each player and their stats using C# classes.

## Requirements

- .NET 6.0 SDK or higher
- Visual Studio 2022 or newer
- Windows OS

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/valorant-performance-analyzer.git
   cd valorant-performance-analyzer
