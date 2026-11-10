# Bezpieczny Notatnik 

Desktopowa aplikacja okienkowa stworzona w języku C# (.NET 8.0 / Windows Forms), służąca do bezpiecznego tworzenia i przechowywania prywatnych notatek na dysku lokalnym.

## Główne funkcje
* **Szyfrowanie AES-256 w locie:** Wszystkie notatki są automatycznie szyfrowane i deszyfrowane przy użyciu hasła głównego użytkownika (wzbogaconego o sól kryptograficzną oraz derywację klucza PBKDF2).
* **Pierwsze uruchomienie i Import:** Możliwość utworzenia nowej bazy notatek lub zaimportowania istniejących plików.
* **Kafelkowy interfejs:** Dynamicznie generowana siatka notatek z niestandardowym, zaokrąglonym wykończeniem (`GraphicsPath`).
* **Bezpieczny podgląd (Read-Only):** Osobny widok do czytania notatek chroniący przed przypadkową edycją tekstu.
* **Zarządzanie i kopia zapasowa:** Zmiana hasła głównego (z automatycznym, ponownym zaszyfrowaniem całej bazy plików) oraz eksport wszystkich notatek do zbiorczego pliku `.txt`.

## Technologie
* C# / .NET 8.0
* Windows Forms (WinForms)
* `System.Security.Cryptography` (AES-256, PBKDF2)
* `System.Drawing.Drawing2D`
