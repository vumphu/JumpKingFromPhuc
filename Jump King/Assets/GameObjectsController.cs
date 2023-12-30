using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectsController : MonoBehaviour
{
    //Add this script onto the empty gameobject to control objects's state of game
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
