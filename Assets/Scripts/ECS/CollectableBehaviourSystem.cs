using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public class CollectableBehaviourSystem : SystemBase
{
    static float3 rot1 = new float3(0,0,0);

    protected override void OnUpdate() {
        Entities.WithoutBurst().ForEach((CollectedComponent sphere, ref Rotation rot) => {
            rot1.x += 0.01f;
            rot.Value = quaternion.EulerXYZ(rot1);
        }).Run();
    }
}
