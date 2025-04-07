using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player=GameObject.FindGameObjectWithTag("Player");
    }
 /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player")
        {
            Destroy(player.gameObject);
        }
    }
    // Update is called once per frame
}
