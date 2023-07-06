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
            Assert.AreEqual("", player.name);
            Assert.AreEqual(1, player.strength);
            Assert.AreEqual(100, player.MaxHp);
            Assert.AreEqual(50, player.Hp);
            Assert.AreEqual(1, player.defense);
            Assert.AreEqual(1, player.level);
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
            player.IncreaseHp(100);
            var actual = player.Hp;
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void TestIncreaseHp()
        {
            var player = StubPlayer(maxHp: 100, hp: 50);
            const int expected = 65;
            player.IncreaseHp(15);
            var actual = player.Hp;
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void TestIncreaseMaxHp()
        {
            var player = StubPlayer(maxHp: 100, hp: 50);
            const int expected = 115;
            player.IncreaseMaxHp(15);
            var actual = player.MaxHp;
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void TestDecreaseMaxHp()
        {
            var player = StubPlayer(maxHp: 60, hp: 50);
            const int expectedMaxHp = 40;
            player.DecreaseMaxHp(20);
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
            player.IncreaseExperience(90);
            var actual = player.Experience;
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void TestLevelUp()
        {
            var player = StubPlayer(experience: 1 , level: 1);
            const int expectedLevel = 2;
            const int expectedExperience = 0;
            player.IncreaseExperience(99);
            var playerLevel = player.level;
            var playerExp = player.Experience;
            Assert.AreEqual(expectedLevel, playerLevel);
            Assert.AreEqual(expectedExperience, playerExp);
        }
        
        [Test]
        public void TestHowMuchExpLeftAfterExperienceGained()
        {
            var player = StubPlayer(experience: 0 , level: 1);
            const int expectedLevel = 2;
            const int expectedExperience = 10;
            player.IncreaseExperience(110);
            var playerLevel = player.level;
            var playerExp = player.Experience;
            Assert.AreEqual(expectedLevel, playerLevel);
            Assert.AreEqual(expectedExperience, playerExp);
        }
        
        [Test]
        public void CreateCharacterWithSecondLevel()
        {
            var player = StubPlayer(experience: 115 , level: 1);
            const int expectedLevel = 2;
            const int expectedExperience = 15;
            var playerLevel = player.level;
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
            int level = 1,
            int experience = 1
            )
        {
            return new Player(name, strength, maxHp, hp, defense, level, experience);
        }
    }
    
    
}
