using UnityEngine;

namespace NightMare.Mechanics
{
    /// <summary>
    /// Quản lý hệ thống Đèn Dầu, Cầu Dao Tổng và Sự Cố Mất Điện.
    /// Tương tác phím [E] để bật/tắt công tắc điện hoặc xoay bấc đèn dầu.
    /// </summary>
    public class ITOLightSwitch : MonoBehaviour
    {
        [Header("Lighting Targets")]
        [SerializeField] private Light[] houseLights;
        [SerializeField] private Light oilLampLight;
        [SerializeField] private AudioSource powerExplosionAudio;
        [SerializeField] private AudioClip sparkSound;

        [Header("State")]
        [SerializeField] private bool isPowerOn = true;
        [SerializeField] private bool hasBlownFuse = false;

        public void TriggerPowerBlackout()
        {
            if (hasBlownFuse) return;

            hasBlownFuse = true;
            isPowerOn = false;

            // Tắt toàn bộ đèn nhà
            foreach (Light l in houseLights)
            {
                if (l != null) l.enabled = false;
            }

            // Phát âm thanh nổ bóng đèn
            if (powerExplosionAudio != null && sparkSound != null)
            {
                powerExplosionAudio.PlayOneShot(sparkSound);
            }

            // Bật ngọn lửa leo lét của Đèn Dầu
            if (oilLampLight != null)
            {
                oilLampLight.enabled = true;
            }
        }

        public void RestorePowerFromFuseBox()
        {
            isPowerOn = true;
            foreach (Light l in houseLights)
            {
                if (l != null) l.enabled = true;
            }
        }
    }
}
