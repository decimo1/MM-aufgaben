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
       Entities.ForEach((ref PlayerComponent comp, ref Translation trans, ref Rotation rot) =>
       {
          comp.rotationAngle+=Input.GetAxis("Horizontal");
          float3 targetDirection = new float3(math.sin(comp.rotationAngle), 0, math.cos(comp.rotationAngle));
          rot.value = quaternion.LookRotationSafe(targetDirection/*forward*/, comp.rotationAngle/*up*/);
       }).Schedule();
    }
}
