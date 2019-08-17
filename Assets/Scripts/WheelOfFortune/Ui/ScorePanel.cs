using Common;
using TMPro;
using UnityEngine;
using WheelOfFortune.Common;
using WheelOfFortune.Generator;

namespace WheelOfFortune.Ui
{
    [RequireComponent(typeof(TMP_Text))]
    public class ScorePanel : MonoBehaviour
    {
        private const string ScoreAlias = "Score";
        private TMP_Text _scoreTextField;
        private int _cachedScore;

        private void Awake()
        {
            _scoreTextField = GetComponent<TMP_Text>();
        }

        private void Start()
        {
            _cachedScore = PlayerPrefs.GetInt(ScoreAlias);
            SetScoreTextField();
            GameActions.SpinFinish += OnSpinFinish;
        }

        private void OnDestroy()
        {
            PlayerPrefs.SetInt(ScoreAlias, _cachedScore);
            GameActions.SpinFinish -= OnSpinFinish;
        }

        private void IncreaseScore(int value)
        {
            _cachedScore += value;
            SetScoreTextField();
        }

        private void SetScoreTextField()
        {
            _scoreTextField.text = _cachedScore.ConvertK();
        }

        private void OnSpinFinish()
        {
            IncreaseScore(FortuneGenerator.GetLastWinValue());
        }
    }
}