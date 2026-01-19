using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class Greanade : Weapon
{
    [SerializeField] float throwPower;
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] Vector3 direction;
    [SerializeField] Vector3 startPosition;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        startPosition = rigidbody.position;
    }

    public override void Attack()
    {
        if ((rigidbody.useGravity == false))
        {
            rigidbody.useGravity = true;

            rigidbody.AddForce(direction.normalized * throwPower, ForceMode.Impulse);
        }

    }

    private void OnBecameInvisible()
    {
        rigidbody.useGravity = false;

        rigidbody.position = startPosition;

        rigidbody.linearVelocity = Vector3.zero;
    }
}
