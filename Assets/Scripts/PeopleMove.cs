using UnityEngine;

public class PeopleMove : MonoBehaviour
{
    public float score = 0.5f;
    public int lives = 3;
    public string name = "Bob";
    public bool gameover = false;

    public float speed;

    public Vector3 targetPosition;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Run Forever!");
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        if (score < 10)
        {
            Debug.Log("You are losing.");
        }
    }
}
