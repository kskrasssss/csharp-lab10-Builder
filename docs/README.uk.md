🇬🇧 [English](README.md) | 🇺🇦 **Українська**

# 🚗 Lab10: Породжувальні шаблони (частина 2) у сервісі каршерингу

Консольний проєкт на **C# / .NET**, що моделює три проблемні ситуації каршерингу «Міськавто» шаблонами **Abstract Factory**, **Factory Method** і **Builder**. Кожна подія виводиться в журнал у форматі `[час] [джерело] подія`.

![C#](https://img.shields.io/badge/C%23-12-239120?logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-8.0%2B-512BD4?logo=dotnet&logoColor=white)

## 📖 Про проєкт

| Завдання | Проблема | Шаблон | Рішення |
|----------|----------|--------|---------|
| 1 | Телематику, картку й датчик вибирали окремо, і вони не збігалися | **Abstract Factory** | `IVehicleKitFactory` створює весь узгоджений набір; `FleetServiceDesk` знає лише абстракції |
| 2 | Поїздка створювалась розгалуженням за видом оренди в спільному процесі | **Factory Method** | `RentalService.Rent` єдиний процес, підкласи реалізують `CreateTrip` |
| 3 | Бронювання створювали величезним конструктором, можливі неповні об'єкти | **Builder** | `BookingBuilder` збирає покроково, `Build()` перевіряє; `BookingDirector` містить типові послідовності |

## 👥 Автори

- **_Катя_**: [@kskrasssss](https://github.com/kskrasssss): завдання 1
- **_Стас_**: [@Getis8](https://github.com/Getis8): завдання 2, 3
- Крос-рев'ю та README: обоє

## ⬇️ Як завантажити

```bash
git clonehttps://github.com/kskrasssss/csharp-lab10-Builder
cd your-repo
```

## ▶️ Як запустити

1. Встанови [.NET SDK](https://dotnet.microsoft.com/download).
2. З кореня проєкту:
   ```bash
   dotnet build
   dotnet run
   ```
3. Обери `1`, `2` або `3` у меню.

## 📁 Структура

```text
├── Program.cs
├── Common/                 # журнал
├── Task1_AbstractFactory/
├── Task2_FactoryMethod/
├── Task3_Builder/
├── Runner/                 # окремий метод для кожної ситуації
└── docs/
    ├── diagrams/           # UML-діаграми класів (.mmd + .svg/.png)
    └── CROSS-REVIEW.md
```

## 📝 Ліцензія

Проєкт створено в навчальних цілях. Використовуй вільно.