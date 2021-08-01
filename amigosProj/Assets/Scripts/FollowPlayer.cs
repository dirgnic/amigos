using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform target;
    public float sTime = .3f;
    private Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(!target) return;
      Vector3 tPos = target.TransformPoint(new Vector3(0, 30, -100));
      transform.position = Vector3.SmoothDamp(transform.position, tPos, ref velocity, sTime);

    }
}
