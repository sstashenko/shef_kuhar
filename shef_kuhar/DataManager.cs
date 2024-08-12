using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace shef_kuhar
{
    public class DataManager
    {
        public void SaveRecipesToXml(List<Recipe> recipes, string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<Recipe>)); 
            using (var stream = new FileStream(filePath, FileMode.Create)) 
            {
                serializer.Serialize(stream, recipes); 
            }
        }
        public List<Recipe> LoadRecipesFromXml(string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<Recipe>)); 
            using (var stream = new FileStream(filePath, FileMode.Open)) 
            {
                return (List<Recipe>)serializer.Deserialize(stream); 
            }
        }
        public List<Product> LoadProductsFromXml(string filePath)
        {
            if (!File.Exists(filePath)) 
            {
                return new List<Product>(); 
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>)); 
            using (FileStream fs = new FileStream(filePath, FileMode.Open)) 
            {
                return (List<Product>)serializer.Deserialize(fs); 
            }
        }
        public void SaveProductsToXml(List<Product> products, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>)); 
            using (FileStream fs = new FileStream(filePath, FileMode.Create)) 
            {
                serializer.Serialize(fs, products); 
            }
        }
    }
}
