# 🎲 Projeto Jogo de Dados
Este é um projeto simples de jogo de dados em C# / .NET, desenvolvido como um exercício de lógica de programação orientada a objetos. O jogo simula partidas entre um jogador humano e um jogador de computador, com contadores e regras específicas para determinar o vencedor.

# 📌 Funcionalidades
- Dois jogadores: humano e computador.
- Cada jogador possui seu próprio dado.
- O jogo ocorre em rodadas com comparações de valores sorteados.
- Regras de vitória baseadas em decremento/incremento de contadores.
- Mensagens descritivas durante todo o fluxo do jogo.

# ⚙️ Regras do Jogo
Ambos os jogadores começam com contador = 10.

Em cada rodada:
- Cada jogador rola seu dado (valores aleatórios de 1 a 6).
- Quem tirar o maior número vence a rodada:
Vencedor: contador -1
- Perdedor: contador +1

Em caso de empate: nada acontece.
- O jogo termina quando o contador de um dos jogadores chega a 0.

# 🧑‍💻 Como Jogar
- Compile e execute o projeto no Visual Studio ou outro ambiente com suporte ao .NET.
- Pressione qualquer tecla quando solicitado para iniciar uma rodada.
- Acompanhe as mensagens no console para ver o valor dos dados, vencedor da rodada e evolução dos contadores.
- O jogo termina automaticamente quando um dos jogadores vencer.

# 🛠️ Tecnologias Utilizadas
- Linguagem: C#
- Plataforma: .NET
- Ambiente sugerido: Visual Studio / Visual Studio Code com SDK do .NET instalado