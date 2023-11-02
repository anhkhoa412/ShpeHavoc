using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyManager : MonoBehaviour
{
    public static DestroyManager instance;
    public int numberOfDestroy = 2;

    public void Awake()
    {
        instance = this;    
    }


}
