public class RigidbodyAddForce : RigidbodyBase
{
    /// <inheritdoc />
    public override void Update()
    {
        base.Update();

        rb.AddForce(moveDirection);
    }
}
