using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(StatsBase), true)]
public class StatsBaseEditor : Editor
{




    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();


        GUILayout.Space(10);
        GUIStyle richTextStyle = new GUIStyle();
        richTextStyle.richText = true;
        StatsBase SB = (StatsBase)target;

        GUILayout.Label("General", EditorStyles.boldLabel);

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Puntos de vida", GUILayout.Width(100));
        SB.health = EditorGUILayout.IntSlider(SB.health, 0, serializedObject.FindProperty("maxHealthPoints").intValue);
        EditorGUILayout.EndHorizontal();


        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Armadura", GUILayout.Width(100));
        SB.armor = EditorGUILayout.IntSlider(SB.armor, 0, serializedObject.FindProperty("maxArmorPoints").intValue);
        EditorGUILayout.EndHorizontal();


        GUILayout.Space(10);
        GUILayout.Label("FIDVAR", EditorStyles.boldLabel);

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Fuerza", GUILayout.Width(100));
        SB.strength = EditorGUILayout.IntSlider(SB.strength, 0, serializedObject.FindProperty("maxStatsPoints").intValue);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Inteligencia", GUILayout.Width(100));
        SB.intelligence = EditorGUILayout.IntSlider(SB.intelligence, 0, serializedObject.FindProperty("maxStatsPoints").intValue);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Destreza", GUILayout.Width(100));
        SB.dexterity = EditorGUILayout.IntSlider(SB.dexterity, 0, serializedObject.FindProperty("maxStatsPoints").intValue);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Versatilidad", GUILayout.Width(100));
        SB.versatility = EditorGUILayout.IntSlider(SB.versatility, 0, serializedObject.FindProperty("maxStatsPoints").intValue);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Astucia", GUILayout.Width(100));
        SB.cunning = EditorGUILayout.IntSlider(SB.cunning, 0, serializedObject.FindProperty("maxStatsPoints").intValue);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Resistencia", GUILayout.Width(100));
        SB.resistance = EditorGUILayout.IntSlider(SB.resistance, 0, serializedObject.FindProperty("maxStatsPoints").intValue);
        EditorGUILayout.EndHorizontal();

        GUILayout.Space(10);
        GUILayout.Label("Habilidades", EditorStyles.boldLabel);

        GUILayout.Label("Capacidad de inventario: <b>" + SB.invCapacity.ToString() + "</b>", richTextStyle);
        GUILayout.Label("Daño cuerpo a cuerpo: <b>" + SB.meleeDamage.ToString() + "</b>", richTextStyle);
        GUILayout.Label("Stamina: <b>" + SB.stamina.ToString() + "</b>", richTextStyle);
        GUILayout.Label("Punteria: <b>" + SB.accuracy.ToString() + "</b>", richTextStyle);
        GUILayout.Label("Velocidad de movimiento: <b>" + SB.speed.ToString() + "</b>", richTextStyle);
        GUILayout.Label("% Critico: <b>" + SB.critic.ToString() + "</b>", richTextStyle);
        GUILayout.Label("% Bonus Recursos: <b>" + SB.bonusResources.ToString() + "</b>", richTextStyle);
        GUILayout.Space(10);
    }
}