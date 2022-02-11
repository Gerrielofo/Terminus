using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourPuzzle : MonoBehaviour
{
    public List<Color> colorList = new List<Color>();
    public List<Color> backupColors = new List<Color>();
    public List<Renderer> toColor = new List<Renderer>();


    private void Start()
    {
        for (int i = 0; i < colorList.Count; i++)
        {
            backupColors.Add(colorList[i]);
        }
    }
    public void Coret()
    {
        SetColors();
        colorList.Clear(); // Just to be sure.
        for (int i = 0; i < backupColors.Count; i++)
        {
            colorList.Add(backupColors[i]);
        } 
    }
    

    void SetColors()
    {
        for (int i = 0; i < toColor.Count; i++)
        {
            toColor[i].material.SetColor("_EmissionColor", SetNewColor());
        }
    }

    public Color SetNewColor()
    {
        int r = Random.Range(0, colorList.Count);
        Color pickedColor = colorList[r];
        colorList.RemoveAt(r);
        return pickedColor;
    }
    public void Bset()
    {
        Coret();
    }
}