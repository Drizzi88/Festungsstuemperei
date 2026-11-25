# Festungsstuemperei

## 1 · Projektüberblick

Festungsstuemperei ist ein frühes C#-Projektgerüst. Der vorhandene Stand besteht aus einer Konsolenanwendung und einer separaten Klassenbibliothek. Die Anwendung gibt derzeit ausschließlich `Hello, World!` aus. Es gibt noch keine implementierte Spielmechanik, grafische Oberfläche oder nutzbare Festungsverwaltung.

Das Repository dokumentiert damit den Ausgangspunkt für eine mögliche Weiterentwicklung, nicht ein fertiges Spiel.

## 2 · Technische Kurzdokumentation

| Datei | Zweck |
| --- | --- |
| [Festungsstuemperei.sln](Festungsstuemperei.sln) | Visual-Studio-Solution |
| [Festungsstuemperei](Festungsstuemperei/) | Konsolenprojekt, .NET 6 |
| [Program.cs](Festungsstuemperei/Program.cs) | Einstiegspunkt |
| [LibFortress](LibFortress/) | Noch leeres Klassenbibliotheksprojekt, .NET 6 |

### Build und Start

Mit einem kompatiblen .NET SDK:

```bash
dotnet restore Festungsstuemperei.sln
dotnet build Festungsstuemperei.sln
dotnet run --project Festungsstuemperei/Festungsstuemperei.csproj
```

Erwartete Ausgabe laut Einstiegspunkt: `Hello, World!`. Die Befehle wurden in dieser Dokumentationsänderung nicht ausgeführt.

.NET 6 ist nicht mehr unterstützt. Vor einer aktiven Weiterentwicklung sollte ein Upgrade auf eine unterstützte .NET-Version geprüft werden. Es gibt keine projektspezifische Konfiguration und keine Oberfläche, die als Screenshot dokumentiert werden könnte.
