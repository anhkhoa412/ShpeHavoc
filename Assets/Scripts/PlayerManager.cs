using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
   public static PlayerManager instance;
    [SerializeField] private GameObject[] playerPrefab;
    public int amoCount = 0;

    public int score = 0;

    private void Awake()
    {
        instance = this; 
    }

    public void AddNewPlayer()
    {
      
            if (score < 14) {
            Instantiate(playerPrefab[0], transform.position, Quaternion.identity);
            } else
        {
            Instantiate(playerPrefab[1], transform.position, Quaternion.identity);
        }
        }
    }

