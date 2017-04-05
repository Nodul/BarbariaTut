using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHPManager : MonoBehaviour {

    public int MaxHP;
    public int CurrentHP;
    public int ExpValue;

    private PlayerStats _playerStats;


    // Use this for initialization
    void Start()
    {
        CurrentHP = MaxHP;
        _playerStats = FindObjectOfType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHP <= 0)
        {
            Destroy(gameObject);
            _playerStats.AddExperience(ExpValue);
        }

    }

    public void HurtEnemy(int damage)
    {
        CurrentHP -= damage;
    }
    public void SetMaxHealth()
    {
        CurrentHP = MaxHP;
    }

}
