using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{

    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

        if (PlayerPrefs.GetInt("SceneIndex") == SceneManager.GetActiveScene().buildIndex)
        {
            if (PlayerPrefs.GetFloat("CheckoPointX") != 0 && PlayerPrefs.GetFloat("CheckoPointY") != 0)
            {
                transform.position = new Vector2(PlayerPrefs.GetFloat("CheckoPointX"), PlayerPrefs.GetFloat("CheckoPointY"));
            }
        }
    }

    public void ReachedCheckpoint(float x, float y, int SceneIndex)
    {
        PlayerPrefs.SetFloat("CheckoPointX", x);
        PlayerPrefs.SetFloat("CheckoPointY", y);
        PlayerPrefs.SetInt("SceneIndex", SceneIndex);
    }

    public void PlayerDamaged()
    {
        animator.Play("Hit");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
