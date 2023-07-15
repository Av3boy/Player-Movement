public class CharacterControllerSimpleMove: CharacterControllerBase
{
    /// <inheritdoc />
    public override void Update()
    {
        base.Update();

        // TODO: Do we need to multiply by Time.deltaTime?
        controller.SimpleMove(moveDirection);
    }
}
