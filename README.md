

O SuperLogs é um serviço/microserviço que tem como objetivo centralizar erros que podem surgir em diferentes camadas, ambientes e dispositivos de aplicações. Funcionando para melhorar o monitoramento dos erros e facilitar propostas de melhorias. 

Para tal, a melhor solução identificada foi a criação de uma API rest, por sua capacidade de "conversar" com diferentes aplicações através dos mesmos protocolos e gateways independentemente da linguagem da aplicação em questão. 

E para visualização e monitoramento dos erros optamos por desenvolver uma SPA que pode ser encontrada no seguinte link: [SuperLogs](https://superlogs.herokuapp.com/) e o código neste outro link: [github](https://github.com/RafaelMoura29/error-center)

### Tecnologias utilizadas
- Asp.NetCore
- React.js

### Ferramentas utilizadas
- Trello
- Azure
- Heroku
- Visual Studio

### Banco de dados
- SqlServer

### Arquitetura
Para uma melhor compreensão do código e de seu funcionamento e implementação de boas prática de arquitetura de software decidimos utilizar uma arquitetura de camadas que podem ser compreendidas na tabela abaixo.

Camada | Descrição |
------ | --------- |
API    | A camada API é responsável por definir as nossas rotas de comunicação através dos controllers, também é responsável por fazer a autenticação com o JWT, define as injenções de dependências e faz o roteamento das rotas para seu devido service. |
Model  | A camada model tem como finalidade representar nosso banco de dados através de classes e fazer a conexão com o SqlServer. |
Service | A camada service é onde definimos toda nossa lógica de negócio. |
Transport | A camada transpot é utilizada como uma camada a mais de abstração dos dados com o objetivo de deixar o formato dos dados específico para a demandada pela aplicação |  

### Desenvolvedores
- [Breno Felipe](https://www.linkedin.com/in/breno-gomes-8a7073b0/)
- [Jéssica Leite](https://www.linkedin.com/in/jessicaleite-dev/)
- [Rafael Moura](https://www.linkedin.com/in/rafael-moura-62891b181/)
- [Sarah Marinélli](https://www.linkedin.com/in/sarah-marin%C3%A9lli-076a9a16b/)
