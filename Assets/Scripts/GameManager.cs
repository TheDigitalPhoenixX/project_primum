﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    [Tooltip("The Main Character of the game.")]
    private GameObject player = null;
    [SerializeField]
    [Tooltip("The nav mesh surface of the map.")]
    private NavMeshSurface surface = null;
    
    public List<GameObject>  Enemies { get; set; }

    private void Start()
    {
        Enemies = new List<GameObject>();
        Enemies.AddRange(GameObject.FindGameObjectsWithTag("enemy"));
    }
    private void OnEnable()
    {
        surface.BuildNavMesh();
        
    }

    /// <summary>
    /// gets the Player.
    /// </summary>
    /// <returns>the Gameobject of the player.</returns>
    public GameObject GetPlayer()
    {
        return player;
    }
}