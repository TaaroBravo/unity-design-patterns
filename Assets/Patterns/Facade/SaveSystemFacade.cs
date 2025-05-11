using Patterns.Facade;
using UnityEngine;

public class SaveSystemFacade : MonoBehaviour
{
    [SerializeField] private Player player;

    public void SaveGame()
    {
        SaveData data = new SaveData
        {
            playerHealth = player.Health,
            playerPosition = player.transform.position,
            score = player.Score
        };

        SaveFileHandler.SaveToDisk(data);
        Debug.Log("Juego guardado.");
    }

    public void LoadGame()
    {
        SaveData data = SaveFileHandler.LoadFromDisk();
        if (data != null)
        {
            player.Health = data.playerHealth;
            player.transform.position = data.playerPosition;
            player.Score = data.score;
            Debug.Log("Juego cargado.");
        }
        else
        {
            Debug.LogWarning("No se encontró partida guardada.");
        }
    }
}