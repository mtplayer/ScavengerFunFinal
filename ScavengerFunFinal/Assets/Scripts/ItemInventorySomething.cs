using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInventorySomething : MonoBehaviour
{
    public List<GameObject> images;

    private void Start()
    {
        foreach (GameObject image in images)
        {
            image.SetActive(true);
        }
    }
}
