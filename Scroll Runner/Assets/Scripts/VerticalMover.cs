using UnityEngine;

public class VerticalMover : MonoBehaviour
{

    [Header("설정")]
    public bool isVertical;
    public float speed;
    public float distance;
    [Tooltip("1 : 상||우 , -1 : 하||좌")]
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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }

    void MovePlatform()
    {
        if(isVertical) {
            float newY = transform.position.y + (direction * speed * Time.deltaTime);
            if (Mathf.Abs(newY - startPosition.y) >= distance)
            {
                direction *= -1;
                startPosition.y = newY;
            }
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }

        if(!isVertical) {
            float newX = transform.position.x + (direction * speed * Time.deltaTime);
            if (Mathf.Abs(newX - startPosition.x) >= distance)
            {
                direction *= -1;
                startPosition.x = newX;
            }
            transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        }

    }
}
