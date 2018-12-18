using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;

public class CustomNetworkManager : NetworkManager {

    public Button characterChoiceOne;
    public Button characterChoiceTwo;
    public Button characterChoiceThree;

    public Canvas SelectCanvas;

    int prefabArray = 2;

	// Use this for initialization
	void Start () {
        characterChoiceOne.onClick.AddListener(delegate {CharacterPick(characterChoiceOne.name);});
        characterChoiceOne.onClick.AddListener(delegate { CharacterPick(characterChoiceTwo.name); });
        characterChoiceOne.onClick.AddListener(delegate { CharacterPick(characterChoiceThree.name); });
    }

    void CharacterPick(string charName)
    {
        switch (charName)
        {
            case "Capsule":
                prefabArray = 2;
                break;
            case "Cube":
                prefabArray = 3;
                break;
            case "Sphere":
                prefabArray = 4;
                break;
        }

        playerPrefab = spawnPrefabs[prefabArray];
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        IntegerMessage msg = new IntegerMessage(prefabArray);

        if (!clientLoadedScene)
        {
            ClientScene.Ready(conn);
            if (autoCreatePlayer)
            {
                ClientScene.AddPlayer(conn, 0, msg);
            }
        }
    }

    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId, NetworkReader extraMessageReader)
    {
        int id = 0;

        if(extraMessageReader != null)
        {
            IntegerMessage i = extraMessageReader.ReadMessage<IntegerMessage>();
            id = i.value;
        }

        GameObject playerPrefab = spawnPrefabs[id];

        GameObject player;
        Transform startPos = GetStartPosition();

        if(startPos != null)
        {
            player = (GameObject)Instantiate(playerPrefab, startPos.position, startPos.rotation);
        }
        else
        {
            player = (GameObject)Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
        }
        NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
    }
}
