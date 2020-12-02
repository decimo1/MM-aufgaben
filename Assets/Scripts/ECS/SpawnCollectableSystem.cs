using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

public class SpawnCollectableSystem : SystemBase
{
    public BeginInitializationEntityCommandBufferSystem cmdBuffSys;

    protected override void OnCreate(){
      cmdBuffSys = World.GetOrCreateSystem<BeginInitializationEntityCommandBufferSystem>();
    }

    protected override void OnUpdate()
    {
      var cmdBuff = cmdBuffSys.CreateCommandBuffer();
      Entities.WithoutBurst().ForEach((Entity entity, in SpawnCollectableComponent comp) =>
      {
          for (int i=0; i<comp.number; i++) {
              Entity sphere = cmdBuff.Instantiate(comp.collectablePrefab);
              cmdBuff.SetComponent(sphere, new Translation{ Value = new float3(UnityEngine.Random.Range(-5,5),1,UnityEngine.Random.Range(-5,5))});
          }
          cmdBuff.DestroyEntity(entity);
      }).Run();

      cmdBuffSys.AddJobHandleForProducer(Dependency);
    }
}
