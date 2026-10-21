using UnityEngine;

public class ArmoredShip : MonoBehaviour
{

    private float speed = 1;
    private float bulletSpeedMultiplier = 3f;
    
    private float maxArmor = 3;
    private float armorHealth;

    public GameObject bullet;
    public GameObject explosion;

    void Start()
    {
        armorHealth = maxArmor;
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * -transform.up * Time.deltaTime);

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet") || collision.gameObject.CompareTag("GalagaPlayer"))
        {
            if (collision.gameObject.CompareTag("PlayerBullet"))
            {
                GameObject spawnedBullet = Instantiate(bullet, transform.position - new Vector3(0, 0.5f, 0), Quaternion.identity);
                spawnedBullet.GetComponent<EnemyBullet>().speed *= bulletSpeedMultiplier;

                Destroy(collision.gameObject);
            }
            
            GameObject temp = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(temp, 1.0f);

            armorHealth--;

            if (armorHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
