using System;
using System.Collections.Generic;
using UnityEngine;
public interface InterfaceEnemy
{
    
    
    public LayerMask _whatIsSolid{get;set;}
    private float _radiusRaucast => 0.5f;
    private float _distance => 1;
    public EnemySettingsDifficalt SetSettingsEnemy()
    {
        var enemysDefalts= new EnemySettingsDifficalt();
        var userChoose = Resources.Load<SetDifficaltSettings>("");
        var enemyChoseSets = Resources.LoadAll<EnemySettingsDifficalt>("EnemySettings");
        foreach(var enemy in enemyChoseSets)
        {
            if(userChoose.UserChooseDifficalt == enemy.id)
            {
                var enemysets = enemy;
                enemysDefalts = enemy;
                return (enemy);
                
            }
        }
        
        return enemysDefalts;
    }
    public int SetHealth(int Damage, int health)
    {
            return health -= Damage;
    }
    public void ChekRaycast(Vector3 transformPos, Vector3 transformUp, GameObject plaer)
    {
        RaycastHit2D hitInfo = Physics2D.CircleCast(transformPos, _radiusRaucast, transformUp, _distance, _whatIsSolid);
    }
    public virtual void movements(Vector2 plaerPos, Vector2 enemyPos)
    {
        Vector2 movement;
        movement = plaerPos - enemyPos;
    }
}

