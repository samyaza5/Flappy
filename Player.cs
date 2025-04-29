using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    Animation animator;
    Rigidbody2D _rigidbody;
    Collider2D collider2d;

    public float speed = 6f;
    public float forwardForce = 3f;
    public bool isDead = false;
    float deathCooldown = 0f; 

    bool isFlap = false;
    public float gadMod = 6f;
    void Start()
    {
        GetComponent<Rigidbody2D>();
        GetComponent<Collider2D>();
        GetComponent<Animation>();
        _rigidbody = GetComponent<Rigidbody2D>();
        collider2d = GetComponent<Collider2D>();
        animator = GetComponent<Animation>();

        
    }

    void Update()
    {
        
    }
}
