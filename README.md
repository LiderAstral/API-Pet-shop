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
  
### O projeto foi feito inteiramente em C#, utilizando ASP.NET 

## Como utilizar a API:

### A API está hospedada no seguinte domínio: https://liderastral.azurewebsites.net/api/Values
### Sua documentação se encontra no seguinte domínio: https://liderastral.azurewebsites.net/swagger/index.html

### Suas funcionalidades incluem:

1) Consulta de todos os gatos armazenados no banco de dados
2) Inserção de um gato no banco de dados
3) Alteração de um gato ja incluso no banco de dados
4) Exclusão física de um gato do banco de dados

## Consultando os Gatos:

### Para receber a lista de gatos cadastrados, deve-se enviar uma requisição utilizando o método GET, sem parâmetros adicionais. Seu retorno será um JSON com a lista dos respectivos gatos:

![GET](https://github.com/user-attachments/assets/dc981ae3-338e-4f72-a4fa-dd18a8c85df8)

+ A data de nascimento é retornada no formato: mm/dd/yyyy

## Inserindo um Gato:

### Para inserir um gato novo, deve-se enviar uma requisição utilizando o método POST, enviando todos os dados do gato no seguinte formato através do body:

![POST](https://github.com/user-attachments/assets/af4bc23e-6c39-4829-b34b-393f2037d390)

+ Não é necessário informar o ID_Gato, pois essa informação é adicionada automaticamente através de auto incremento no banco de dados.
+ A data de nascimento deve estar no formato: yyyy-mm-dd

## Editando um Gato

### Para editar um gato já existente, deve-se enviar uma requisição utilizando o método PUT, enviando o ID do gato previamente cadastrado e todos os novos dados do gato, estejam eles modificados ou não, no seguinte formato através do body: 

![PUT](https://github.com/user-attachments/assets/3d20dd4c-13f5-4c6e-bf95-66cafb725dae)

+ A data de nascimento deve estar no formato: yyyy-mm-dd

## Excluindo um Gato

### Para excluir um gato já existente, deve-se enviar uma requisição utilizando o método DELETE, enviando apenas o ID do gato previamente cadastrado em formato inteiro, através do body:

![DELETE](https://github.com/user-attachments/assets/2d5588f4-1d31-4571-9fcb-dc6183850693)

## Limitações da API





