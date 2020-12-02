using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

[GenerateAuthoringComponent]
public struct SpawnCollectableComponent : IComponentData
{
    public int number;
    public Entity collectablePrefab;
}
