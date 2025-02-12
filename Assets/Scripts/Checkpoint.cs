using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerRespawn>().ReachedCheckpoint(collision.transform.position.x, collision.transform.position.y, SceneManager.GetActiveScene().buildIndex);
        
            
            GetComponent<Animator>().enabled = true;        
        }
    }
}
