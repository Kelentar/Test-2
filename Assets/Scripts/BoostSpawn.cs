using UnityEngine;

public class BoostSpawn : MonoBehaviour
{
    #region public
    public Rigidbody2D ball;
    public Rigidbody2D ball1;
    public Rigidbody2D ball2;

    public Transform spawn;

    public float time;
    public float startTime;

    public bool boost2;
    public bool boost1;
    public bool boost;
    #endregion

    void Update()
    {
        if (time < 0)
        {
            time = startTime;
            
            switch (Random.Range(0, 3))
            {
                case 2:
                    Create2(); 
                    break;
                case 1:
                    Create1();
                    break;
                case 0:
                    Create();
                    break;
                default:
                    break;
            }
        }
        else
        {
            time -= Time.deltaTime;
        }
    }

    public void Create()
    {
        Instantiate(ball, spawn.position, Quaternion.identity);
        boost = true;
    }
    public void Create1()
    {
        Instantiate(ball1, spawn.position, Quaternion.identity);
        boost1 = true;

    }
    public void Create2()
    {
        Instantiate(ball2, spawn.position, Quaternion.identity);
        boost2 = true;
    }
}

