using UnityEngine;

public class Impuls : MonoBehaviour
{
    #region public
    public GameObject colon;
    public Transform player;
    public Rigidbody2D rb;

    public Animator anim;
    public Generation rf;

    public int count = 0;
    public int damage;
    public int damage1 = 1;
    public int count1 = 3;
    #endregion

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        if (rf.arg == true)
        {
            Physics2D.IgnoreLayerCollision(11, 10, true); 
            rb.AddForce(player.position * 0.5f, ForceMode2D.Impulse);
        }
        Physics2D.IgnoreLayerCollision(11, 10, true);
    }

    public void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump") == true)
        {
            rf.arg = true;
            Destroy(gameObject);
        }
        if (count >= 2 || count1 <= 1)
        {
            damage = 2;
            anim.SetBool("Bool", true);
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            count++;
            Physics2D.IgnoreLayerCollision(11, 10, false); 
        }

        if (col.CompareTag("Enemy"))
        {
            count1--;
        }

        if ((count >= 2 || count1 <= 0) && col.CompareTag("Enemy") )
        {
            colon.SetActive(true);
            Destroy(gameObject, 0.06f);
        }
   
        HealthEnemy health = col.GetComponent<HealthEnemy>();
        if(health != null)
        {
            health.Damage(damage);
        }
        PlayerHealth health1 = col.GetComponent<PlayerHealth>();
        if (health1 != null)
        {
            health1.Damage(1);
            Destroy(gameObject);
        }
    } 
}
