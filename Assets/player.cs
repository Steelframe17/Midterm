using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]
    float speed = 10; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Vector3 direction;
    Rigidbody2D RB2D;
    private void Start()
    {
        RB2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        direction = new(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        direction *= speed * Time.deltaTime;
        transform.Translate(direction);
    }
}
