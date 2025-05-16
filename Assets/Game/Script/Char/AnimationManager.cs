using UnityEngine;

public class AnimationManager : MonoBehaviour, IAnimation
{
    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Animator component not found on this GameObject.");
        }
    }

    public void PlayAnimation(string animationName)
    {
        if (IsAnimationPlaying(animationName))
        {
            return;
        }
        if (animator != null && !animator.IsInTransition(0))
        {
            animator.CrossFade(animationName, 0.2f); // Hòa trộn sang animation "Attack" trong 0.2 giây
        }
    }

    public void StopAnimation(string animationName)
    {
        if (animator != null && IsAnimationPlaying(animationName))
        {
            // Tùy thuộc vào animation và yêu cầu của bạn, bạn có thể
            // sử dụng CrossFade để dừng mượt mà hơn hoặc ResetTrigger.
            // Ví dụ đơn giản:
            animator.Play("Idle"); // Chuyển về trạng thái idle
        }
    }

    public bool IsAnimationPlaying(string animationName)
    {
        if (animator != null)
        {
            AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0); // Lấy thông tin layer 0
            return stateInfo.IsName(animationName);
        }
        return false;
    }

    public float GetAnimationLength(string animationName)
    {
        if (animator != null)
        {
            AnimationClip[] clips = animator.runtimeAnimatorController.animationClips;
            foreach (AnimationClip clip in clips)
            {
                if (clip.name == animationName)
                {
                    return clip.length;
                }
            }
            Debug.LogWarning($"Animation clip '{animationName}' not found.");
            return 0f;
        }
        return 0f;
    }
}