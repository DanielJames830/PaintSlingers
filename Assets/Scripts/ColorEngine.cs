using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ColorEngine
{
    public static Dictionary<string, Color32> dyes = new Dictionary<string, Color32>() 
    {
        {"White", new Color32(255,255,255,255)},
        {"Black", new Color32(0,0,0,255)},
        {"Red", new Color32(255,0,0,255)},
        {"Blue", new Color32(0,0,255,255)},
        {"Green", new Color32(0,255,0,255)},
        {"Yellow", new Color32(255,255,0,255)}
    };



    public static Color GenerateNewColor()
    {
        Color order = new Color(0,0,0,255);
        System.Random rand = new System.Random();
        for (int i = 0; i < 10; i++)
        {
            
            order += (Color)dyes.ElementAt(rand.Next(0, dyes.Count)).Value/10;
        }
        Debug.Log($"Color: Red:{order.r}, Green:{order.g}, Blue:{order.b}");
        return order;
    }




}
