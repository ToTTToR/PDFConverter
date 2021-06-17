using System;
using System.Xml;

namespace PDFConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            MeetingInfo machin = new MeetingInfo("Test1.pdf");
            String[] allInfo = machin.getInfo();
            for (int i = 0; i < allInfo.Length; i++)
                Console.WriteLine(allInfo[i]);
            machin.putInXML();
        }
    }
}
