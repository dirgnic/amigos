using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using Cinemachine;

public class Network : MonoBehaviourPunCallbacks
{
  //  public CinemachineFreeLook freeLook;
  //  GameObject camObj;
  //  CinemachineComposer comp;
    public  FollowPlayer cam;
    // Start is called before the first frame update
    private void Start()
    {
//      camObj = GameObject.FindWithTag("MainCamera");

  //    freeLook = camObj.GetComponent<CinemachineFreeLook>();


        Debug.Log("Connecting");
        PhotonNetwork.NickName = "Player" + Random.Range(0, 5000);
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
      Debug.Log("Connected to Master. Joining your room.");
      PhotonNetwork.JoinOrCreateRoom("Room" + Random.Range(0, 5000), new RoomOptions() {MaxPlayers = 10}, null);
    }
    // Update is called once per frame
    public override void OnJoinedRoom()
    {
      Debug.Log("Connected");
      //  comp.TrackedObject
      Vector3 position = new Vector3(
         23049, 200, Random.Range(-7318, 17494));
    //PhotonNetwork.Instantiate("Player", position, Quaternion.identity).transform;
    // freeLook.Follow =
     cam.target = PhotonNetwork.Instantiate("Player", position, Quaternion.identity).transform;
    }

}
