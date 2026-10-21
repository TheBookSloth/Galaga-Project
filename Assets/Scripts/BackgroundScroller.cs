using Unity.VisualScripting;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float speed = 2;
    public float minHeight = -5;
    public float loopHeight = 16;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * -transform.up * Time.deltaTime);

        if (transform.position.y < minHeight)
            transform.position = new Vector3(transform.position.x, loopHeight, transform.position.z);
    }
}
