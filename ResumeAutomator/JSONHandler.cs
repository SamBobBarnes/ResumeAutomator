using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ResumeAutomator
{
    class JSONHandler
    {
        public bool WriteToJSON(ResumeData data)       // Write the data to json file
        {
            string dataSerialized = JsonConvert.SerializeObject(data);
            try
            {
                File.WriteAllText(@"ResumeData.json", dataSerialized);
                return true;
            }
            catch
            {
                Console.WriteLine("Something went wrong");
                return false;
            }
            
        }

        public bool WriteToJSON(ResumeData data, string file)       // Write the data to json file
        {
            string dataSerialized = JsonConvert.SerializeObject(data);
            try
            {
                File.WriteAllText(file, dataSerialized);
                return true;
            }
            catch
            {
                Console.WriteLine("Something went wrong");
                return false;
            }

        }

        public ResumeData ReadFromJSON()    // Read data from json file and return object
        {
            string data;
            try 
            {
                data = File.ReadAllText(@"ResumeData.json");
            }
            catch
            {
                return null;
            }

            ResumeData dataDeserialized = JsonConvert.DeserializeObject<ResumeData>(data);
            return dataDeserialized;
        }

        public ResumeData ReadFromJSON(string file)    // Read data from json file and return object
        {
            string data;
            try
            {
                data = File.ReadAllText(file);
            }
            catch
            {
                return null;
            }

            ResumeData dataDeserialized = JsonConvert.DeserializeObject<ResumeData>(data);
            return dataDeserialized;
        }
    }
}