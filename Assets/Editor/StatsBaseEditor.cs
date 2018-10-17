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

        StatsBase SB = target as StatsBase;

        GUILayout.Label("General", EditorStyles.boldLabel);

        SB.health = EditorGUILayout.IntField("Puntos de vida", SB.health);
        SB.armor = EditorGUILayout.IntField("Armadura", SB.armor);

        GUILayout.Space(10);
        GUILayout.Label("FIDVAR", EditorStyles.boldLabel);

        SB.strength = EditorGUILayout.IntField("Fuerza", SB.strength);
        SB.intelligence = EditorGUILayout.IntField("Inteligencia", SB.intelligence);
        SB.dexterity = EditorGUILayout.IntField("Destreza", SB.dexterity);
        SB.versatility = EditorGUILayout.IntField("Versatilidad", SB.versatility);
        SB.cunnning = EditorGUILayout.IntField("Astucia", SB.cunnning);
        SB.resistance = EditorGUILayout.IntField("Resistencia", SB.resistance);

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