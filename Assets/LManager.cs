using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using Cinemachine;



public class LManager : MonoBehaviour {

    public static LManager instance;



    public Transform respawnPoint;

    public GameObject playerPrefab;



    public CinemachineVirtualCameraBase cam;



    private void Awake() {

        instance = this;

    }



    public void Respawn() {

        GameObject player = Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);

        cam.Follow = player.transform;

    }

}