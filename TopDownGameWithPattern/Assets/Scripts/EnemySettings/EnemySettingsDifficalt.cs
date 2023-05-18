using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "SettingsEnemyInfos", menuName ="GamePlay/SetsEnemy")]
public class EnemySettingsDifficalt : ScriptableObject
{
    [SerializeField] private string _id;
    [SerializeField] private int _spead;
    [SerializeField] private int _health;
    [SerializeField] private LayerMask _whatIsSolid;

    public string id => this._id;
    public int spead => this._spead;
    public int health => this._health;
    public LayerMask whatIsSolid => this._whatIsSolid;
}
