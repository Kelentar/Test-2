using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float time;
    public float startTime;
    public Rigidbody2D rb;

    private float movementSpeed = 5f;
    private Vector2 vec;
    
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        if(time < 0)
        {
            time = startTime;
            transform.position += new Vector3(0f, -0.25f);
        }
        else
        {
            time -= Time.deltaTime;
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        PlayerHealth health = col.GetComponent<PlayerHealth>();
        if (health != null)
        {
            health.Damage(10);
        }
    }
}
