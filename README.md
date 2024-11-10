# API Petshop

### API básica para realização de um CRUD em um banco de dados SQL Server que armazena informações sobre gatos de um Pet Shop.

## Um objeto Gato possui as seguintes propriedades:

+ ID_Gato - int
+ Nome - string
+ Cores - string
+ Tamanho - string
+ Peso - double (Armazenado em quilos)
+ Nascimento - string
+ Temperamento - string
  
## O projeto foi feito inteiramente em C#, utilizando ASP.NET 

## Como utilizar a API:

### A API está hospedada no seguinte domínio: https://liderastral.azurewebsites.net/api/Values
### Sua documentação se encontra no seguinte domínio: https://liderastral.azurewebsites.net/swagger/index.html

### Suas funcionalidades incluem

1) Consulta de todos os gatos armazenados no banco de dados
2) Inserção de um gato no banco de dados
3) Alteração de um gato ja incluso no banco de dados
4) Exclusão física de um gato do banco de dados

## Consultando os Gatos:

### Para receber a lista de gatos cadastrados, deve-se enviar uma requisição utilizando o método GET, sem parâmetros adicionais. Seu retorno será um JSON com a lista dos respectivos gatos:

![GET](https://github.com/user-attachments/assets/dc981ae3-338e-4f72-a4fa-dd18a8c85df8)

## Inserindo um Gato:

### Para inserir um gato novo, deve-se enviar uma requisição utilizando o método POST, enviando todos os dados do gato no seguinte formato através do body:

![POST](https://github.com/user-attachments/assets/f8d87228-30bc-4a69-9889-2f23751f192f)

### + Não é necessário informar o ID_Gato, pois essa informação é adicionada automaticamente através de auto incremento no banco de dados.
### + A data de nascimento deve estar no formato: yyyy-mm-dd


