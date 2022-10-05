using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Debug.Log(horizontal);
        Debug.Log(vertical);
        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal * speed * Time.deltaTime;
        position.y = position.y + 0.1f * vertical * speed * Time.deltaTime;
        transform.position = position;
    }
}
