using TMPro;
using UnityEngine;

namespace WheelOfFortune.Ui
{
    public class ScorePanel : MonoBehaviour
    {
        private const string ScoreAlias = "Score";
        [SerializeField] private TMP_Text _scoreTextField;
        private int _cachedScore;
        
        private void Start()
        {
            _cachedScore = PlayerPrefs.GetInt(ScoreAlias);
        }

        private void OnDestroy()
        {
            PlayerPrefs.SetInt(ScoreAlias, _cachedScore);
        }

        private void IncreaseScore(int value)
        {
            _cachedScore += value;
        }

        private void SetScoreTextField()
        {
            _scoreTextField.text = _cachedScore.ToString();
        }
    }
}