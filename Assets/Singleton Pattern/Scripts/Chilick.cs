using UnityEngine;

public class Chilick : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] Vector3 minScale = new Vector3(1, 1, 1);
    [SerializeField] Vector3 MaxScale = new Vector3(2, 2, 2);
    void Update()
    {
        if (GameManager.instance.State == false) return;

        float time = Mathf.PingPong(Time.time * speed,1.0f);

        transform.localScale = minScale + (MaxScale - minScale) * time;

    }
}
