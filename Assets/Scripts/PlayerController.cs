using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;
    public GameObject colliderAttack; // GameObject used for attack collision detection

    float horizontal;
    float vertical;
    Rigidbody rb;
    Vector3 movement; // Va a almacenar la dirección del movimiento

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        InputPlayer();
        Attack();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        rb.MovePosition(transform.position + (movement * speed * Time.deltaTime));
    }

    //It will get the inputs and update the movement
    void InputPlayer()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        movement = new Vector3(horizontal, 0, vertical);
        movement.Normalize();
    }

    void Attack()
    {
        if(Input.GetMouseButtonDown(0) && horizontal == 0 && vertical == 0)
        {
            EnableColliderAttack();
            Invoke("DisableColliderAttack", 0.1f);
        }
    }

    // It will enable the collider that get attack collisions
    public void EnableColliderAttack()
    {
        colliderAttack.SetActive(true);
    }

    // It will enable the collider that get attack collisions
    void DisableColliderAttack()
    {
        colliderAttack.SetActive(false);
    }
}
