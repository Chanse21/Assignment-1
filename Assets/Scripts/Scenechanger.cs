using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechanger : MonoBehaviour
{
    public void LoadLevelScene()
    {
        SceneManager.LoadScene("Level 1");
    }
}