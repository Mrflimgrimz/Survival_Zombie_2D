﻿using NUnit.Framework;


public class StatsTest 
{
    [Test]
    [TestCase(100, 0, 50)]
    [TestCase(0, 0, 0)]
    [TestCase(120, 1240, 12310)]
    public void PlayerStatsNotMinu(int currentHealth, int currentArmour, int currentStamina)
    {
        var n = new Stats1(currentHealth, currentArmour, currentStamina);
        Assert.GreaterOrEqual(currentHealth, 0);
        Assert.GreaterOrEqual(currentArmour, 0);
        Assert.GreaterOrEqual(currentStamina, 0);


    }
    [TestCase(100, 0)]
    [TestCase(23, 321)]
    public void PlayerRegenNotMinu(int canRegenerate, int canRegenerateeat)
    {
        var n = new Stats2(canRegenerate, canRegenerateeat);
        Assert.GreaterOrEqual(canRegenerate, 0);
        Assert.GreaterOrEqual(canRegenerateeat, 0);


    }

    [TestCase(2, 12)]
    public void PlayerSpeedNotMinu(double speed,double speeds)
    {
        var n = new Stats3(speed, speeds);
        Assert.Greater(speed, 0);
        Assert.Greater(speeds, 0);


    }



}
