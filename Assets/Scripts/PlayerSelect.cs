using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    public bool enableSelectCharacter;

    public enum Player { NinjaFrog, VirtualGuy, PinkMan, MaskDude }
    public Player playerSelected;

    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public RuntimeAnimatorController[] playerController;
    public Sprite[] playerRender;

    void Start()
    {

        if (enableSelectCharacter)
        {
            ChangePlayerInMenu();
        }
        else
        {
            switch(playerSelected)
        {
            case Player.NinjaFrog:
                spriteRenderer.sprite = playerRender[0];
                animator.runtimeAnimatorController = playerController[0];
                break;
            case Player.VirtualGuy:
                spriteRenderer.sprite = playerRender[1];
                animator.runtimeAnimatorController = playerController[1];
                break;
            case Player.PinkMan:
                spriteRenderer.sprite = playerRender[2];
                animator.runtimeAnimatorController = playerController[2];
                break;
            case Player.MaskDude:
                spriteRenderer.sprite = playerRender[3];
                animator.runtimeAnimatorController = playerController[3];
                break;
            default:
                break;
        }
        }
        
    }

    public void ChangePlayerInMenu()
    {
        switch (PlayerPrefs.GetString("PlayerSelected"))
        {
            case "Frog":
                spriteRenderer.sprite = playerRender[0];
                animator.runtimeAnimatorController = playerController[0];
                break;
            case "Virtual":
                spriteRenderer.sprite = playerRender[1];
                animator.runtimeAnimatorController = playerController[1];
                break;
            case "Pink":
                spriteRenderer.sprite = playerRender[2];
                animator.runtimeAnimatorController = playerController[2];
                break;
            case "Mask":
                spriteRenderer.sprite = playerRender[3];
                animator.runtimeAnimatorController = playerController[3];
                break;
            default:
                break;
        }
    }
}
