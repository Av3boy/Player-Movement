using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class RigidbodyBase : Base
{
    protected Rigidbody rb;

    /// <inheritdoc />
    public override void Start()
    {
        base.Start();

        rb = GetComponent<Rigidbody>();
    }
}
