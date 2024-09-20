# DIO - Trilha .NET - Explorando a linguagem C#

## Desafio de Projeto

Para este desafio, eu precisei usar meus conhecimentos adquiridos no módulo de "Explorando a linguagem C#" da trilha .NET da DIO.

## Contexto

Tive que construir um sistema de hospedagem, que será usado para realizar reservas em um hotel. O sistema utiliza as classes `Pessoa`, `Suite` e `Reserva` para gerenciar hóspedes e calcular o valor das diárias.

### Classes do Sistema

- **Pessoa**: Representa o hóspede.
- **Suite**: Representa a suíte disponível para reserva.
- **Reserva**: Faz o relacionamento entre `Pessoa` e `Suite`, além de calcular o valor da diária.

## Regras e Validações

1. **Capacidade da Suíte**: Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Por exemplo, se a suíte tem capacidade para 2 pessoas, ao passar 3 hóspedes deve retornar uma exceção.
2. **Quantidade de Hóspedes**: O método `ObterQuantidadeHospedes` da classe `Reserva` deve retornar a quantidade total de hóspedes.
3. **Cálculo da Diária**: O método `CalcularValorDiaria` deve retornar o valor da diária (Dias reservados x valor da diária).
4. **Desconto**: Caso a reserva seja igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.

