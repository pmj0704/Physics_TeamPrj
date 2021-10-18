using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Electric : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.tag);
        if (collision.collider.tag == "Left")
        {
            //GameManager.Instance.PadeIn(animator);
            SceneManager.LoadScene(2);
        }
        else if (collision.collider.tag == "Right")
        {
            //GameManager.Instance.PadeIn(animator);
            SceneManager.LoadScene(2);
        }
        else
            return;
        
    }
}