using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float moveSpeed;

    private Vector3 nextPos;
    private bool moveUpSpeed;
   // public SpawnManager spawnManager;

    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.instance.amoCount < 1 && (!moveUpSpeed))
        {
            moveUpSpeed = true;
            moveSpeed = 50f;
        }
        if (PlayerManager.instance.score > 30)
        {
            moveSpeed = 65f;
        }

        nextPos = transform.position;
        nextPos.z -= moveSpeed * Time.deltaTime;
        transform.position = nextPos;   

        if(transform.position.z <= -10f)
        {
            Destroy(gameObject);
            FindObjectOfType<SpawnManager>().Spawn();
            Destroy(GameObject.FindGameObjectWithTag("Player").gameObject);
        }
    }
}
