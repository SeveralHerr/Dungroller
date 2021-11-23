using UnityEngine;

public class Player : SingletonMonobehavior<Player> 
{
    public GameObject gameOverPrefab;

    public void DestroyPlayer()
    {
        var playerParts = GameObject.FindGameObjectsWithTag("PlayerParts");
        foreach (var item in playerParts)
        {
            Destroy(item.gameObject);
        }

        var playerGroup = GameObject.FindGameObjectsWithTag("Player");
        foreach (var item in playerGroup)
        {
            Destroy(item.gameObject);
        }

        DisplayGameOverScreen();
    }

    public bool HitPlayer(string tag)
    {
        return tag == "Player" || tag == "PlayerParts";
    }

    private void DisplayGameOverScreen()
    {
        gameOverPrefab.SetActive(true);
    }
}
