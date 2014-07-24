using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public enum GameState
{
    Intro,
    Playing,
    Dead
}

public static class GameStateManager
{
    public static GameState GameState { get; set; }

    static GameStateManager ()
    {
        GameState = GameState.Intro;
    }



}

