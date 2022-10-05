using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    [SerializeField] private float speed = 3.0f;
    [SerializeField] public int maxHealth = 5;
                     public int health { get { return currentHealth; }}
    [SerializeField] int currentHealth;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + 0.1f * horizontal * speed * Time.deltaTime;
        position.y = position.y + 0.1f * vertical * speed * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }

   public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
