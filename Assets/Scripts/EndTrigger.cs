using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] private GameManager gameManagerScript;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Debug.Log("Le joueur atteint la ligne d'arrivée");
            gameManagerScript.CompleteLevel();
        }
    }
}
