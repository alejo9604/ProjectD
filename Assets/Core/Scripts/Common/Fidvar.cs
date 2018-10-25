using UnityEngine;

[System.Serializable]
public class Fidvar {

    #region PRIVATE_FIELDS
    [SerializeField]
    private int strength; //Fuerza
    [SerializeField]
    private int intelligence; //Inteligencia
    [SerializeField]
    private int dexterity; //Destreza
    [SerializeField]
    private int versatility; //Versatilidad
    [SerializeField]
    private int cunning; //Astucia
    [SerializeField]
    private int resistance; //Resistencia

    #endregion PRIVATE_FIELDS

    #region PUBLIC_FIELDS
    public int Strength
    {
        get
        {
            return strength;
        }

        set
        {
            strength = value;
        }
    }

    public int Intelligence
    {
        get
        {
            return intelligence;
        }

        set
        {
            intelligence = value;
        }
    }

    public int Dexterity
    {
        get
        {
            return dexterity;
        }

        set
        {
            dexterity = value;
        }
    }

    public int Versatility
    {
        get
        {
            return versatility;
        }

        set
        {
            versatility = value;
        }
    }

    public int Cunning
    {
        get
        {
            return cunning;
        }

        set
        {
            cunning = value;
        }
    }

    public int Resistance
    {
        get
        {
            return resistance;
        }

        set
        {
            resistance = value;
        }
    }

    #endregion PUBLIC_FIELDS

    #region OPERATORS
    public static bool operator > (Fidvar a, Fidvar b)
    {
        return a.Strength > b.Strength &&
            a.Intelligence > b.Intelligence &&
            a.Dexterity > b.Dexterity &&
            a.Versatility > b.Versatility &&
            a.Cunning > b.Cunning &&
            a.Resistance > b.Resistance;
    }

    public static bool operator <(Fidvar a, Fidvar b)
    {
        return a.Strength < b.Strength &&
            a.Intelligence < b.Intelligence &&
            a.Dexterity < b.Dexterity &&
            a.Versatility < b.Versatility &&
            a.Cunning < b.Cunning &&
            a.Resistance < b.Resistance;
    }

    public static bool operator >=(Fidvar a, Fidvar b)
    {
        return a.Strength >= b.Strength &&
            a.Intelligence >= b.Intelligence &&
            a.Dexterity >= b.Dexterity &&
            a.Versatility >= b.Versatility &&
            a.Cunning >= b.Cunning &&
            a.Resistance >= b.Resistance;
    }

    public static bool operator <=(Fidvar a, Fidvar b)
    {
        return a.Strength <= b.Strength &&
            a.Intelligence <= b.Intelligence &&
            a.Dexterity <= b.Dexterity &&
            a.Versatility <= b.Versatility &&
            a.Cunning <= b.Cunning &&
            a.Resistance <= b.Resistance;
    }
    #endregion OPERATORS
}
