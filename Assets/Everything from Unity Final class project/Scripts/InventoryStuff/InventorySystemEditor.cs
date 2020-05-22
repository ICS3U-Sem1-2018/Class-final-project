using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(InventorySystem))]
public class InventorySystemEditor : Editor
{
    private bool[] showItemSlots = new bool[InventorySystem.size];
    private SerializedProperty itemsProperty;
    public bool[] size = new bool[InventorySystem.size];
    private const string inventoryPropItemsName = "items";
    private void OnEnable()
    {
        itemsProperty = serializedObject.FindProperty(inventoryPropItemsName);
    }
    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        for (int i = 0; i < InventorySystem.size; i++)
        {
            ItemSlotGUI(i);
        }
        serializedObject.ApplyModifiedProperties();
    }

    private void ItemSlotGUI(int index)
    {
EditorGUILayout.BeginVertical (GUI.skin.box);
        EditorGUI.indentLevel++;

        showItemSlots[index] = EditorGUILayout.Foldout(showItemSlots[index], "Item slot " + index);
        if (showItemSlots[index])
        {
            EditorGUILayout.PropertyField(itemsProperty.GetArrayElementAtIndex(index));
        }
        EditorGUI.indentLevel--;
        EditorGUILayout.EndVertical();
    }
}
