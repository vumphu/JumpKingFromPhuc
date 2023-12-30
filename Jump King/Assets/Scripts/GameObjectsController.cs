using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectsController : MonoBehaviour
{
    [SerializeField] public string newArea;
    [SerializeField] public string currentArea;
    private void Update() {
        if(newArea != currentArea)
        {
            currentArea = newArea;
            Debug.Log(currentArea);
        }
    }

}
