

using Logger = QModManager.Utility.Logger;
using UnityEngine;

namespace ExplodeMyVehicles_BZ
{
    internal class ExplodeComponent : MonoBehaviour
    {
        public void Update()
        {
            if (GameInput.GetKeyDown(KeyCode.LeftBracket))
            {
                GameObject gameObject = GameObject.Find("Exosuit(Clone)");
                gameObject.GetComponent<LiveMixin>().Kill(DamageType.Normal);
                Logger.Log(Logger.Level.Info, $"Attempted to Kill  [Exosuit] , hope it worked!", null, true);
                Logger.Log(Logger.Level.Info, $"Hopefully successful!", null, true);

            }

            if (GameInput.GetKeyDown(KeyCode.RightBracket))
            {
                GameObject gameObject = GameObject.Find("SeaTruck(Clone)");
                gameObject.GetComponent<LiveMixin>().Kill(DamageType.Normal);
                Logger.Log(Logger.Level.Info, $"Attempted to Kill  [Seatruck] , hope it worked!", null, true);
            } 
        }
    }
}