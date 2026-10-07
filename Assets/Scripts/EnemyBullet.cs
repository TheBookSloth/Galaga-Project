using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    public float speed = 6;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * -transform.up * Time.deltaTime);

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}
