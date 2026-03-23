using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField]
    GameObject FinishLine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {

        {
            gameObject.SetActive(false);
            FinishLine.SetActive(true);
        }
    }
}