using UnityEngine;

public class FrameRate : MonoBehaviour
{
    void Start()
    {
        // Set the target frame rate to 60 FPS.
        Application.targetFrameRate = 60;

        // Make this GameObject persist across scene changes.
        DontDestroyOnLoad(this.gameObject);
    }
}
