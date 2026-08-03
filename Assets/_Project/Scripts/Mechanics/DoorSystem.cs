using UnityEngine;
using NightMare.Interaction;

namespace NightMare.Mechanics
{
    /// <summary>
    /// Hệ thống Cửa Căn Nhà & Cửa Tầng Hầm.
    /// Kiểm tra trạng thái khóa, sử dụng chìa khóa tương ứng (Key ID) và mở mượt mà bằng Quaternion Slerp.
    /// </summary>
    public class DoorSystem : MonoBehaviour, IInteractable
    {
        [Header("Door Configuration")]
        [SerializeField] private string requiredKeyID = "BasementKey_01";
        [SerializeField] private bool isLocked = true;
        [SerializeField] private float openAngle = 90f;
        [SerializeField] private float smoothSpeed = 3.0f;

        [Header("Audio")]
        [SerializeField] private AudioSource doorAudioSource;
        [SerializeField] private AudioClip openSound;
        [SerializeField] private AudioClip lockedSound;

        private bool isOpen = false;
        private Quaternion closedRotation;
        private Quaternion openRotation;

        private void Start()
        {
            closedRotation = transform.rotation;
            openRotation = Quaternion.Euler(transform.eulerAngles + new Vector3(0, openAngle, 0));
        }

        private void Update()
        {
            Quaternion targetRotation = isOpen ? openRotation : closedRotation;
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * smoothSpeed);
        }

        public string GetInteractText()
        {
            if (isLocked) return "Cửa đã khóa [E]";
            return isOpen ? "Đóng cửa [E]" : "Mở cửa [E]";
        }

        public void OnInteract(Transform playerTransform)
        {
            if (isLocked)
            {
                if (doorAudioSource != null && lockedSound != null)
                {
                    doorAudioSource.PlayOneShot(lockedSound);
                }
                return;
            }

            isOpen = !isOpen;
            if (doorAudioSource != null && openSound != null)
            {
                doorAudioSource.PlayOneShot(openSound);
            }
        }

        public void UnlockDoor(string keyID)
        {
            if (keyID == requiredKeyID)
            {
                isLocked = false;
            }
        }

        public void OnInspect() { }
        public void OnDrop() { }
    }
}
