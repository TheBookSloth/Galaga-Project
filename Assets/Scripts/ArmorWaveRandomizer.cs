using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class ArmorWaveRandomizer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int spawnPoseChance = Random.Range(1, 4);
        float xPose;
        switch (spawnPoseChance)
        {
            case 1:
                xPose = -3;
                break;
            case 2:
                xPose = 3;
                break;
            default: //which is also when spawnPoseChange == 3
                xPose = 0;
                break;
        }

        transform.Translate(xPose, 0, 0);
    }
}
