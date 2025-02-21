using UnityEngine;

public class VerticalMover : MonoBehaviour
{

    [Header("설정")]
    public float speed;
    public float distance;
    [Tooltip("1 위로, -1 아래")]
    public int direction;

    private Vector3 startPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlatform();
    }

     void MovePlatform()
    {
        float newY = transform.position.y + (direction * speed * Time.deltaTime);

        if (Mathf.Abs(newY - startPosition.y) >= distance)
        {
            direction *= -1;
            startPosition.y = newY;
        }

        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
