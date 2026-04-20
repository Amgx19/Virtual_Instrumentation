# 🎛️ Virtual Instrumentation
### Graduation Project — Al-Baha University, Faculty of Engineering

<p align="center">
  <img src="https://img.shields.io/badge/Platform-Windows-blue?style=for-the-badge&logo=windows" />
  <img src="https://img.shields.io/badge/Language-C%23-purple?style=for-the-badge&logo=csharp" />
  <img src="https://img.shields.io/badge/Framework-.NET%209-blueviolet?style=for-the-badge&logo=dotnet" />
  <img src="https://img.shields.io/badge/Database-SQLite-lightgrey?style=for-the-badge&logo=sqlite" />
  <img src="https://img.shields.io/badge/Hardware-ATmega32-red?style=for-the-badge&logo=arduino" />
  <img src="https://img.shields.io/badge/Year-2025--2026-green?style=for-the-badge" />
</p>

---

## 📌 Overview

**Virtual Instrumentation** is a graduation project that simulates expensive physical measurement instruments — such as oscilloscopes and data analyzers — using a **software-based approach**. Instead of investing in costly lab equipment, this system reads real analog sensor data via a microcontroller and presents it through a rich, real-time graphical interface on a PC.

The project demonstrates how software can replace or complement traditional hardware instruments in educational and engineering environments.

---

## 🎯 Project Goals

- Replace expensive measurement devices (e.g., oscilloscopes, signal analyzers) with software equivalents
- Collect real analog signals from potentiometers via an **ATmega32** microcontroller
- Transmit sensor data over **Serial (UART)** to a Windows application
- Display, record, and analyze the data in real time
- Export full analytical reports to **Excel (.xlsx)**

---

## 🔬 Case Study

The system uses **two variable resistors (potentiometers)** connected to the **ADC channels** of an **ATmega32** microcontroller. The microcontroller reads the analog values (0–1023), formats them as an 8-character string (`XXXXYYYY`), and transmits them over **UART at 9600 baud** to the PC application via a COM port.

```
ATmega32 ADC  →  UART (9600 baud)  →  COM Port  →  Virtual Instrumentation App
```

---

## 🖥️ Application Features

### 🌟 Welcome Screen
- Animated splash screen with smooth **fade-in / fade-out** transitions
- Animated loading progress bar with status messages
- Displays project title, academic year, and team members

### 📊 Main Dashboard (`MainDashboardForm`)
| Feature | Description |
|--------|-------------|
| **COM Port Manager** | Auto-detects available COM ports, connects/disconnects in one click |
| **Real-Time Gauges** | Two animated solid gauges displaying live POT1 and POT2 values (0–1023) |
| **Live Line Charts** | Two real-time scrolling charts showing the last 30 readings per sensor |
| **Data Grid** | Live tables showing the 20 most recent readings per channel |
| **Simulation Mode** | Generate random data without hardware for testing and demonstration |
| **SQLite Database** | Auto-saves every 3rd reading to a local `data.db` file |
| **Clear All Data** | Wipe database and reset ID sequence with one click |

### 📈 Statistics Form (`StatisticsForm`)
Full statistical analysis of all recorded readings:

- **Min / Max / Average / Count** — displayed as animated solid gauges per sensor
- **Trend Line Chart** — last 50 readings as a styled line chart
- **Pie Chart** — value distribution: Low (0–340) / Medium (341–682) / High (683–1023)
- **Comparison Chart** — side-by-side overlay of POT1 vs POT2 values
- **Standard Deviation & Median** — calculated from the full dataset
- **Export to Excel (.xlsx)** — generates a multi-sheet professional report including:
  - 📋 Summary Dashboard Sheet
  - 📊 POT1 Statistics Sheet (with distribution pie chart)
  - 📊 POT2 Statistics Sheet (with distribution pie chart)
  - 📄 Raw Data Sheet (with POT1 vs POT2 comparison line chart)

### 🗄️ Database Viewer (`DatabaseViewerForm`)
A full-featured database browser built into the app:

- Browse any table in the SQLite database via a dropdown
- View, search, and filter records (by ID or timestamp)
- Delete selected rows or clear entire tables
- Execute custom `SELECT` SQL queries safely
- Export any table to a **CSV file**

---

## 🏗️ Project Architecture

```
Virtual_Instrumentation/
│
├── Program.cs                    # Entry point — initializes DB then launches WelcomeForm
├── DatabaseInitializer.cs        # Creates and manages the SQLite database
│
├── WelcomeForm.cs/.Designer.cs   # Animated splash/loading screen
├── MainDashboardForm.cs/.Designer.cs  # Main control panel + real-time visualization
├── StatisticsForm.cs/.Designer.cs     # Data analysis + Excel export
├── DatabaseViewerForm.cs/.Designer.cs # Database browser + CSV export
│
└── Virtual_Instrumentation.sln   # Visual Studio 2022 solution file
```

---

## 🛠️ Technologies & Libraries

| Technology | Usage |
|-----------|-------|
| **C# / .NET 9** | Core application language and framework |
| **Windows Forms** | Desktop UI framework |
| **LiveCharts (WPF)** | Real-time line charts and solid gauges |
| **Microsoft.Data.Sqlite** | Lightweight local database (SQLite) |
| **EPPlus (OfficeOpenXml)** | Professional Excel report generation |
| **System.IO.Ports** | Serial communication with ATmega32 |

---

## ⚙️ Hardware Requirements

| Component | Specification |
|-----------|--------------|
| Microcontroller | ATmega32 |
| Sensors | 2× Variable Resistors (Potentiometers) |
| Communication | UART — 9600 baud, 8-N-1 |
| Interface | USB-to-Serial adapter (or on-board UART) |

### Data Protocol
The ATmega32 sends an 8-character ASCII string over serial:
```
XXXXYYYY\n
```
Where `XXXX` = POT1 value (0–1023, zero-padded) and `YYYY` = POT2 value (0–1023, zero-padded).

---

## 🚀 Getting Started

### Prerequisites
- Windows 10/11
- [.NET 9 Runtime](https://dotnet.microsoft.com/download/dotnet/9.0)
- Visual Studio 2022 (to build from source)
- ATmega32 connected via COM port (or use Simulation Mode)

### Build & Run

```bash
# 1. Clone the repository
git clone https://github.com/Amgx19/Virtual_Instrumentation.git

# 2. Open the solution in Visual Studio 2022
#    File → Open → Virtual_Instrumentation.sln

# 3. Restore NuGet packages (auto on build)

# 4. Build and Run (F5)
```

### First Launch
1. The app auto-creates the SQLite database at:
   `%LocalAppData%\VirtualInstrumentation\data.db`
2. The Welcome splash screen loads and transitions to the Main Dashboard
3. Select your COM port and click **Open** — or enable **Simulation Mode** to test without hardware

---

## 📷 Application Flow

```
[Splash Screen]
      ↓  (fade in → progress bar → fade out)
[Main Dashboard]
      ├── Real-time gauges & charts (Serial or Simulation)
      ├── Auto-save to SQLite every 3 seconds
      ├── → [Statistics Form]  (analysis + Excel export)
      └── → [Database Viewer]  (browse + CSV export)
```

---

## 👨‍💻 Team

| Name | Student ID |
|------|-----------|
| **Eng. Amjad Mohammed Zakaria** | 443047268 |
| **Eng. Rayan Thani Abakar** | 443047360 |
| **Eng. Othman Jamal Al-Ameen** | 443047358 |

---

## 🏛️ Institution

**Al-Baha University**  
Faculty of Engineering — Electrical & Computer Engineering  
Academic Year: 2025 – 2026

---

## 📄 License

This project was developed as an academic graduation project. All rights reserved to the project team and Al-Baha University.

---

<p align="center">
  Made with ❤️ by the Virtual Instrumentation Team — Al-Baha University Engineering 2026
</p>
