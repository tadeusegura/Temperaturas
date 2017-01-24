Terminei quase todo o desafio. Decidi encerrar por aqui esta semana pois daqui a pouco eu saio de viagem.

Acabei empolgando e fiz um front-end. Subestimei o trabalho que isso iria dar rsrs

Alguns detalhes:
- visual studio 2015, C#, webAPI
- sql server usando entity framework
- Versionei no TFS
- O front-end é um SPA em angular, usando rotas e angular material
- serviço é acionado na tela e roda paralelo ao uso do sistema

Onde eu dei uma "esquecida" em boas práticas pra agilizar desenv e "deploy":
- banco versionado e junto com aplicação
- projeto de base está fortemente acoplado ao projeto web
- serviço é uma thread simples
- sem doc, nem comentários no código e nos check in de TFS
- claro, nem pensei em mobile first, cross-browser, etc, já que o foco do desafio é o back-end. Abrir somente no chrome.

por falta de tempo não fiz:
- busca por CEP
- ao invés de update por hora, update começa a cada 20s (para testes)
- só notei agora que os meus nomes dos endpoints do webAPI estão diferentes dos que você pediu. Logo, se vocês pretendiam aplicar teste automatizado, não vai rolar  :/
