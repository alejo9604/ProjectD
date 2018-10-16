using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsBase : MonoBehaviour
{

    #region PRIVATE_FIELDS

    private int baseHealth = 50; //Vida
    private int baseArmor = 20; // Armadura
    private int baseStrength = 5; //Fuerza
    private int baseIntelligence = 5; //Inteligencia
    private int baseDexterity = 5; //Destreza
    private int baseVersatility = 5; //Versatilidad
    private int baseCunning = 5; //Astucia
    private int baseResistance = 5; //Resistencia
    private int baseInventoryCapacity = 5; //Capacidad de inventario
    private int baseMeleeDamage = 5; //Daño cuerpo a cuerpo
    private int baseStamina = 10; //Stamina
    private float baseAccuracy = 1f; //Punteria
    private float baseSpeed = 5f; //Velocidad de movimiento
    private float baseCritic = 3f; //Probabilidad de Golpe critico
    private float baseBonusResources = 3f; //Probabilidad de bonus en recursos

    #endregion

    #region PUBLIC_FIELDS

    public int health
    {
        get
        {
            return baseHealth;
        }
        set
        {
            baseHealth = value;
        }
    }
    public int armor
    {
        get
        {
            return baseArmor;
        }
        set
        {
            baseArmor = value;
        }
    }
    public int strength
    {
        get
        {
            return baseStrength;
        }
        set
        {
            baseStrength = value;
        }
    }
    public int intelligence
    {
        get
        {
            return baseIntelligence;
        }
        set
        {
            baseIntelligence = value;
        }
    }
    public int dexterity
    {
        get
        {
            return baseDexterity;
        }
        set
        {
            baseDexterity = value;
        }
    }
    public int versatility
    {
        get
        {
            return baseVersatility;
        }
        set
        {
            baseVersatility = value;
        }
    }
    public int cunnning
    {
        get
        {
            return baseCunning;
        }
        set
        {
            baseCunning = value;
        }
    }
    public int resistance
    {
        get
        {
            return baseResistance;
        }
        set
        {
            baseResistance = value;
        }
    }
    public int invCapacity
    {
        get
        {
            //TODO Calculate Inventory capacity based on Strength and resistance
            int _capacity = baseInventoryCapacity;
            return _capacity;
        }
    }
    public int meleeDamage
    {
        get
        {
            //TODO calculate melee damage based on strenght
            int _meleeDamage = baseStrength;
            return _meleeDamage;
        }
    }
    public int stamina
    {
        get
        {
            //TODO calculate stamina based on resistance
            int _stamina = resistance;
            return _stamina;
        }
    }
    public float accurracy
    {
        get
        {
            //TODO Calculate Accuracy based on dexterity and cunning
            float _accurracy = baseAccuracy;
            return _accurracy;
        }
    }
    public float speed
    {
        get
        {
            //TODO Calculate Speed based on Dexterity and versatility
            float _speed = baseSpeed;
            return _speed;

        }
    }
    public float critic
    {
        get
        {
            //TODO Calculate Critic Chance based on intelligence and versatility
            float _critic = baseCritic;
            return _critic;
        }
    }
    public float bonusResources
    {
        get
        {
            //TODO Calculate bonus resources based on intrellicenge and cunning
            float _bonusResourses = baseBonusResources;
            return _bonusResourses;
        }
    }


    #endregion

    #region PRIVATE_FUCTIONS

    #endregion

    #region PUBLIC_FUNCTIONS

    #endregion

}
