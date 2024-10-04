# Stopwatch Application

## Descrição

Este é um projetinho simples de uma aplicação de console em C# que atua como um timer. O usuário pode escolher contar em segundos ou minutos e acompanhar a contagem até o término. A aplicação é interativa e fácil de usar, proporcionando uma experiência básica de temporização diretamente no terminal.

## Funcionalidades

- **Menu de Início:** Oferece opções para sair ou iniciar a contagem.
- **Seleção de Tempo:** Permite ao usuário escolher o tempo de contagem em segundos (`s`) ou minutos (`m`).
- **Contagem Regressiva:** Exibe a contagem em tempo real no console.
- **Mensagens de Estado:** Mostra mensagens como "Ready...", "Set...", e "Go!" antes de iniciar a contagem.
- **Reinício Automático:** Após a contagem terminar, permite retornar ao menu principal para uma nova contagem.

## Requisitos

- **.NET SDK:** Certifique-se de ter o .NET SDK instalado em sua máquina. Você pode baixá-lo [aqui](https://dotnet.microsoft.com/download).

## Como Executar

1. **Clone o Repositório:**

   ```bash
   git clone https://github.com/evilisglenio/stopwatch-app.git
   ```

2. **Navegue até o Diretório:**

```bash
 cd stopwatch-app
```

3. **Execute o Projeto:**

```bash
 dotnet run
```

## Como Usar

1. Quando o programa iniciar, você verá um menu com opções para iniciar a contagem ou sair.
2. Escolha iniciar a contagem digitando '1' e pressione Enter.
3. Selecione se deseja contar em segundos ('s') ou minutos ('m').
4. Digite o número de segundos ou minutos desejado.
5. A contagem regressiva começará após as mensagens "Ready...", "Set...", "Go!".
6. Ao término da contagem, você terá a opção de voltar ao menu principal.

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests com melhorias.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
