using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Canvas LevelComplete;
    public Canvas GameOver;
    public Canvas Hub;

    public void OpenLevelComplete()
    {
        LevelComplete.gameObject.SetActive(true);
        Hub.gameObject.SetActive(false);
    }

    public void OpenGameOver()
    {
        GameOver.gameObject.SetActive(true);
        Hub.gameObject.SetActive(false);
    }

    public void OpenHub()
    {
        LevelComplete.gameObject.SetActive(false);
        GameOver.gameObject.SetActive(false);
        Hub.gameObject.SetActive(true);
    }
}
