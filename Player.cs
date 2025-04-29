using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    Animator animator;
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
        _rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();

       if(animator == null)
        {
            Debug.LogError("Animator not found in children.");
        }
       if (_rigidbody == null)
        {
            Debug.LogError("Rigidbody2D not found.");
        }
    }

    void Update()
    {
        if (isDead)
        {
      
            if (deathCooldown <= 0f)
            {
                Destroy(gameObject);
            }
            else
            {
                deathCooldown -= Time.deltaTime;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonUp(0))
            {
                isFlap = true;
            }

        }
    }

    private void FixedUpdate()
    {
        if (isDead) return;
        {
            Vector3 velocity = _rigidbody.linearVelocity;
            velocity.x = forwardForce;

            if (isFlap)
            {
                velocity.x = forwardForce;
                velocity.y += speed;
                isFlap = false;
            }


            _rigidbody.linearVelocity = velocity;

            float angle = Mathf.Clamp((velocity.y * 10f), -90, 90);
            transform.rotation = Quaternion.Euler(0, 0, angle);

        } 
    }
        
        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDead) return;
        isDead = true;
        deathCooldown = 1f;

        animator.SetInteger("Die",1);

    }

}

