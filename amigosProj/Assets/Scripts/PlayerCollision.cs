using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    //  public PlayerMovement movement;
    [SerializeField]
    float eulerAngX;
    [SerializeField]
    float eulerAngY;
    [SerializeField]
    float eulerAngZ;

    //  public GameManager gm;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "taskTree")
        {
            Debug.Log("collisionHI");
            //    movement.enabled = false;
            // GetComponent<PlayerMovement>().enabled = false;
            //      FindObjectOfType<GameManager>().EndGame();
        //    eulerAngX = transform.localEulerAngles.x;
          //  eulerAngY = transform.localEulerAngles.y;
         //   eulerAngZ = transform.localEulerAngles.z;
         //  transform.Rotate(eulerAngX, -0.728f, eulerAngZ, Space.World);
            FindObjectOfType<GameManager>().onCollisioooon();
          //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
