using UnityEngine;

public class ScaleBigger : MonoBehaviour
{
    public GameObject gameobject;
   
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            gameobject.transform.localScale += new Vector3(1f, 0, 0);
            Destroy(gameObject);
        }
        if (col.CompareTag("death"))
        {
            Destroy(gameObject);
        }
    }
}
