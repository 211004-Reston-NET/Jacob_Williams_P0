using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;

namespace Data_Logic
{
    public class Repository
    {
        private const string _filepath = "./..Data_Logic/Database/Store.Json";
        private string _jsonString;

        public Stores AddStore(Store p_rest)
        {
            List<Store> listOfStores = StoreLocations();
            listOfStores.Add(p_rest);
            _jsonString = JsonSerializer.Serialize(listOfStores);
            File.WriteAllText(_filepath,_jsonString);
            return p_rest;
        }

        public List<Stores> StoreLocations()
        {
            _jsonString = File.ReadAllText(_filepath);
            return JsonSerializer.Deserialize<List<Stores>>(_jsonString);
        }
    }
}
