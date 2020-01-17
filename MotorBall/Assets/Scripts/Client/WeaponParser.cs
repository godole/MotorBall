using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class WeaponParser
{
    XmlDocument m_WeaponDocument;
    
    WeaponParser(string filename)
    {
        m_WeaponDocument = XMLManager.LoadXML(filename);
    }
}
