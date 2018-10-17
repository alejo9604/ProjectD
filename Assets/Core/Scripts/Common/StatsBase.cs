using UnityEngine;

[ExecuteInEditMode]
public class StatsBase : MonoBehaviour
{
    #region PRIVATE_FIELDS

    private int baseHealth = 50; //Vida
    private int baseArmor = 20; // Armadura
    private int baseStrength; //Fuerza
    private int baseIntelligence; //Inteligencia
    private int baseDexterity; //Destreza
    private int baseVersatility; //Versatilidad
    private int baseCunning; //Astucia
    private int baseResistance; //Resistencia

    private int baseInventoryCapacity; //Capacidad de inventario
    private int baseMeleeDamage; //Daño cuerpo a cuerpo
    private int baseStamina; //Stamina
    private float baseAccuracy; //Punteria
    private float baseSpeed; //Velocidad de movimiento
    private float baseCritic; //Probabilidad de Golpe critico
    private float baseBonusResources; //Probabilidad de bonus en recursos

    #endregion PRIVATE_FIELDS

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
            return baseInventoryCapacity + (int)Mathf.CeilToInt((baseStrength + baseResistance) / 2);
        }
    }

    public int meleeDamage
    {
        get
        {
            return baseMeleeDamage + (int)Mathf.CeilToInt(baseStrength / 2);
        }
    }

    public int stamina
    {
        get
        {
            return baseStamina + (int)Mathf.CeilToInt(resistance / 2);
        }
    }

    public float accuracy
    {
        get
        {
            return baseAccuracy + (int)Mathf.CeilToInt((baseDexterity + baseCunning) / 2);
        }
    }

    public float speed
    {
        get
        {
            return baseSpeed + (int)Mathf.CeilToInt((baseDexterity + baseVersatility) / 2);
        }
    }

    public float critic
    {
        get
        {
            return baseCritic + (int)Mathf.CeilToInt((intelligence + baseVersatility) / 2);
        }
    }

    public float bonusResources
    {
        get
        {
            return baseBonusResources + (int)Mathf.CeilToInt((baseIntelligence + baseCunning) / 2);
        }
    }

    #endregion PUBLIC_FIELDS

    #region PUBLIC_FUNCTIONS

    [ContextMenu("Set Values")]
    public void SetBaseValues()
    {
        baseInventoryCapacity = 5;
        baseMeleeDamage = 5;
        baseStamina = 10;
        baseAccuracy = 5;
        baseSpeed = 5;
        baseCritic = 3;
        baseBonusResources = 0;
    }

    #endregion PUBLIC_FUNCTIONS
}