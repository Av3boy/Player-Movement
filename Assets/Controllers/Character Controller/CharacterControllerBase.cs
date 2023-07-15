using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public abstract class CharacterControllerBase: Base
{
    protected CharacterController controller;

    /// <inheritdoc />
    public override void Start()
    {
        base.Start();

        // Get reference to the CharacterController component
        controller = GetComponent<CharacterController>();
    }
}
