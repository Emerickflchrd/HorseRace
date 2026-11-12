using UnityEngine;

public class playermovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rbPlayer;
    [SerializeField] private float speed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rbPlayer.AddForce(0.0f, 0.0f, speed);
    }
}
