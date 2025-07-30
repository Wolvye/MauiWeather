# MauiWeather

**MauiWeather** ist eine mobile Wetter-App, entwickelt mit **.NET MAUI**. Ziel war es, die Integration von REST-APIs, Datenbindung über MVVM und die Grundlagen mobiler UI-Entwicklung zu erlernen und praktisch umzusetzen.

---

## 🌦️ Was macht die App?

- Ruft Wetterdaten von einer externen API ab (z. B. OpenWeatherMap)
- Zeigt aktuelle Temperatur, Wetterlage und ggf. weitere Infos an
- Darstellung der Daten in einem plattformübergreifenden UI (Android / Windows / iOS)
- Demonstriert funktionierende API-Calls, JSON-Verarbeitung, MVVM-Bindung

---

## ⚙️ Tech Stack

- [.NET MAUI](https://learn.microsoft.com/dotnet/maui/)
- C# mit MVVM-Architektur
- HTTPClient & JSON-Parsing
- (Optional: OpenWeatherMap, WeatherAPI etc.)

---

## 🚧 Status

✅ *Funktional / abgeschlossen als Lernprojekt*  
🎯 *Einsatz als Vorzeigeobjekt für API-Handling in MAUI*

---

## 🛠️ Installation & Start

### Voraussetzungen

- [.NET 8 SDK](https://dotnet.microsoft.com/)
- Visual Studio 2022+ mit MAUI-Workload
- Android Emulator oder physisches Gerät

### Schritte

```bash
git clone https://github.com/Wolvye/MauiWeather.git
cd MauiWeather
dotnet build
dotnet run --framework:net8.0-android
