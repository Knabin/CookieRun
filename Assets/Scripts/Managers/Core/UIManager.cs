using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager
{
    public GameObject Root
	{
		get
		{
			GameObject root = GameObject.Find("@UI_Root");
			if (root == null)
				root = new GameObject { name = "@UI_Root" };

			return root;
		}
	}

    public void Clear()
    {
        // nothing to clear
    }
}
