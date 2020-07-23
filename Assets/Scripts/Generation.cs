using UnityEngine;

public class Generation : MonoBehaviour
{
    #region public
    public Transform spawn;
    public Rigidbody2D ball;
    public float time;
    public float startTime;
    public bool arg;
    #endregion

    private Vector2 ballInitialForce;
    
    void Update()
    {
        //Таймер для генерації бомб
        //if (time < 0)
        //{
        //    time = startTime;
        //    Create();
        //    //transform.position += new Vector3(0f, -1f);
        //}
        //else
        //{
        //    time -= Time.deltaTime;
        //}

        //Генерація після знищення попередньої бомби
        GameObject ball = GameObject.Find("Ball");
        GameObject ball1 = GameObject.Find("Ball(Clone)");
        if (ball == null && ball1 == null)
        {
            Create();
        }
    }

    public void Create()
    {
        GameObject object_ = GameObject.Find("Ball(Clone)");
        if (object_ == null)
        {
            Instantiate(ball, spawn.position, Quaternion.identity);
        }
    }
}
