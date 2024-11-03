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
```powershell
   Luo projektikansio: mkdir C:\Temp\Tehtava4

### Vaihe 2: Varmista että olet oikeassa hakemistossa PowerShellissa

2. Varmista, että olet oikeassa hakemistossa, eli suorita tämä komento ensin: 
```powershell
cd C:\Temp\Tehtava4

### Vaihe 3: Luo uusi Solution, luo uusi AppLogger-moduuli (classlib) ja App-konsolisovellus, sekä lisää molemmat projektit
Solutioniin

3. Seuraavaksi voit kirjoittaa yksitellen seuraavat komennot (eli rivi kerrallaan, ei siis kaikkia komentoja putkeen):
Luo uusi Solution: 
```powershell
dotnet new sln

Luo AppLogger -moduuli (classlib): 
```powershell
dotnet new classlib -n AppLogger

Luo App-konsolisovellus: 
```powershell
dotnet new console -n App

Lisää molemmat projektit Solutioniin:
 ```powershell
dotnet sln add AppLogger\AppLogger.csproj
dotnet sln add App\App.csproj

### Vaihe 4: Linkitä projektit toisiinsa

4. Linkitä projektit toisiinsa eli lisää viittaus AppLogger-projetiin App-projektista:
```powershell
dotnet add .\App\App.csproj reference .\AppLogger\AppLogger.csproj

### Vaihe 5: Avaa PowerShellin komennolla Visual Studio Code

5. Avaa Visual Studio Code komennolla: code .

### Vaihe 6: Muokkaa Visual Studio Codessa AppLogger-moduulia eli muuta Class.cs tiedoston nimi Logger.cs:ksi

6. Visual Studio Codessa: Muokkaa AppLogger-moduulia eli etsi Class.cs tiedosto (AppLogger:ssa) ja uudelleennimeä se Logger.cs nimiseksi. Uudelleennimeämisen jälkeen muokkaa Logger.cs tiedostoa näin:
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

7. Älä sulje Visual Studio Codea, vaan siirry seuraavaksi takaisin PowerShelliin ja kirjoita komento:
```powershell
dotnet build

### Vaihe 8: Muokkaa Visual Studio Codessa App-projektissa näkyvää Program.cs tiedostoa

8. Tee seuraavaksi Visual Studio Codessa näin: Siirry App-projektiin ja avaa Program.cs-tiedosto. Lisää koodi, joka kutsuu Logger.Log-metodia:
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

9. Palaa takaisin PowerShelliin ja kirjoita komento:
```powershell
dotnet run --project App

### Vaihe 10: Asenna Humanizer-kirjasto PowerShellin avulla

10. Siirry takaisin AppLogger-projektiin ja asenna Humanizer-kirjasto PowerShellissa komennolla:
```powershell
dotnet add .\AppLogger\AppLogger.csproj package Humanizer

Vaihe 11: Muokkaa Visual Studio Codessa Logger.cs tiedostoa, jotta voit käyttää Humanizeria

11. Siirry Visual Studio Coden puolelle takaisin ja muokkaa Logger.cs-tiedostoa käyttämään Humanizeria:
```csharp
using Humanizer;

public static void Log(string text)
{
    Console.WriteLine(text.Humanize());
}
```
Vaihe 12: Testaa, että asentamasi Humanizer kirjasto toimii

12. Testaa Humanizer eli kirjoita komento, joka suorittaa sovelluksen uudelleen:
```powershell
dotnet run --project App

DONE! Valmista tuli.

### Jos joku kohta jäi epäselväksi, voit ottaa yhteyttä ja kysyä rohkeasti.