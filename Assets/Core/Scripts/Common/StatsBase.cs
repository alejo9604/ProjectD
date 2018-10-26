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
    private Fidvar fidvar;

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

    public Fidvar Fidvar
    {
        get
        {
            return fidvar;
        }
    }
    public int strength
    {
        get
        {
            return fidvar.Strength;
        }
        set
        {
            fidvar.Strength = (value > maxStatsPoints) ? maxStatsPoints : value;
        }
    }
    public int intelligence
    {
        get
        {
            return fidvar.Intelligence;
        }
        set
        {
            fidvar.Intelligence = (value > maxStatsPoints) ? maxStatsPoints : value;
        }
    }
    public int dexterity
    {
        get
        {
            return fidvar.Dexterity;
        }
        set
        {
            fidvar.Dexterity = (value > maxStatsPoints) ? maxStatsPoints : value;
        }
    }
    public int versatility
    {
        get
        {
            return fidvar.Versatility;
        }
        set
        {
            fidvar.Versatility  = (value > maxStatsPoints) ? maxStatsPoints : value;
        }
    }
    public int cunning
    {
        get
        {
            return fidvar.Cunning;
        }
        set
        {
            fidvar.Cunning = (value > maxStatsPoints) ? maxStatsPoints : value;
        }
    }
    public int resistance
    {
        get
        {
            return fidvar.Resistance;
        }
        set
        {
            fidvar.Resistance = (value > maxStatsPoints) ? maxStatsPoints : value;
        }
    }


    public int invCapacity
    {
        get
        {
            return baseInventoryCapacity + (int)Mathf.CeilToInt((strength + resistance) / 2);
        }
    }
    public int meleeDamage
    {
        get
        {
            return baseMeleeDamage + (int)Mathf.CeilToInt(strength / 2);
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
            return baseAccuracy + (int)Mathf.CeilToInt((dexterity + cunning) / 2);
        }
    }
    public float speed
    {
        get
        {
            float val = baseSpeed + ((dexterity + versatility) / 6f);
            return (float)System.Math.Round(val, 2);
        }
    }
    public float critic
    {
        get
        {
            return baseCritic + (int)Mathf.CeilToInt((intelligence + versatility) / 2);
        }
    }
    public float bonusResources
    {
        get
        {
            return baseBonusResources + (int)Mathf.CeilToInt((intelligence + cunning) / 2);
        }
    }

    #endregion PUBLIC_FIELDS

    #region PUBLIC_FUNCTIONS


    #endregion PUBLIC_FUNCTIONS
}