using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMovement : Photon.Pun.MonoBehaviourPun
{
    public Rigidbody rb;
    public float forwardForce = 5000f;
    public float sideForce = 200f;

    public bool stopR, stopL, stopD, stopT;
    RaycastHit rayHit = new RaycastHit();
    // Start is called before the first frame update
    //   void Start()
    //  {

    //}

    // Update is called once per frame
    void FixedUpdate()
    {

     //   stopR = Physics.Raycast(transform.position, Vector3.right, .67f);
     //   stopL = Physics.Raycast(transform.position, Vector3.left, .67f);
      //  stopT = Physics.Raycast(transform.position, Vector3.forward, .67f);
      //  stopD = Physics.Raycast(transform.position, Vector3.back, .67f);

     //   if (!stopT)
if(photonView.IsMine) {
         if (Input.GetKey(KeyCode.UpArrow))
         {
            rb.AddForce(0, 0, forwardForce);
         }
     //   if (!stopR)
            if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sideForce, 0, 0, ForceMode.VelocityChange);

        }
   //     if (!stopL)
            if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sideForce, 0, 0, ForceMode.VelocityChange);

        }
   //     if (!stopD)
            if (Input.GetKey(KeyCode.DownArrow))
           {

            rb.AddForce(0, 0, -forwardForce);

          }


        }

    }
}
