using System;
using UnityEngine;


public class WarriorService : InterfaceEnemy
{
    public int health;
    public float speed;
    public Vector2 movement;

    public LayerMask _whatIsSolid;
    private float _radiusRaucast = 0.5f;
    private float _distance = 1f;
    public void SetSettingsEnemy()
    {
        var userChoose = Resources.Load<SetDifficaltSettings>("");
        var enemyChoseSets = Resources.LoadAll<EnemySettingsDifficalt>("EnemySettings");
        foreach(var enemy in enemyChoseSets)
        {
            if(userChoose.UserChooseDifficalt == enemy.id)
            {
                health = enemy.health;
                speed = enemy.spead;
                _whatIsSolid.value = enemy.whatIsSolid;
                break;
            }
        }
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
        movement = plaerPos - enemyPos;
    }
}
