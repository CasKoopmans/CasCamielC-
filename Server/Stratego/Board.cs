using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego 
{
    class Board
    {
        private List<Character> characters;
        private List<Character> enemyCharacters;

        public Board()
        {
            characters = new List<Character>();
            enemyCharacters = new List<Character>();
        }

        //methods for own characters
        public void addCharacter(Character character)
        {
            characters.Add(character);
        }
        public void deleteCharacter(Character character)
        {
            characters.Remove(character);
        }
        public Character getCharacter(int x, int y)
        {
            foreach (Character character in characters)
            {
                if (character.x == x && character.y == y)
                {
                    return character;
                }
            }
            return null;
        }
        public List<Character> getAllCharacters()
        {
            return characters;
        }
        //methods for enemycharacters
        public void addEnemyCharacter(Character character)
        {
            enemyCharacters.Add(character);
        }
        public void deleteEnemyCharacter(Character character)
        {
            enemyCharacters.Remove(character);
        }
        public Character getEnemyCharacter(int x, int y)
        {
            foreach (Character character in enemyCharacters)
            {
                if (character.x == x && character.y == y)
                {
                    return character;
                }
            }
            return null;
        }
        public List<Character> getAllEnemyCharacters()
        {
            return enemyCharacters;
        }

    }
}
