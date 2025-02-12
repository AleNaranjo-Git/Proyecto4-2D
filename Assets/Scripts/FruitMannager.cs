using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitMannager : MonoBehaviour
{

    public Text fruitText;
    int TotalFruit;
    public Text levelClearedText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TotalFruit = gameObject.transform.childCount;
        FuitCount();
    }

    // Update is called once per frame
    void Update()
    {
        FuitCount();
    }

    public void FuitCount()
    {
        // Get the number of fruits that are inside the parent object
        int count = gameObject.transform.childCount;

        // Update the text with the number of fruits that are inside the parent object
        fruitText.text = "Collected Fruits: " + (TotalFruit - count) + "/" + TotalFruit;
        if (count == 0)
        {

            // Display the level cleared text
            levelClearedText.gameObject.SetActive(true);

            // Load the next scene after 2 seconds
            Invoke("ChangeScene", 2);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
