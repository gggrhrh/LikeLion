using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pokemon
{
    enum PokemonImage
    {
        오박사,
        이상해씨,
        이상해꽃,
        이상해풀,
        파이리,
        리자드,
        리자몽,
        꼬부기,
        어니부기,
        거북왕
    }

    class UserPokemon
    {
        private string Name;
        private int Level;
        private int CurHp;
        private int MaxHp;
        private int Attack;
        private int CurExp;
        private int MaxExp;
        Random rand = new Random();

        public void LevelUp()
        {
            Level++;
            MaxHp += rand.Next(1, 4);
            CurHp = MaxHp;
            Attack += rand.Next(1, 4);
            CurExp = 0;
            MaxExp += rand.Next(1 * Level, 2 * Level);
        }

        public void StartState(string name)
        {
            Name = name;
            Level = 5;
            MaxHp = rand.Next(18, 22);
            CurHp = MaxHp;
            Attack = rand.Next(7, 11);
            MaxExp = rand.Next(20, 31);
        }

        public void GetState()
        {
            Console.Write($" 포켓몬 : {Name} | 체력 : {CurHp} / {MaxHp} | 공격력 : {Attack}\n" +
                $" 레벨 : {Level, -8}  | 경험치 : {CurExp} / {MaxExp}");
        }
    }

    class EnemyPokemon
    {
        public string sName;
        public int iLevel;
        public int iHp;
        public int iAttack;
        public PokemonImage Image;
        Random rand = new Random();

        public EnemyPokemon()
        {
            sName = "오박사";
            iLevel = 0;
            iHp = 0;
            iAttack = 0;
            Image = PokemonImage.오박사;
        }

        public EnemyPokemon(string name, int level, PokemonImage image)
        {
            sName = name;
            iLevel = level;
            iHp = 20 + rand.Next(1,4) * level;
            iAttack = rand.Next();
            Image = image;
        }

    }

    class Program
    {

        static string OutputImage(PokemonImage pokemon, int x, int y)
        {
            Console.SetCursorPosition(x, y);

            string str = "";

            if (pokemon == PokemonImage.오박사)
            {
                str = "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀" +
                "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀" +
                "\r\n⢀⠀⠠⠀⠀⠄⠀⢄⡃⡑⠒⡂⢢⠀⠀⠠⠀⠀⠄⠀" +
                "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⣞⢬⢙⢼⡺⠀⠀⠀⠀⠀⠀⠀" +
                "\r\n⠀⠀⠠⠐⠀⠀⠂⠀⢑⣌⢜⣔⡉⠀⠀⠀⠀⠂⠀⠈" +
                "\r\n⠀⡀⠀⠀⢀⢀⡀⠎⡡⢞⣯⡿⠪⢒⠄⠀⠁⠀⠀⠀" +
                "\r\n⠁⠀⠀⠀⠪⢗⡻⡜⠠⣸⣷⣯⠈⢢⢑⠀⠀⠀⠠⠀" +
                "\r\n⠀⠀⠀⠀⠈⠳⢍⢎⠀⣸⢿⡯⠀⢸⢀⠃⠀⠀⠀⠀" +
                "\r\n⠀⠂⠈⠀⠀⠀⠀⡢⠨⢸⡧⣫⠈⢸⠀⠀⠀⠀⠈⠀" +
                "\r\n⠀⠀⠀⠀⠀⡀⠀⠘⡤⡮⡯⣪⢬⡊⠀⠀⠀⠈⠀⠀" +
                "\r\n⠐⠈⠀⠀⠀⠀⠀⠰⣙⡞⠎⣏⡳⠀⠀⠀⠀⠠⠀⠀" +
                "\r\n⢀⠀⠀⠀⠐⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⠀⠀⠀⢀" +
                "\r\n";
            }
            else if (pokemon == PokemonImage.이상해씨)
            {
                str = "\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡰⡄⡄⠀⠀" +
                    "\n⠀⠀⠀⠀⠀⠀⠀⢀⠔⡊⢌⠪⢅⠕⡡⠢⡨⣋⠀⠀" +
                    "\n⠀⠀⡌⢑⠂⢔⣀⡋⢊⢂⠩⡑⡢⢊⠔⡡⡪⡪⢆⠀" +
                    "\n⠀⡘⢄⣁⠺⡱⠊⠔⡡⢈⠆⡨⣣⢪⢪⠪⡪⡪⡪⡂" +
                    "\n⠘⡘⠔⠡⢢⡎⡘⢂⢊⡋⢦⠪⣰⢑⣕⢍⢎⢜⢅⢳" +
                    "\n⣅⠪⢊⠐⢅⠌⡐⢅⠘⣅⠳⣑⢌⠪⣣⠯⣎⢣⢕⡍" +
                    "\n⠈⠓⢪⢎⠦⠜⠴⢬⡲⢔⢍⠦⡑⠱⡐⢎⠔⡩⠎⠀" +
                    "\n⠀⠀⢰⠡⡝⢪⡓⢕⢖⢕⣃⡴⠊⢔⡙⢦⢫⡊⢎⠀" +
                    "\n⠀⠀⠀⣋⠪⡢⡉⠁⠳⡺⢤⢁⠪⡂⢗⢌⠣⢜⠅⠀" +
                    "\n⠀⠀⠀⠈⠁⠁⠀⠀⠀⠑⠐⠌⠊⠀⠀⠁⠉⠊⠀⠀" +
                    "\n";
            }
            else if (pokemon == PokemonImage.이상해꽃)
            {

            }
            else if (pokemon == PokemonImage.이상해풀)
            {

            }
            else if (pokemon == PokemonImage.파이리)
            {

            }
            else if (pokemon == PokemonImage.리자드)
            {

            }
            else if (pokemon == PokemonImage.리자몽)
            {

            }
            else if (pokemon == PokemonImage.꼬부기)
            {

            }
            else if (pokemon == PokemonImage.어니부기)
            {

            }
            else if (pokemon == PokemonImage.거북왕)
            {

            }


            return str;
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

        }
    }
}