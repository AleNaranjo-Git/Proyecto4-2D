using UnityEngine;

public class BulletPlant : MonoBehaviour
{
    public float speed = 2;
    public float lifeTime = 2;
    public bool left;
    
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        if (left)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}
