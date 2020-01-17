using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class XMLManager
{
    static string FilePath = "XML/";

    void Update()
    {

    }

    public static XmlDocument LoadXML(string fileName)
    {
        TextAsset txtAsset = (TextAsset)Resources.Load(FilePath + fileName);
        XmlDocument xmlDoc = new XmlDocument();
        Debug.Log(txtAsset.text);
        xmlDoc.LoadXml(txtAsset.text);

        //XmlNodeList costTable = xmlDoc.GetElementsByTagName("cost");

        //foreach (XmlNode cost in costTable)
        //{
        //    Debug.Log("[one by one] cost : " + cost.InnerText);
        //}

        //XmlNodeList allNodes = xmlDoc.SelectNodes("dataroot/TestItem");

        //foreach (XmlNode node in allNodes)
        //{
        //    Debug.Log("[at once] id :" + node.SelectSingleNode("id").InnerText);
        //    Debug.Log("[at once] name : " + node.SelectSingleNode("name").InnerText);
        //    Debug.Log("[at once] cost : " + node.SelectSingleNode("cost").InnerText);
        //}

        return xmlDoc;
    }
}