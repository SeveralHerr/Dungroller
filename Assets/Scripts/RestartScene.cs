using UnityEngine.SceneManagement;
using UnityEngine;
public class RestartScene : MonoBehaviour
{
    public void Update()
    {
        if (Input.anyKeyDown)
        {
            Scene thisScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(thisScene.name);
        }
    }
}