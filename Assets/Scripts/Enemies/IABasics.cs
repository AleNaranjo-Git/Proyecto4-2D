using System.Collections;
using UnityEngine;

public class IABasics : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public float speed = 1;
    private float waitTime;
    public float startWaitTime = 2;
    private int i = 0;
    private Vector2 actualPos;

    public Transform[] moveSpots;

    void Start()
    {
        waitTime = startWaitTime;
    }

    
    void Update()
    {
        // Check if the enemy is moving to flip the sprite
        StartCoroutine(CheckEnemyMoving());

        // Move the enemy to the next position in the array
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[i].transform.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpots[i].transform.position) < 0.1f)
        {
            //verify if the enemy is in the last position of the array
            if (waitTime <= 0)
            {
                // Change the position to the next one in the array
                if(moveSpots[i] != moveSpots[moveSpots.Length - 1])
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
                waitTime = startWaitTime;
            }
            else
            {
                //counts the time to wait
                waitTime -= Time.deltaTime;
            }
        }
    }

    IEnumerator CheckEnemyMoving()
    {
        actualPos = transform.position;

        yield return new WaitForSeconds(1);

        if(transform.position.x > actualPos.x)
        {
            spriteRenderer.flipX = true;
        }
        else if(transform.position.x < actualPos.x)
        {
            spriteRenderer.flipX = false;
        }
    }
}
