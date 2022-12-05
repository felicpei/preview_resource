﻿using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using DG.Tweening;
using UI;
using Unity.Entities;
using Random = UnityEngine.Random;

public class Mission : SceneBase
{
    public override IEnumerator Init()
    {
        yield return base.Init();
        UIDebugMission.Show();
        CameraHelper.OnEnterMission();
        //CameraHelper.SetCameraPosition(new Vector3(-50, 100, -300));
    }

    public override void OnLeave()
    {
       // DestroyAllEntitiesInScene();
        CameraHelper.OnExitMission();
        base.OnLeave();
    }
    
    /*private void DestroyAllEntitiesInScene()
    {
        var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        var entities = entityManager.GetAllEntities();
        entityManager.DestroyEntity(entities);
        entities.Dispose();
    }*/
}