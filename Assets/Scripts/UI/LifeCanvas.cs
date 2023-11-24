using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCanvas : MonoBehaviour
{
    public Transform player;

    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = new Vector2(player.position.x, player.position.y + 0.8f);
            transform.rotation = Quaternion.identity;
        }
    }
}
