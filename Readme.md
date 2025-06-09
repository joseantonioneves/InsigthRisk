# InsigtRisk

Aplicação destinada a análise de risco de investimentos em startup através de um assessment com perguntas que visam traçar o perfil de risco técnico do proponente.

## Estrutura do Projeto
O workspace contém uma solução chamada InsigthRisk.sln composta por quatro projetos principais:

- **IR.API**: API web, baseada em ASP.NET Core (usa .NET 8 e pacotes como Swashbuckle para Swagger/OpenAPI). Normalmente, esse projeto expõe endpoints HTTP para consumo externo.
- **IR.Domain**: Contém as entidades de domínio, enums, constantes e contexto de dados. É responsável pela lógica de negócio central e modelos de dados.
- **IR.Services**: Implementa serviços de domínio, mapeadores e lógica de negócio adicional, provavelmente consumidos pela API.
- **IR.SSO**: Indica um módulo de autenticação/autorização (Single Sign-On), responsável por gerenciar identidade e acesso.

O objetivo do workspace parece ser fornecer uma aplicação web estruturada em camadas, com separação clara entre API, domínio, serviços e autenticação, seguindo boas práticas de arquitetura em .NET.