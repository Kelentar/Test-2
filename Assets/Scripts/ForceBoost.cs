using UnityEngine;

public class ForceBoost : MonoBehaviour
{
    #region public
    public Rigidbody2D ball;
    public Rigidbody2D ball1;
    public Rigidbody2D ball2;
    public BoostSpawn boost;
    #endregion

    void Start()
    {
        if(boost.boost == true)
        {
            ball.AddForce(transform.up * -1f, ForceMode2D.Impulse);
            boost.boost = false;
        }
        else if (boost.boost1 == true)
        {
            ball1.AddForce(transform.up * -1f, ForceMode2D.Impulse);
            boost.boost1 = false;
        }
        else if (boost.boost2 == true)
        {
            ball2.AddForce(transform.up * -1f, ForceMode2D.Impulse);
            boost.boost2 = false;
        }
    }
}
