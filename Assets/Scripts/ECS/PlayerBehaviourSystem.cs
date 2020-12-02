using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

public class PlayerBehaviourSystem : SystemBase
{
    protected override void OnUpdate()
    {
       Entities.WithoutBurst().ForEach((ref PlayerComponent comp, ref Translation trans, ref Rotation rot) =>
       {
          comp.rotationAngle+=Input.GetAxis("Horizontal")/10;
          float3 targetDirection = new float3(math.sin(comp.rotationAngle), 0, math.cos(comp.rotationAngle));
          rot.Value = quaternion.LookRotationSafe(targetDirection/*forward*/, Vector3.up);
          trans.Value += targetDirection * comp.speed * Input.GetAxis("Vertical")/10;
       }).Run();
    }
}
