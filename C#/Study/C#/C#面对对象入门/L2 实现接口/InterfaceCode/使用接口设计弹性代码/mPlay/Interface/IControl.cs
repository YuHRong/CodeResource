namespace mPlay;

public interface IControl
{
 void Play();
 void Pause();
 bool ISPlaying { get; }
}
