using System;
using Godot;

public class FPSCounter: Label
{
    public override void _Ready()
    {
        Console.WriteLine("[FPSCounter] Loaded the FPS Counter text label");
    }

    public override void _Process(float delta)
    {
        var fps = Performance.GetMonitor(Performance.Monitor.TimeFps);
        Text = $"FPS: {fps}";
    }
}