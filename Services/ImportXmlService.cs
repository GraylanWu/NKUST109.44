using System;
using MediaSystem.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSystem.Services
{
    class ImportXmlService
    {
        private int count;
        public ImportXmlService() { }
        public ImportXmlService(int count)
        {
            this.count = count;
        }
        public List<Estate> LoadFormFile(string filepath)
        {
            var str = System.IO.File.ReadAllText(filepath);

            var xDocument = System.Xml.Linq.XDocument.Parse(str);
            //System.Xml.Linq.XDocument xDocument = System.Xml.Linq.XDocument.Parse(str);

            var targets = xDocument.Descendants("Estate");


            return targets
                .Select(x =>
                {
                    var item = new Estate();
                    item.總層數 = x.Element("總層數").Value;
                    item.構造別 = x.Element("構造別").Value;
                    item.用途別 = x.Element("用途別").Value;
                    item.單價 = x.Element("單價").Value;
                    return item;
                })
                .ToList();
        }
    }
}
