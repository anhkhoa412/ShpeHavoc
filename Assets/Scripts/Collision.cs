using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] private GameObject destroyEF;
    public bool canDestroy = false;

    private void OnMouseDown()
    {

        if (canDestroy && PlayerManager.instance.amoCount > 0)
        {
            //Debug.Log(gameObject.name);
            Destroy(Instantiate(destroyEF, transform.position, Quaternion.identity), 1f);
            Destroy(gameObject);
            PlayerManager.instance.amoCount--;

        }

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle") && canDestroy)
        {
            FindObjectOfType<CameraController>().OnGameover();
            FindObjectOfType<ObstacleMovement>().enabled = false;
        }
       else if (other.gameObject.CompareTag("Score"))
        {
            PlayerManager.instance.score++;
            FindObjectOfType<CameraController>().OnScore();
        } 

     
    }
}
