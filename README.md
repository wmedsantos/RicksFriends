# Desafio API

Obrigado pelo seu interesse em se juntar a nós. Este desafio vai nos permitir uma avaliação sobre seu nível de conhecimento e práticas de desenvolvimento. Estamos empolgados em saber do que você é capaz.

## Envio

* Preferencialmente, faça um fork desse projeto no Github.
* Desenvolva conforme as intruções abaixo.
* Envie seu código como um pull request para esse branch.
* Se não estiver familiarizado com git ou tiver alguma dificuldade, nos envie seu código por e-mail [desafio@aarim.com](mailto:desafio@aarim.com@aarim.com)

Você pode utilizar a linguagem de programação que se sentir mais confortável, pórem projetos em *C#* terão um bônus na avaliação. Se optar por outra linguagem é importante incluir na descrição os requisitos e passos pra executar seu código.

## Projeto

Este projeto não deve tomar muito de seu tempo, não há um prazo específico para a conclusão mas não é nosso interesse que você gaste muito tempo nisso e nem faça um trabalho correndo.

Para esse projeto iremos utilizar uma API pública da série de animação Rick and Morty. 

A demanda é consumir os dados de personagens e listar os que atendam a todos os seguintes critérios:
* Status = unknown
* Species = alien
* Apareceram em mais de 1 episódio

### Rick and Mordy API

Essa api pública que será usada é disponibilizada em duas versões (GraphQL e REST) e sua documentação pode ser encontrada aqui [https://rickandmortyapi.com/](https://rickandmortyapi.com/).

Para o desafio deve ser utilizada a versão REST e os dados coletados a partir do endpoint `/character`. Você pode se sentir a vontade para escrever o código mas é importante que leia a documentação para saber a forma mais eficaz de realizar a implementação.


Segue um exemplo da resposta que terá:

```
{
  "info": {
    "count": 826,
    "pages": 42,
    "next": "https://rickandmortyapi.com/api/character/?page=2",
    "prev": null
  },
  "results": [
    {
      "id": 1,
      "name": "Rick Sanchez",
      "status": "Alive",
      "species": "Human",
      "type": "",
      "gender": "Male",
      "origin": {
        "name": "Earth",
        "url": "https://rickandmortyapi.com/api/location/1"
      },
      "location": {
        "name": "Earth",
        "url": "https://rickandmortyapi.com/api/location/20"
      },
      "image": "https://rickandmortyapi.com/api/character/avatar/1.jpeg",
      "episode": [
        "https://rickandmortyapi.com/api/episode/1",
        "https://rickandmortyapi.com/api/episode/2",
        // ...
      ],
      "url": "https://rickandmortyapi.com/api/character/1",
      "created": "2017-11-04T18:48:46.250Z"
    },
    // ...
  ]
}
```


## Objetivo

Nós gostaríamos de ter uma ideia de como você trabalha (especificamente atuando com ambientes desconhecidos) e se você é capaz de atender a todos os requisitos de uma determinada tarefa. Seja utilizando seus conhecimentos atuais ou buscando novos.

Esperamos um código bem estruturado, lógico e simples. Não há necessidade de implementação de testes para esse desafio.

Nos envie através do `README` ou do e-mail um simples descritivo do seu processo nesse desafio, as dificuldades, descobertas, etc.

## Descritivo do processo de desenvolvimento

Primeiramente foi um prazer pode criar este desafio, justamente de uma série que gosto tanto.
Após uma boa olhada na documentação disponível, fiz uma breve avaliação de alguns dos forks já criados.
O mais interessante que achei foi do Manocchio que usou DDD.

Como eu não queria fazer o mesmo e a sugestão era pra que fosse feito em C#, optei pela implementação no padrão Clean Arquitecture da MS. Utilizando o próprio template do Visual Studio 2022 para .NET Core Web Aplication, que utiliza Razor Pages.
Não tenho costume de utilizar Razor Pages, pois não acho legal essa magia toda por debaixo dos panos sem meu controle do que está ocorrendo.
Depois de ter feito, achei que ficaria melhor fazer uma WebApi e um frontend em angular ou react.
A parte fácil foi criar o Domain e Infrastructure com o ApiClient pra fazer a requisição http.
Depois aproveitando o template apenas criei a página Characters pra exibir os dados.
Como queria testar a paginação se estava ok fiz um teste chamando a api sem os filtros.
Após fazer alguns ajustes na response pra funcionar com a paginação,
Eu tive dificuldade em fazer a paginação funcionar utilizando o asp-page= asp-route-page= e acabei utilizando href mesmo.

No fim fiz uma pequena perfumaria no CSS e me dei por satisfeito.



