using Character;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace UnitTests.Editor
{
    public class PlayerTests
    {
        [Test]
        public void TestCreatingPlayer()
        {
            var player = StubPlayer();
            Assert.AreEqual("", player.Name);
            Assert.AreEqual(100, player.MaxHp);
            Assert.AreEqual(50, player.Hp);
            Assert.AreEqual(1, player.Strength);
            Assert.AreEqual(1, player.Defense);
            Assert.AreEqual(1, player.Level);
            Assert.AreEqual(1, player.Experience);
            
        }
        
        [Test]
        public void TestCreatedPlayerWithHpMoreThanMaxHpHasMaxHp()
        {
            var player = StubPlayer(maxHp: 100, hp: 200);
            const int expected = 100;
            var actual = player.Hp;
            Assert.AreEqual(expected, actual);
        }
    
        [Test]
        public void TestIncreaseHpMoreThatMaxHpWillSetMaxHp()
        {
            var player = StubPlayer(maxHp: 100, hp: 50);
            const int expected = 100;
            player.HpStats.IncreaseHp(100);
            var actual = player.Hp;
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void TestIncreaseHp()
        {
            var player = StubPlayer(maxHp: 100, hp: 50);
            const int expected = 65;
            player.HpStats.IncreaseHp(15);
            var actual = player.Hp;
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void TestDecreaseHp()
        {
            var player = StubPlayer(maxHp: 100, hp: 50);
            const int expected = 35;
            player.HpStats.DecreaseHp(15);
            var actual = player.Hp;
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void TestIncreaseMaxHp()
        {
            var player = StubPlayer(maxHp: 100, hp: 50);
            const int expected = 115;
            player.HpStats.IncreaseMaxHp(15);
            var actual = player.MaxHp;
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void TestDecreaseMaxHp()
        {
            var player = StubPlayer(maxHp: 60, hp: 50);
            const int expectedMaxHp = 40;
            player.HpStats.DecreaseMaxHp(20);
            var actualMaxHp = player.MaxHp;
            var actualHp = player.Hp;
            Assert.AreEqual(expectedMaxHp, actualMaxHp);
            Assert.AreEqual(expectedMaxHp, actualHp);
        }

        [Test]
        public void TestIncreaseExperience()
        {
            var player = StubPlayer(experience: 0);
            const int expected = 90;
            player.ExpStats.IncreaseExperience(90);
            var actual = player.Experience;
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void TestLevelUp()
        {
            var player = StubPlayer(experience: 1);
            const int expectedLevel = 2;
            const int expectedExperience = 0;
            player.ExpStats.IncreaseExperience(99);
            var playerLevel = player.Level;
            var playerExp = player.Experience;
            Assert.AreEqual(expectedLevel, playerLevel);
            Assert.AreEqual(expectedExperience, playerExp);
        }
        
        [Test]
        public void TestHowMuchExpLeftAfterExperienceGained()
        {
            var player = StubPlayer(experience: 0);
            const int expectedLevel = 2;
            const int expectedExperience = 10;
            player.ExpStats.IncreaseExperience(110);
            var playerLevel = player.Level;
            var playerExp = player.Experience;
            Assert.AreEqual(expectedLevel, playerLevel);
            Assert.AreEqual(expectedExperience, playerExp);
        }
        
        [Test]
        public void CreateCharacterWithSecondLevel()
        {
            var player = StubPlayer(experience: 115);
            const int expectedLevel = 2;
            const int expectedExperience = 15;
            var playerLevel = player.Level;
            var playerExp = player.Experience;
            Assert.AreEqual(expectedLevel, playerLevel);
            Assert.AreEqual(expectedExperience, playerExp);
        }
        
        private Player StubPlayer(
            string name = "",
            int strength = 1,
            int maxHp = 100,
            int hp = 50,
            int defense = 1,
            int experience = 1
            )
        {
            return new Player(name, strength, maxHp, hp, defense, experience);
        }
    }
    
    
}
