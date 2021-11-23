using UnityEngine;

public class Player : SingletonMonobehavior<Player> 
{
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
    }

    public bool HitPlayer(string tag)
    {
        return tag == "Player" || tag == "PlayerParts";
    }
}
