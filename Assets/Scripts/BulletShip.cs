using UnityEngine;

public class BulletShip : MonoBehaviour
{

    public float speed = 3;
    public GameObject bullet;

    public float bulletTimer = 0, bulletWait = 3;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * -transform.up * Time.deltaTime);

        bulletTimer += Time.deltaTime;
        if (bulletTimer > bulletWait)
        {
            bulletTimer = 0;
            Instantiate(bullet, transform.position - new Vector3(0, 0.5f, 0), Quaternion.identity);
        }

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}
