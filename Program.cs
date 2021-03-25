using System;
using MediaSystem.Services;

namespace MediaSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlService1 = new ImportXmlService();

            var datas = xmlService1.LoadFormFile(@"C:\Users\User\Documents\NKUST109.44\DataSource\House.xml");

            Console.WriteLine(string.Format("解析完成，共有{0}筆資料", datas.Count));
            datas.ForEach(x =>
            {
                Console.WriteLine(string.Format("構造主要用材：{0} 建築主要用途：{1}", x.構造別, x.用途別));
            });
            Console.ReadKey();
        }
    }
}
