using UnityEngine;

public class CharacterControllerMove : CharacterControllerBase
{
    /// <inheritdoc />
    public override void Update()
    {
        base.Update();

        // TODO: Why is moveDirection multiplied by Time.deltaTime?
        controller.Move(moveDirection * Time.deltaTime);
    }
}
