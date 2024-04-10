using NUnit.Framework;


public class HealthTest
{
    // A Test behaves as an ordinary method
    [Test]
    [TestCase(5)]
    [TestCase(10)]
    [TestCase(7)]
    public void HealthTest_SetCurrentHP(int HealthToSet)
    {
        var health = new Health();
        health.SetCurrentHealth(HealthToSet);
        Assert.IsTrue(health.CurrentHealth == HealthToSet);
    }
    [Test]
    [TestCase(5, 5)]
    [TestCase(10, 15)]
    [TestCase(7, 8)]
    public void HealthTest_DecreaseHP(int HealthToDecrease, int StartingHealth)
    {
        var health = new Health();
        health.SetCurrentHealth(StartingHealth);
        health.LoseHealth(HealthToDecrease);
        Assert.IsTrue(health.CurrentHealth == StartingHealth - HealthToDecrease);
    }
    [Test]
    [TestCase(5, 5)]
    [TestCase(16, 15)]
    [TestCase(19, 8)]
    public void HealthTest_DoesNotGoNegative(int HealthToDecrease, int StartingHealth)
    {
        var health = new Health();
        health.SetCurrentHealth(StartingHealth);
        health.LoseHealth(HealthToDecrease);
        Assert.IsTrue(health.CurrentHealth == 0);
    }
    [Test]
    [TestCase(5, 5)]
    [TestCase(16, 10)]
    [TestCase(19, 8)]
    public void HealthTest_DoesNotGoAboveMaxHP(int HealthToGain, int StartingHealth)
    {
        var health = new Health();
        health.SetCurrentHealth(StartingHealth);
        health.GainHealth(HealthToGain);
        Assert.AreEqual(health.maxHealth, health.CurrentHealth);
    }

}
