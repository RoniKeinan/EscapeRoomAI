using UnityEngine;
using Cinemachine;
using Photon.Pun;

public class CameraFollowSetup : MonoBehaviourPunCallbacks
{
    public CinemachineVirtualCamera virtualCamera;

    void Start()
    {
        if (photonView.IsMine)
        {
            // Find the camera root (usually inside the player prefab)
            Transform cameraTarget = transform.Find("PlayerCameraRoot");

            if (cameraTarget != null && virtualCamera != null)
            {
                virtualCamera.Follow = cameraTarget;
                virtualCamera.LookAt = cameraTarget;
            }
        }
    }
}
