using UnityEngine;
using Photon.Pun;

public class GameManager : MonoBehaviourPunCallbacks
{
    public string playerPrefabName = "PlayerArmature";

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined room! Spawning player...");

        PhotonNetwork.Instantiate(playerPrefabName, new Vector3(0, 1, 0), Quaternion.identity);
    }
}
