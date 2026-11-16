using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] TMP_Text participantLabel;
    [SerializeField] string participantPrefix = "P";   // "S" for simulator participants

    void Start()
    {
        Session.Prefix = participantPrefix;
        Refresh();
    }

    public void NextParticipant()
    {
        Session.ParticipantNumber++;
        Refresh();
    }

    public void PreviousParticipant()
    {
        Session.ParticipantNumber = Mathf.Max(1, Session.ParticipantNumber - 1);
        Refresh();
    }

    // Wired to the variant buttons, with the scene name typed into On Click ().
    public void LoadScene(string sceneName) => SceneManager.LoadScene(sceneName);

    void Refresh() => participantLabel.text = $"Participant: {Session.Participant}";
}
