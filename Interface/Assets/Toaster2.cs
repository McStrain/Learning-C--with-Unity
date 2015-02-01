using UnityEngine;
using System.Collections;

public class Toaster2 : IThing2 
{
    private string ToasterName;
    public string ThingName
    {
        get
        {
            return ToasterName;
        }
        set
        {
            ToasterName = value;
        }
        //keyword value is specific to the accessor
    }   
}
