using UnityEngine;

public class ArmoredShip : MonoBehaviour
{

    private float speed = 0.75f;
    private float bulletSpeedMultiplier = 1.5f; //was 2f

    private bool hasArmor = true;

    private Color armorColor;

    public GameObject bullet;
    public GameObject explosion;

    void Start()
    {
        armorColor = new Color(0.2f, 0.7f, 1f);
        transform.GetComponent<SpriteRenderer>().color = armorColor;
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
            


            if (hasArmor == false || collision.gameObject.CompareTag("GalagaPlayer"))
            {
                Destroy(gameObject);
            }
            else
            {
                transform.GetComponent<SpriteRenderer>().color = Color.white;
                hasArmor = false;
            }
        }
    }
}
