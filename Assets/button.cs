using UnityEngine;

public class button : MonoBehaviour
{
    [SerializeField]
    GameObject Door;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
        Door.SetActive(false);
    }
}
