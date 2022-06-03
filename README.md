# UC_14_Senai_ProjetoAPI

Uma API trata-se de uma interface que permite a comunicação entre um ou mais sistemas através de um conjunto de definições entre solicitante e produtor desse conteúdo, possibilitando que um sistema utilize as funcionalidades de outro sistema programaticamente.

Por exemplo:
Uma vida sem padrões definitivamente seria mais complicada e podemos usar diversas comparações para mostrar como as APIs facilitam diversos processos nesse sentido. Uma analogia interessante é com o sistema elétrico de uma casa. Da mesma forma que um aparelho utiliza a eletricidade da concessionária através de uma tomada elétrica, uma aplicação pode utilizar dados ou funcionalidades de um serviço através de uma API. Para ilustrar melhor, se não houvesse plugues, teríamos que ligar os cabos dos aparelhos eletrônicos diretamente nas estruturas elétricas da casa. Para isso, seria necessário possuir as ferramentas específicas para retirar todos os cabos para fora da parede, emendar com o cabo do aparelho a ser utilizado e guardar tudo de novo. Isso sem contar a necessidade de conhecer as especificidades de cada tipo de cabo elétrico e aparelho. Seria uma bagunça imensurável!

Em resumo,  É uma interface que permite a comunicação entre um ou mais sistemas através de um conjunto de definições entre solicitante e produtor desse conteúdo, possibilitando que um sistema utilize as funcionalidades de outro sistema programaticamente.

O modelo usado foi o HTTP do tipo RESTful que retorna um JSON (JSON é um formato de texto para troca de dados entre dispositivos e sistemas).

## COMO FUNCIONA

Cada operação utilizará um verbo HTTP para a ação realizada.

GET – buscar
POST – criar
PUT – atualizar
DELETE – exclui

| Método  | Endpoint | Descrição | Corpo da solicitação | Corpo da Resposta |
|  :---:  |  :----:  |  :---:  | :---:  | :---:  |
| GET    | /api/livros   | Obter todos os livros | Nenhum | Lista de livros |
| GET    | /api/livros(id) | Obter um livro por um identificador | Nenhum | Um livro |
| POST  | /api/livros | Adicionar um livro | Dados do livro | Nenhum|
| PUT   | /api/livros(id) | Atualizar os dados de um livro existente | Dados do livro | Nenhum |
| DELETE | /apilivros(id) | Excluir um livro | Nenhum | Nenhum|


## CONTROLE DE ACESSO

Também foi inserida controle de acesso no endpoint da API, ele restringe o acesso a somente usuários autenticados na aplicação, garantindo que somente ações autorizadas sejam realizadas.

### Token

Ainda no controle de acesso, é gerado um Token do tipo JWT (Json Web Token). 
