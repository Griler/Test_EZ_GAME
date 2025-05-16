using UnityEngine;

public interface IAnimation
{
    void PlayAnimation(string animationName);
    void StopAnimation(string animationName);
    bool IsAnimationPlaying(string animationName);
    float GetAnimationLength(string animationName);
    // Bạn có thể thêm các phương thức quản lý animation khác nếu cần
}