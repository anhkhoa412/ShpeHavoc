using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public int initChildCount, countOfChild, maxdestroyable, minDestroyable;

    private Transform objTransform;
    private int destroyable, destroyableIndex;
    // Start is called before the first frame update
    void Start()
    {
        objTransform = GetComponent<Transform>();
        initChildCount = countOfChild = objTransform.childCount;

        maxdestroyable = (int)countOfChild - countOfChild / 2;
        minDestroyable = (int)countOfChild / 2;

        destroyable = (int)Random.Range(minDestroyable, maxdestroyable + 1);

        PlayerManager.instance.amoCount = initChildCount - destroyable;
    }

    // Update is called once per frame
    void Update()
    {
        countOfChild = objTransform.childCount;

        if(countOfChild > (initChildCount - destroyable))
        {
            Destroy();
        }
    }
    private void Destroy()
    {
        destroyableIndex = Random.Range(0, countOfChild);

        Destroy(objTransform.GetChild(destroyableIndex).gameObject);
    }
}
