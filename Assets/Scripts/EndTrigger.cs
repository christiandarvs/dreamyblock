using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameManagerScript gameManager;
    private void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteGame();
    }
}
