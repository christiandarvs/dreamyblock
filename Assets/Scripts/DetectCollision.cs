using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] MovementScript movementScript;
    [SerializeField] AudioSource gameMusic;
    [SerializeField] AudioSource collisionSound;
    private void OnCollisionEnter(Collision collision)
    {
 
        if (collision.collider.tag == "Zombie")
        {
            Debug.Log("You hit a zombie");
            movementScript.enabled = false;
            gameMusic.enabled = false;
            collisionSound.enabled = true;
            FindObjectOfType<GameManagerScript>().EndGame( );
  
        }
    }
}
