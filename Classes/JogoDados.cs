using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoJogoDados.Classes
{
    class JogoDados
    {
        public Jogador HumanPlayer { get; private set; }
        public Jogador MachinePlayer { get; private set; }

        private int _currentRound = 0;

        public JogoDados()
        {
            HumanPlayer = new Jogador("Jogador Humano", false);
            MachinePlayer = new Jogador("Jogador Maquina", true);
        }

        public void StartGame()
        {
            while (HumanPlayer.Score > 0 && MachinePlayer.Score > 0)
            {
                NewRound();
            }

            StopGame();

        }

        void NewRound()
        {
            _currentRound++;
            Console.Clear();
            if (_currentRound == 1) Console.WriteLine("Bem Vindo ao Jogo de Dados!");

            Console.WriteLine($"\nRodada {_currentRound}\n");
            Play();
        }

        void Play()
        {
            
            HumanPlayer.ScrollDado();
            MachinePlayer.ScrollDado();

            VerifyWinner();
        }

        void StopGame()
        {
            Console.Clear();
            Console.WriteLine("Fim de jogo!");
            Console.WriteLine($"\nPontuacao final:\n{HumanPlayer.Name}: {HumanPlayer.Score} | {MachinePlayer.Name}: {MachinePlayer.Score}\n");

            string winner = HumanPlayer.Score < MachinePlayer.Score ? HumanPlayer.Name : MachinePlayer.Name;
            Console.WriteLine($"Vencedor: {winner}\n");

            Console.WriteLine("Pressione qualquer tecla para sair!");
            Console.ReadKey();
        }

        void VerifyWinner()
        {
            if (HumanPlayer.Dado.Value > MachinePlayer.Dado.Value)
            {
                Console.WriteLine($"{HumanPlayer.Name} ganhou a rodada!\n");

                MachinePlayer.IncreaseScore();
                HumanPlayer.DecreaseScore();

                PlayersScore();
                return;
            }

            if (MachinePlayer.Dado.Value > HumanPlayer.Dado.Value)
            {
                Console.WriteLine($"{MachinePlayer.Name} ganhou a rodada!\n");

                HumanPlayer.IncreaseScore();
                MachinePlayer.DecreaseScore();

                PlayersScore();
                return;
            }

            Console.WriteLine("Empate!\n");
            PlayersScore();
        }

        void PlayersScore() 
        {
            Console.WriteLine($"Pontuacao final:\n{HumanPlayer.Name}: {HumanPlayer.Score} | {MachinePlayer.Name}: {MachinePlayer.Score}\n");
            Console.Write("Pressione qualquer tecla para continuar!");
            Console.ReadKey();
        }
    }
}
