using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;


public class MapWindowEditor : EditorWindow {
    Map myTarget;
    static MapWindowEditor window;

    public int selGridInt = 0;
    private int lastgirdInt = 0;
    public bool ground;
    public bool wall;
    private int lastIndexTextures;
    [MenuItem("Window/My Window")]
    static void init ()
    {
        window = (MapWindowEditor)EditorWindow.GetWindow(typeof(MapWindowEditor));
        window.myTarget = FindObjectOfType<Map>();
        window.Show();
    }

    void OnGUI()
    {
        ground = EditorGUILayout.Toggle("Ground", ground);
        wall = EditorGUILayout.Toggle("Wall", wall);
        myTarget.sizeX = EditorGUILayout.IntField("SizeX", myTarget.sizeX);
        myTarget.sizeZ = EditorGUILayout.IntField("SizeZ", myTarget.sizeZ);
        int radius = 60;
        myTarget.skin.GetStyle("Button").fixedHeight = radius;
        myTarget.skin.GetStyle("Button").fixedWidth = radius;

        if (lastIndexTextures != myTarget.sizeZ)
        {
            if(lastIndexTextures < myTarget.sizeZ)
              myTarget.addNewTexture(1);
            else
                myTarget.addNewTexture(-1);

            lastIndexTextures = myTarget.sizeZ;
        }


        GUILayout.BeginVertical("Box");
        if (lastgirdInt != selGridInt)
        {
            lastgirdInt = selGridInt;
            Debug.Log(selGridInt);
                if(ground)
                myTarget.textures[selGridInt] = myTarget.groundTexture;
                else if (wall)
                myTarget.textures[selGridInt] = myTarget.wallTexture;

        }
        selGridInt = GUILayout.SelectionGrid(selGridInt,myTarget.textures.ToArray(), myTarget.sizeX,myTarget.skin.GetStyle("Button"),  GUILayout.Width(radius),GUILayout.Height(radius));
      //  Repaint();

        GUILayout.EndVertical();

        if (GUILayout.Button("CreateMap"))
        {
            myTarget.GenerateMap();
        }
    }



}

