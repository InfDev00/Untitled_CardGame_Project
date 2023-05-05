using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Region_Class : MonoBehaviour
{
    List<string> Region_List = new List<string>() {"Water", "Wind", "Fire", "None"};
    private string Region;

    public void Set_Region(string region)
    {
        if(Region_List.Contains(region)==true)
        {
            this.Region = region;
        } else
        {
            this.Region = "None";
        }
    }

    public string Get_Region()
    {
        return Region;
    }

}