using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace PersonalMovieLibrary
{
    public static class FilmDictionary
    {
        public static Dictionary<Guid, Films> FilmDic { get; } = new Dictionary<Guid, Films>();

        // Method to save films to a file (JSON format)  
        public static void SaveFilmsToFile()
        {
            string strFilePath = "C:\\Users\\jorned250308\\OneDrive - GTI Beveren\\5ADB\\Programmeren\\Samenvatting\\PopcornVault\\PersonalMovieLibrary\\Files\\Films.json";
            // Define the file path  
            // Serialiseer het FilmDic woordenboek (met Guid als sleutel en Films als waarde) naar een JSON-string.  
            // Formatting.Indented zorgt ervoor dat de JSON leesbaar wordt geformatteerd (met inspringingen).  
            var jsonData = JsonConvert.SerializeObject(FilmDic, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(strFilePath, jsonData);
        }
    }
}
