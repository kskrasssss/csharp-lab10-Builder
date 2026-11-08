🇬🇧 **English** | 🇺🇦 [Українська](README.uk.md)

# 🚗 Lab10: Creational Patterns (part 2) in a Car-Sharing Service

A **C# / .NET** console project that models three problem situations of the car-sharing service "Miskavto" with **Abstract Factory**, **Factory Method** and **Builder**. Every event is written to a journal in the format `[time] [source] event`.

![C#](https://img.shields.io/badge/C%23-12-239120?logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-8.0%2B-512BD4?logo=dotnet&logoColor=white)

## 📖 About

| Task | Problem | Pattern | Solution |
|------|---------|---------|----------|
| 1 | Telematics, energy card and level sensor were picked separately and mismatched | **Abstract Factory** | `IVehicleKitFactory` creates a whole consistent kit; `FleetServiceDesk` knows only abstractions |
| 2 | Trip creation was a branch on rental kind inside the shared process | **Factory Method** | `RentalService.Rent` is the single process, subclasses implement `CreateTrip` |
| 3 | Bookings were created with a huge constructor and could be incomplete | **Builder** | `BookingBuilder` assembles step by step, `Build()` validates; `BookingDirector` holds typical sequences |

## 👥 Authors

- **_Katya_**: [@kskrasssss](https://github.com/kskrasssss): task 1
- **_Stas_**: [@Getis8](https://github.com/Getis8): tasks 2, 3
- Cross-review and README: both

## ⬇️ Download

```bash
git clone https://github.com/kskrasssss/csharp-lab10-Builder
cd your-repo
```

## ▶️ Run

1. Install the [.NET SDK](https://dotnet.microsoft.com/download).
2. From the project root:
   ```bash
   dotnet build
   dotnet run
   ```
3. Choose `1`, `2` or `3` in the menu. Console text is in Ukrainian.

## 📁 Structure

```text
├── Program.cs
├── Common/                 # journal
├── Task1_AbstractFactory/
├── Task2_FactoryMethod/
├── Task3_Builder/
├── Runner/                 # one scenario method per situation
└── docs/
    ├── diagrams/           # UML class diagrams (.mmd + .svg/.png)
    └── CROSS-REVIEW.md
```

## 📝 License

Created for educational purposes. Feel free to use it.