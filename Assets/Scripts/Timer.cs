public class Timer
{
    public float RemainingSeconds { get; private set; }
    private float Duration { get; set; }

    public bool IsDone() => RemainingSeconds == 0;

    public Timer(float duration)
    {
        RemainingSeconds = duration;
        Duration = duration;
    }

    public void Tick(float deltaTime)
    {
        if (RemainingSeconds == 0) { return; }

        RemainingSeconds -= deltaTime;

        CheckForTimerEnd();
    }

    private void CheckForTimerEnd()
    {
        if (RemainingSeconds > 0f) { return; }

        RemainingSeconds = 0f;
    }
    public void ResetTimer()
    {
        RemainingSeconds = Duration;
    }
}