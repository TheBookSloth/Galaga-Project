using Unity.VisualScripting;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float speed = 2;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * -transform.up * Time.deltaTime);

        if (transform.position.y < -16)
            transform.position = new Vector3(transform.position.x, transform.position.y + 16f, transform.position.z);
    }
}
