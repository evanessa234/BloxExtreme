using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    // this function will be called whenever an object collide with something
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; //disable the players movement .
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
