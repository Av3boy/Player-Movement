using UnityEngine;

public class TransformTranslate : Base
{
    /// <inheritdoc />
    public override void Update()
    {
        base.Update();

        transform.Translate(moveDirection * Time.deltaTime);
    }
}
