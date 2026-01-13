using UnityEngine;

public class Berrion : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] float distance = 2.0f;
    [SerializeField] Vector3 direction = Vector3.right;

    [SerializeField] Vector3 initializePosition;

    private void Start()
    {
        initializePosition = transform.localPosition;
    }

    private void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1f);

        transform.localPosition = initializePosition + direction.normalized * distance *time;
    }
}
