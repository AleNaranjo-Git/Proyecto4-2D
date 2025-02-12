using UnityEngine;

public class FruitCollected : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Destroy the fruit object when the player collides with it
            GetComponent<SpriteRenderer>().enabled = false;

            //Obtaine the object that is inside the fruit and enable it
            gameObject.transform.GetChild(0).gameObject.SetActive(true);

            // Destroy the fruit object after 1 second
            Destroy(gameObject, 0.5f);
        }
    }

}
