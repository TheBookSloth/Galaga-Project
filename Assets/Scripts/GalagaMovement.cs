using UnityEngine;

public class GalagaMovement : MonoBehaviour
{
    public float speed = 5;

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        horizontalMove();
        verticalMove();
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.25f, 8.25f), Mathf.Clamp(transform.position.y, -4, 4), 0);
    }

    void horizontalMove()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * transform.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(speed * -transform.right * Time.deltaTime);
        }
    }

    void verticalMove()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(speed * transform.up * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(speed * -transform.up * Time.deltaTime);
        }
    }
}
