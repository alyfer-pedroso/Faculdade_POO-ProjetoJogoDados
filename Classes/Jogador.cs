using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoJogoDados.Classes
{
    class Jogador
    {
        public string Name { get; private set; }
        public bool IsMachine { get; private set; }

        private int _score { get; set; }

        public Dado Dado { get; private set; }

        public Jogador(string name, bool isMachine, int scoreValue = 10)
        {
            Dado = new Dado();
            IsMachine = isMachine;
            Name = name;

            InitializeScore(scoreValue);
        }

        public int Score
        {
            get { return _score; }
        }

        public int IncreaseScore() 
        {
            _score++;
            return _score;
        }

        public int DecreaseScore() {
            _score--;
            return _score;
        }

        void RequestPlayerInput()
        {
            Console.Write("Pressione qualquer tecla para rolar o dado!");
            Console.ReadKey();
            Console.WriteLine("\n");
        }

        public int ScrollDado() 
        {
            if (!IsMachine) RequestPlayerInput();
            Dado.Scroll();

            Console.WriteLine($"{Name}: Rolando o dado...\nValor do dado: {Dado.Value}\n");

            return _score;
        }

        void InitializeScore(int scoreValue) 
        { 
            _score = scoreValue;
        }
    }
}
