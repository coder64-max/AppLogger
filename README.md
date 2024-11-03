# AppLogger

Yksinkertainen lokikirjasto, joka kirjoittaa viestejä konsoliin.

## Projektin rakenne

Tämä projekti koostuu kahdesta osasta:
- **AppLogger**: classlib-tyyppinen moduuli.
- **App**: konsolisovellus, joka käyttää AppLogger-moduulin palvelua (Logger.Log).

# Ohjeet

Aivan aluksi sinulla täytyy olla asennettuna Visual Studio Code ja PowerShell 7.4.6:
- [Visual Studio Code](https://code.visualstudio.com/)
- [PowerShell 7.4.6](https://github.com/PowerShell/PowerShell/releases)

### Vaihe 1: Luo projekti
 
1. Avaa PowerShell ja luo projekti:
Luo projektikansio (Powershell): mkdir C:\Temp\Tehtava4

### Vaihe 2: Varmista että olet oikeassa hakemistossa PowerShellissa

2. PowerShell:ssä varmista, että olet oikeassa hakemistossa, eli suorita tämä komento ensin: 
cd C:\Temp\Tehtava4

### Vaihe 3: Luo uusi Solution, luo uusi AppLogger-moduuli (classlib) ja App-konsolisovellus, sekä lisää molemmat projektit Solutioniin 
### (kirjoita yksitellen seuraavat komennot eli rivi kerrallaan, ei siis kaikkia komentoja kerralla yhteen putkeen:

### Luo uusi Solution PowerShell:ssä: 
dotnet new sln

### Luo AppLogger -moduuli (classlib) PowerShell:ssä: 
dotnet new classlib -n AppLogger

### Luo App-konsolisovellus PowerShell:ssä:
dotnet new console -n App

### Lisää molemmat projektit Solutioniin PowerShellin avulla:
dotnet sln add AppLogger\AppLogger.csproj
dotnet sln add App\App.csproj

### Vaihe 4: Linkitä projektit toisiinsa PowerShell:llä eli lisää viittaus AppLogger-projetiin App-projektista:
dotnet add .\App\App.csproj reference .\AppLogger\AppLogger.csproj

### Vaihe 5: Avaa Visual Studio Code PowerShellin kautta komennolla:
code .

### Vaihe 6: Muokkaa Visual Studio Codessa AppLogger-moduulia eli uudelleennimeä AppLockerin Class.cs tiedosto Logger.cs nimiseksi
### Uudelleennimeämisen jälkeen muokkaa Logger.cs tiedostoa näin:
```csharp
using System;

namespace AppLogger
{
    public class Logger
    {
        public static void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}
```
### Vaihe 7: Siirry takaisin PowerShelliin (mutta älä sulje Visual Studio Codea)
### Kirjoita PowerShelliin komento:
dotnet build

### Vaihe 8: Muokkaa Visual Studio Codessa App-projektissa näkyvää Program.cs tiedostoa
### Siirry App-projektiin ja valitse Program.cs-tiedosto. Kirjoita koodi Program.cs tiedostoon, joka kutsuu Logger.Log-metodia:
```csharp
using System;
using AppLogger;

class Program
{
    static void Main(string[] args)
    {
        Logger.Log("Hello from App!");
    }
}
```
### Vaihe 9: Suorita PowerShellissa App projekti
### PowerShell:ssä kirjoita komento:
dotnet run --project App

### Vaihe 10: Asenna Humanizer-kirjasto PowerShellin avulla
### Alapuolella olevalla komennolla siirryt takaisin AppLogger-projektin hakemistoon PowerShell:ssä ja asennat viimeisimmän vakaan version Humanizer-kirjastosta:
dotnet add .\AppLogger\AppLogger.csproj package Humanizer

### Vaihe 11: Muokkaa Visual Studio Codessa Logger.cs tiedostoa, jotta voit käyttää Humanizeria
### Siirry Visual Studio Coden puolelle takaisin ja muokkaa Logger.cs-tiedostoa käyttämään Humanizeria (C# koodi):
```csharp
using System;
using Humanizer;

public static void Log(string text)
{
    Console.WriteLine(text.Humanize());
}
```
### Vaihe 12: Testaa, että asentamasi Humanizer-kirjasto toimii
### Testaa Humanizer eli kirjoita komento PowerSell:ssä, joka suorittaa sovelluksen uudelleen:
dotnet run --project App

#### DONE! Valmista tuli
#### Jos joku kohta jäi epäselväksi, voit ottaa yhteyttä ja kysyä rohkeasti.
