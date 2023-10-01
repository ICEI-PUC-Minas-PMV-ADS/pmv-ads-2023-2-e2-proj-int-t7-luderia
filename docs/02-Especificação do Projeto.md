# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada com a participação dos usuários em um trabalho de imersão feita pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários. 

## Personas

### Persona 1: Tiago Félix - Bancário

#### História: 
Tiago Félix tem 32 anos, é bancário, mora sozinho e solteiro. É um verdadeiro workaholic, mas ama o momento de lazer com os amigos, ama ler, ver bons filmes, é apaixonado por jogos de tabuleiro, gostaria de aprender novos jogos, no entanto eles ocupam muito espaço.

### Persona 1: Marisa Pacheco - Advogada Atarefada

#### História: 
Marisa Pacheco é uma advogada de 37 anos, mãe de dois adolescentes e responsável por um cargo executivo de um escritório de advocacia. Sua rotina é agitada e demanda grande parte do seu tempo, deixando pouco espaço para realizar atividades com os filhos, por isso ela gostaria de estimular encontros entre os filhos e outras crianças. Ela muitas vezes adia momentos de lazer por falta de tempo. Marisa percebe que o uso da tecnologia poderia facilitar bastante sua rotina para alugar jogos que proporcionasse bons momentos em família e amigos.  

### Persona 1: Hélio Santana - Funcionário Público e empresário preocupado

#### História: 
Hélio Santana é funcionário público e empresário, tem 44 anos e tem uma casa que oferece aluguel de jogos de tabuleiro para jogar no local ou levar para casa. Ele vê na sua empresa uma ótima oportunidade para manter as despesas da família, no entanto a loja quase não se sustenta, é mantida como um hobbie, devido a falta de clientes. Ele acredita que uma plataforma online que facilite o aluguel de jogos seria uma ótima maneira de aumentar sua cartela de clientes e aumentar a receita de sua luderia.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Tiago Félix         | procurar jogos para alugar perto de minha casa | não desgastar muito com deslocamento 
|Tiago Félix         | Estender o tempo de aluguel do jogo | Poder ficar com o jogo por mais tempo  |
|Tiago Félix         | Procurar jogos por tema           | Facilitar a pesquisa pelas minhas preferências |
|Marisa Pacheco      | Fazer a busca por idade dos jogadores | Escolher o jogo de acordo com a idade das crianças |
|Marisa Pacheco      | Procurar jogos por número de jogadores  |Saber se atenderá à quantidade de convidados |
|Marisa Pacheco      | Reservar um jogo para uma data específica | Garantir que esteja disponível quando possível |
|Hélio Santana       | Um local online para expor os jogos que ofereço | Aumentar minha base de clientes |
|Hélio Santana       | Informar o valor e data para retirada e devolução do jogo | Auxiliar na gestão das locações| 
|Hélio Santana       | Saber quando um jogo será devolvido  | Libera-lo ou não para reserva           |


Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O site deve gerenciar dois tipos de conta – loja e jogador  | ALTA | 
|RF-002| O site deve buscar jogos segundo atributos informados pelo usuário    | ALTA |
|RF-003| O site deve emitir relatório de jogos mais procurados | MÉDIA | 
|RF-004| Gerenciar o login do usuário cadastrado      | ALTA |
|RF-005| Permitir que o usuário possa deletar a conta  | MÉDIA | 
|RF-006| Gerenciar o aluguel dos jogos    | ALTA |
|RF-007| Registrar o aluguel de jogo  | MÉDIA | 
|RF-008| Selecionar entrega de jogo para cliente   | MÉDIA |
|RF-009| Registrar devolução de jogo | MÉDIA | 
|RF-010| Avaliar jogo | MÉDIA |
### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku);   | ALTA | 
|RNF-002| O site deverá ser responsivo permitindo a visualização em um celular de forma adequada  |  MÉDIA | 
|RNF-003| O site deve ser leve e fácil de entender e utilizar  |  ALTA | 
|RNF-004| O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge)   |  ALTA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01|O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 12/12/2023.  |
|02| A equipe não pode subcontratar o desenvolvimento do trabalho. |


> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama contempla as principais ligações previstas entre casos de uso e atores e permite detalhar os Requisitos Funcionais identificados na etapa de elicitação. Lembrando que  não se utiliza diagramas de caso de uso para requisitos não-funcionais. 

 

Como atores é importante a identificação dos grupos de todos os envolvidos que interagem com o sistema, principalmente outros sistemas ou sensores. Eles são representados graficamente por bonecos-palito e serão nomeados pelos papéis nas interações nas quais estão envolvidos (ex. Cliente, Administrador). Lembre-se de que o próprio sistema não pode ser ator do diagrama que o modela. 

 

Em relação aos casos de uso, eles devem representar as interações ou transações dos atores com o sistema. Cada tipo possível é representada por uma elipse nomeada e os relacionamentos são indicados por linhas que podem ter setas nos casos em que se indica a origem da interação. Os nomes dos casos de uso representam verbos no infinitivo associados aos objetos com os quais se relacionam os verbos (ex. Cadastrar usuário, Visualizar relatório). Os tipos de relacionamentos mais comuns são associações entre atores e casos de uso, generalizações entre atores e entre casos de uso, inclusões e extensões entre casos de uso. 

![diag casos oficial](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t7-luderia/assets/121675519/40746754-ac45-43a7-bf64-f172ea77d1e1)



> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
