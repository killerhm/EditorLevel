using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/*
[CustomEditor(typeof(Map))]
public class MapEditor : Editor {

    Map myTarget;
    public override void OnInspectorGUI()
    {

        myTarget  = (Map)target;
        GUI.DrawTexture(new Rect(0, 0, 50, 100), myTarget.blacnc);

        myTarget.sizeX = EditorGUILayout.IntField("X",myTarget.sizeX);
        myTarget.sizeZ = EditorGUILayout.IntField("Z",myTarget.sizeZ);
        myTarget.blacnc = (Texture)EditorGUILayout.ObjectField("blanc ", myTarget.blacnc, typeof(Texture), true);
        for (int i = 0; i < myTarget.sizeX; i++)
        {
            for (int z = 0; z < myTarget.sizeZ; z++)
            {
                GUI.DrawTexture(new Rect(10, 10, 10, 10), myTarget.blacnc);
            }
        }
    }
}
*/