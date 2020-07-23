using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float speed = 0.15f;
    public Transform player;
    float move;

    void Start()
    {
        player = GetComponent<Transform>();
    }

    void Update()
    {
        
        move = Input.GetAxis("Horizontal");
        //Формулу для руху і границі підглянув
        if (player.position.x < -8.26 && move < 0)
        {
            move = 0f;
        }
        else if (player.position.x > 8.26 && move > 0)
        {
            move = 0f;
        }

        player.position += Vector3.right * move * speed;
    }
}
