using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
{
    internal class FetchJson
    {
        public FetchJson()
        {
            public class FetchJson
        {
            public Inventory Read(string path)
            {

                using (StreamReader file = new StreamReader(path))
                {
                    try
                    {
                        string json = file.ReadToEnd();
                        return JsonConvert.DeserializeObject<Inventory>(json);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("problem occurs");
                        return null;
                    }
                }
            

          
            
            }
        }
    }
}