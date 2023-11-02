using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

   public void OnScore()
    {
        anim.SetTrigger("Score");
    }

    public void OnGameover()
    {
        anim.SetBool("isGameOver", true);
    }

    public void OnRestart()
    {
        anim.SetBool("isGameOver", false);
    }

    public void CallGameOver()
    {
        FindObjectOfType<UIController>().GameOver();
    }
}
