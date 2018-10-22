using UnityEngine;

public class StatsBase : MonoBehaviour
{
    #region PRIVATE_FIELDS
    [SerializeField]
    private int maxStatsPoints = 15;
    [SerializeField]
    private int maxArmorPoints = 100;
    [SerializeField]
    private int maxHealthPoints = 150;

    [SerializeField]
    private int baseHealth; //Vida
    [SerializeField]
    private int baseArmor; // Armadura
    [SerializeField]
    private int baseStrength; //Fuerza
    [SerializeField]
    private int baseIntelligence; //Inteligencia
    [SerializeField]
    private int baseDexterity; //Destreza
    [SerializeField]
    private int baseVersatility; //Versatilidad
    [SerializeField]
    private int baseCunning; //Astucia
    [SerializeField]
    private int baseResistance; //Resistencia

    [SerializeField]
    private int baseInventoryCapacity = 5; //Capacidad de inventario
    [SerializeField]
    private int baseMeleeDamage = 3; //Daño cuerpo a cuerpo
    [SerializeField]
    private int baseStamina = 15; //Stamina
    [SerializeField]
    private float baseAccuracy = 1f; //Punteria
    [SerializeField]
    private float baseSpeed = 5f; //Velocidad de movimiento
    [SerializeField]
    private float baseCritic = 1f; //Probabilidad de Golpe critico
    [SerializeField]
    private float baseBonusResources = 1f; //Probabilidad de bonus en recursos

    #endregion PRIVATE_FIELDS

    #region PUBLIC_FIELDS

    [SerializeField]
    public int health
    {
        get
        {
            return baseHealth;
        }
        set
        {
            baseHealth = (value > maxHealthPoints) ? maxHealthPoints : value; ;
        }
    }
    [SerializeField]
    public int armor
    {
        get
        {
            return baseArmor;
        }
        set
        {
            baseArmor = (value > maxArmorPoints) ? maxArmorPoints : value;
        }
    }
    [SerializeField]
    public int strength
    {
        get
        {
            return baseStrength;
        }
        set
        {
            baseStrength = (value > maxStatsPoints) ? maxStatsPoints : value;
        }
    }
    [SerializeField]
    public int intelligence
    {
        get
        {
            return baseIntelligence;
        }
        set
        {
            baseIntelligence = (value > maxStatsPoints) ? maxStatsPoints : value;
        }
    }
    [SerializeField]
    public int dexterity
    {
        get
        {
            return baseDexterity;
        }
        set
        {
            baseDexterity = (value > maxStatsPoints) ? maxStatsPoints : value;
        }
    }
    [SerializeField]
    public int versatility
    {
        get
        {
            return baseVersatility;
        }
        set
        {
            baseVersatility = (value > maxStatsPoints) ? maxStatsPoints : value;
        }
    }
    [SerializeField]
    public int cunnning
    {
        get
        {
            return baseCunning;
        }
        set
        {
            baseCunning = (value > maxStatsPoints) ? maxStatsPoints : value;
        }
    }
    [SerializeField]
    public int resistance
    {
        get
        {
            return baseResistance;
        }
        set
        {
            baseResistance = (value > maxStatsPoints) ? maxStatsPoints : value;
        }
    }
    [SerializeField]
    public int invCapacity
    {
        get
        {
            return baseInventoryCapacity + (int)Mathf.CeilToInt((baseStrength + baseResistance) / 2);
        }
    }
    [SerializeField]
    public int meleeDamage
    {
        get
        {
            return baseMeleeDamage + (int)Mathf.CeilToInt(baseStrength / 2);
        }
    }
    [SerializeField]
    public int stamina
    {
        get
        {
            return baseStamina + (int)Mathf.CeilToInt(resistance / 2);
        }
    }
    [SerializeField]
    public float accuracy
    {
        get
        {
            return baseAccuracy + (int)Mathf.CeilToInt((baseDexterity + baseCunning) / 2);
        }
    }
    [SerializeField]
    public float speed
    {
        get
        {
            float val = baseSpeed + ((baseDexterity + baseVersatility) / 6f);
            return (float)System.Math.Round(val, 2);
        }
    }
    [SerializeField]
    public float critic
    {
        get
        {
            return baseCritic + (int)Mathf.CeilToInt((intelligence + baseVersatility) / 2);
        }
    }
    [SerializeField]
    public float bonusResources
    {
        get
        {
            return baseBonusResources + (int)Mathf.CeilToInt((baseIntelligence + baseCunning) / 2);
        }
    }

    #endregion PUBLIC_FIELDS

    #region PUBLIC_FUNCTIONS


    #endregion PUBLIC_FUNCTIONS
}