using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float duration;
    [SerializeField] Vector3 direction;

    private void Start()
    {
        Destroy(gameObject, duration);
    }

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
