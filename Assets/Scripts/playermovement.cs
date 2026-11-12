using UnityEngine;


public class playermovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rbPlayer;
    [SerializeField] private float speed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {

    }
    // Update is called once per frame
    void FixeUpdate()
    {
        rbPlayer.AddForce(0.0f, 0.0f, speed);
    }
}
