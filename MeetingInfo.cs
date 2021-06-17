using System;
using System.Xml;
using System.Text;
using System.IO;
class MeetingInfo
{
    private XmlDocument meetingDocument;
    private String[] docText;
    private XmlWriter writer;
    public MeetingInfo(String fileText)
    {
        try
        {
            this.docText = System.IO.File.ReadAllText(@"C:/Users/ViktorAdrianMouton/Desktop/DigiVote/DocTest/" + fileText + ".txt").Split(' ');
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        this.meetingDocument = new XmlDocument();
        XmlWriterSettings settings = new XmlWriterSettings();
        settings.NewLineOnAttributes = true;
        settings.Indent = true;
        writer = XmlWriter.Create("C:/Users/ViktorAdrianMouton/Desktop/DigiVote/DocTest/truc.xml", settings);
    }

    public String[] getInfo()
    {
        //Every word is separated
        return this.docText;
    }

    public void putInXML()
    {
        writer.WriteStartElement("div");
        int i = 0;
        foreach (String word in this.docText)
        {
            writer.WriteElementString("element" + i, word);
            i++;
        }
        writer.WriteEndElement();
        writer.Flush();
    }
}