using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum Scene
    {
        Unknown,
        LoadingScene,
        LobbyScene,
        GameScene,
    }

    public enum Sound
    {
        Bgm,
        Effect,
        MaxCount,
    }

	public enum UIEvent
	{
		Click,
		Drag,
		PointerDown,
		PointerUp,
	}

    public enum CookieType
    {
        Brave,
        
    }
}
