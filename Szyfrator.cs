using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Bezpieczny_Notatnik
{
    public static class Szyfrator
    {
        // Unikalna "sól" kryptograficzna, która wzmacnia hasło. 
        // UWAGA: Nie zmieniaj tego tekstu po zaszyfrowaniu pierwszych notatek!
        private static readonly byte[] sol = Encoding.UTF8.GetBytes("MojaTajnaSolBezpiecznegoNotatnika123!");

        // --- TEJ LINIJKI BRAKOWAŁO ---
        // Pamięta hasło w RAM podczas działania programu, by móc szyfrować notatki w locie
        public static string AktualneHaslo = "";

        // 1. METODA SZYFRUJĄCA
        public static string Zaszyfruj(string czystyTekst, string haslo)
        {
            using (Aes aes = Aes.Create())
            {
                // Mieszamy hasło użytkownika z naszą solą, aby uzyskać potężny klucz
                using (Rfc2898DeriveBytes generatorKlucza = new Rfc2898DeriveBytes(haslo, sol, 100000, HashAlgorithmName.SHA256))
                {
                    aes.Key = generatorKlucza.GetBytes(aes.KeySize / 8);
                    aes.IV = generatorKlucza.GetBytes(aes.BlockSize / 8);
                }

                ICryptoTransform szyfrujacy = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, szyfrujacy, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(czystyTekst);
                        }
                    }
                    // Zwraca zbełkotany ciąg znaków gotowy do zapisu w pliku .txt
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        // 2. METODA ODSZYFRUJĄCA
        public static string Odszyfruj(string zaszyfrowanyTekst, string haslo)
        {
            using (Aes aes = Aes.Create())
            {
                using (Rfc2898DeriveBytes generatorKlucza = new Rfc2898DeriveBytes(haslo, sol, 100000, HashAlgorithmName.SHA256))
                {
                    aes.Key = generatorKlucza.GetBytes(aes.KeySize / 8);
                    aes.IV = generatorKlucza.GetBytes(aes.BlockSize / 8);
                }

                ICryptoTransform deszyfrujacy = aes.CreateDecryptor(aes.Key, aes.IV);
                byte[] bufor = Convert.FromBase64String(zaszyfrowanyTekst);

                using (MemoryStream ms = new MemoryStream(bufor))
                {
                    using (CryptoStream cs = new CryptoStream(ms, deszyfrujacy, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}