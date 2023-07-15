using UnityEngine;

public class Transform_position : Base
{
    public override void Update()
    {
        base.Update();

        transform.position += moveDirection * Time.deltaTime;
    }
}
