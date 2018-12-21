using UnityEngine;

public class FramerateManager : MonoBehaviour
{

    public int frameRate = 60;
    void Update()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = frameRate;
    }
}