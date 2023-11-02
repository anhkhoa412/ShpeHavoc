using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacle;
    // Start is called before the first frame update
    void Awake()
    {
        Spawn();   
    }

    public void Spawn()
    {
        if (PlayerManager.instance.score < 14)
        {
            Instantiate(obstacle[0], transform.position, Quaternion.identity);
            PlayerManager.instance.AddNewPlayer();
        } else {
            Instantiate(obstacle[1], new Vector3 (transform.position.x + 1f, transform.position.y, transform.position.z), Quaternion.identity);
            PlayerManager.instance.AddNewPlayer();
        }
    }
}
