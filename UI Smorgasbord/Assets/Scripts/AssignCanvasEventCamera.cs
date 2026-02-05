using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignCanvasEventCamera : MonoBehaviour
{
    // This script automatically gives the Default Canvas prefab a reference to the scene's Main Camera
    void Start()
    {
        Canvas canvas = GetComponent<Canvas>();
        if(canvas && canvas.worldCamera == null)
        {
            canvas.worldCamera = Camera.main;
        }
    }
}
