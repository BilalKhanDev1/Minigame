using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Vector2 jumpVelocity = Vector2.up;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<Rigidbody2D>().velocity = jumpVelocity;
        }
    }
}