using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{  public GameObject task1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public Image[] liveArr;
//  public GameObject selector;
 //  [SerializeField]
    public int lives = 1;
    public void onCollisioooon()
  {
       if (lives < 5)
       {
           lives++;
           Debug.Log("There are " + lives + " left");
           var t = liveArr[lives].color;
           t.a = 255f;
           liveArr[lives].color = t;
           Debug.Log(t.a);
           task1.SetActive(true);

       }
    //   if(lives==5)
        //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
