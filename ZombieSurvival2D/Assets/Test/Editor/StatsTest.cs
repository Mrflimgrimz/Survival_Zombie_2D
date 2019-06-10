﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class StatsTest 
{
    [Test]
    [TestCase(100, 0, 50)]
    [TestCase(0, 0, 0)]
    public void PlayerStatsNotMinu(int currentHealth, int currentArmour, int currentStamina)
    {
        var n = new Stats1(currentHealth, currentArmour, currentStamina);
        Assert.GreaterOrEqual(currentHealth, 0);
        Assert.GreaterOrEqual(currentArmour, 0);
        Assert.GreaterOrEqual(currentStamina, 0);


    }



}
