using UnityEngine;
using UnityEngine.InputSystem;

public class AssignCameraAtRuntime : MonoBehaviour
{
    void Start()
    {
        var playerInput = GetComponent<PlayerInput>();
        if (playerInput != null && playerInput.camera == null)
        {
            Camera mainCam = Camera.main;
            if (mainCam != null)
            {
                playerInput.camera = mainCam;
            }
        }
    }
}
