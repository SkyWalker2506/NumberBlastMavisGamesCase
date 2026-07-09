using UnityEngine;
using TMPro;
using NumbersBlast.Core;

namespace NumbersBlast.UI
{
    public sealed class TurnView : MonoBehaviour
    {
        [SerializeField] private TMP_Text label;
        [SerializeField] private string localText = "Your Turn";
        [SerializeField] private string opponentText = "Opponent's Turn";

        public void SetVisible(bool visible)
        {
            gameObject.SetActive(visible);
        }

        public void SetTurn(PlayerSide side)
        {
            if (label != null)
            {
                label.text = side == PlayerSide.Local ? localText : opponentText;
            }
        }
    }
}
