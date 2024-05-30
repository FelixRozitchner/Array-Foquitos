using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoquitoScript : MonoBehaviour
{
    public GameObject[] colors;
    public int currentLightIndex = -1;
    int vueltasLuces = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ActivateNextLight()
    {
        currentLightIndex++;
        vueltasLuces++;
        if (currentLightIndex >= colors.Length) //"Si te pasaste"
        {
            currentLightIndex = 0;//"Volve a 0"
        }
        DeactivateAllLights();
        colors[currentLightIndex].SetActive(true);//Va prendiendo el foquito indicado a partir de su indice de array
        if (vueltasLuces == 15)
        {
            ();
        }
    }

    public void ActivatePreviousLight()
    {
        currentLightIndex--;
        if (currentLightIndex < 0)
        {
            currentLightIndex = colors.Length - 1;
        }
        DeactivateAllLights();
        colors[currentLightIndex].SetActive(true);
    }

    void DeactivateAllLights()
    {
        for (int i = 0; i < colors.Length; i++)
        {
            colors[i].SetActive(false);
        }

    }

    public void ActivateRepeating(float t)
    {
        InvokeRepeating(nameof(ActivateNextLight), 0, t);

    } 

    public void DestroyAllLights()

    
}
