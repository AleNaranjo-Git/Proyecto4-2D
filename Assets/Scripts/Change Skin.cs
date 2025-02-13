using UnityEngine;

public class ChangeSkin : MonoBehaviour
{
    public GameObject skinPannel;
    private bool inDoor = false;
    public GameObject player;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            skinPannel.gameObject.SetActive(true);
            inDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            skinPannel.gameObject.SetActive(false);
            inDoor = false;
        }
    }

    public void SetPlayerFrog()
    {
        PlayerPrefs.SetString("PlayerSelected", "Frog");
        ResetPlayerSkin();
    }

    public void SetPlayerMask()
    {
        PlayerPrefs.SetString("PlayerSelected", "Mask");
        ResetPlayerSkin();
    }

    public void SetPlayerPink()
    {
        PlayerPrefs.SetString("PlayerSelected", "Pink");
        ResetPlayerSkin();
    }

    public void SetPlayerVirtual()
    {
        PlayerPrefs.SetString("PlayerSelected", "Virtual");
        ResetPlayerSkin();
    }

    void ResetPlayerSkin()
    {
        skinPannel.gameObject.SetActive(false);
        player.GetComponent<PlayerSelect>().ChangePlayerInMenu();
    }
}
