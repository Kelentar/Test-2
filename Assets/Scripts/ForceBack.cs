using UnityEngine;

public class ForceBack : MonoBehaviour
{
    public Transform gameobject;
   
    public void OnTriggerEnter2D(Collider2D col)
    { 
        if (col.CompareTag("Player"))
        {
            gameobject.transform.position += new Vector3(0f, 0.5f);
            Destroy(gameObject);
        }
        if (col.CompareTag("death"))
        {
            Destroy(gameObject);
        }
    }
}
